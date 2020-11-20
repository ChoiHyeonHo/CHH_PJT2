using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CHH_PJT2.DB
{
    /// <summary>
    /// 1.  게시글 번호, 제목, 내용, 작성일, 작성자(staffID), 수정일에 대한 Property
    ///2. 각 Property에 대한 초기값 설정
    /// </summary>
    public class SetBoardText
    {
        public int boardID { get; set; }
        public string boardName { get; set; }
        public string boardContent { get; set; }
        public string postingDate { get; set; }
        public string staffID { get; set; }
        public string correctDate { get; set; }

        /// <summary>
        /// Board폼에서의 Update와 Delete에서 사용하기 위함.
        /// </summary>
        /// <param name="boardID"></param>
        /// <param name="boardName"></param>
        /// <param name="boardContent"></param>
        /// <param name="postingDate"></param>
        /// <param name="staffID"></param>
        /// <param name="correctDate"></param>
        public SetBoardText(int boardID, string boardName, string boardContent, string postingDate, string staffID, string correctDate)
        {
            this.boardID = boardID;
            this.boardName = boardName;
            this.boardContent = boardContent;
            this.postingDate = postingDate;
            this.staffID = staffID;
            this.correctDate = correctDate;
        }

        /// <summary>
        /// Board폼에서의 게시글 저장버튼(button1 클릭 이벤트)에서 사용하기 위함
        /// </summary>
        /// <param name="boardName"></param>
        /// <param name="boardContent"></param>
        /// <param name="postingDate"></param>
        /// <param name="staffID"></param>
        /// <param name="correctDate"></param>
        public SetBoardText(string boardName, string boardContent, string postingDate, string staffID, string correctDate)
        {
            this.boardName = boardName;
            this.boardContent = boardContent;
            this.postingDate = postingDate;
            this.staffID = staffID;
            this.correctDate = correctDate;
        }
    }

    public class Info
    {
        public string staffID { get; set; } // 로그인되어있는 현재 사용자의 ID를 받기 위함
    }

    public class GetStaffID
    {
        public string staffID { get; set; }
    }

    /// <summary>
    /// DB.cs 의 생성자 => DB 연결
    /// </summary>
    public class BoardDB : IDisposable
    {
        MySqlConnection conn;

        public BoardDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }


        /// <summary>
        /// Board 폼에서의 SetData()에서 호출되는 메서드
        /// 게시글 번호, 제목, 내용, 작성일, 작성자, 수정일의 정보를 가져온다
        /// </summary>
        /// <returns></returns>
        public DataTable LoadBoardData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select boardID, boardName, boardContent, postingDate, staffID, correctDate from Board;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// Board 대해 Delete 메서드
        /// 1. boardID(게시글 번호, PK)가 일치하면 Data 삭제
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool DeleteBoard(SetBoardText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"delete from Board where boardID = @boardID;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@boardID", MySqlDbType.Int32);
                cmd.Parameters["@boardID"].Value = st.boardID;
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// Board의 게시글 검색을 위한 메서드
        /// 1. boardName(게시글 제목)이 포함되면 검색되도록 => %{cboText}%
        /// 2. 리턴 dt
        /// </summary>
        /// <param name="cboText"></param>
        /// <returns></returns>
        public DataTable SearchBoard(string cboText)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select boardID, boardName, boardContent, postingDate, staffID, correctDate
                                     from Board where boardName like '%{cboText}%'; ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }



        /// <summary>
        /// Board 대해 Update 메서드
        /// 1. 게시글 제목, 내용, 수정일, 작성자 입력받도록
        /// 2. 단, boardID(게시글 번호, Pk)가 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateBoard(SetBoardText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"update Board set boardName = @boardName, boardContent = @boardContent, correctDate = @correctDate, staffID = @staffID
                                                    where boardID = @boardID;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@boardName", MySqlDbType.VarChar);
                cmd.Parameters["@boardName"].Value = st.boardName;

                cmd.Parameters.Add("@boardContent", MySqlDbType.VarChar);
                cmd.Parameters["@boardContent"].Value = st.boardContent;

                cmd.Parameters.Add("@correctDate", MySqlDbType.VarChar);
                cmd.Parameters["@correctDate"].Value = st.correctDate;

                cmd.Parameters.Add("@boardID", MySqlDbType.Int32);
                cmd.Parameters["@boardID"].Value = st.boardID;

                cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
                cmd.Parameters["@staffID"].Value = st.staffID;

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// Board 대해 Create 메서드
        /// 1. 게시글 제목, 내용, 수정일, 작성자 입력받도록
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool CreateBoard(SetBoardText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"insert into Board(boardName, boardContent, postingDate, staffID, correctDate)
                                                        values (@boardName, @boardContent, @postingDate, @staffID, @correctDate);";
                cmd.Connection = conn;

                cmd.Parameters.Add("@boardName", MySqlDbType.VarChar);
                cmd.Parameters["@boardName"].Value = st.boardName;

                cmd.Parameters.Add("@boardContent", MySqlDbType.VarChar);
                cmd.Parameters["@boardContent"].Value = st.boardContent;

                cmd.Parameters.Add("@postingDate", MySqlDbType.VarChar);
                cmd.Parameters["@postingDate"].Value = st.postingDate;

                cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
                cmd.Parameters["@staffID"].Value = st.staffID;

                cmd.Parameters.Add("@correctDate", MySqlDbType.VarChar);
                cmd.Parameters["@correctDate"].Value = st.correctDate;

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
