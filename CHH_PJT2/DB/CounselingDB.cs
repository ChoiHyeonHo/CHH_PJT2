using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CHH_PJT2.DB
{
    /// <summary>
    /// 1. 상담번호, 상담일, 직원ID, 학생ID, 점수, 상담내용, 조치사항에 대한 Property
    ///2. 각 Property에 대한 초기값 설정
    /// </summary>
    public class SetCounselingText
    {
        public int advNum { get; set; }
        public DateTime advDate { get; set; }
        public string staffID { get; set; }
        public string stuID { get; set; }
        public int mathScore { get; set; }
        public string advContents { get; set; }
        public string actions { get; set; }
        public DateTime advReserve { get; set; }

        public SetCounselingText(int advNum, DateTime advDate, string staffID, string stuID, int mathScore, string advContents, string actions)
        {
            this.advNum = advNum;
            this.advDate = advDate;
            this.staffID = staffID;
            this.stuID = stuID;
            this.mathScore = mathScore;
            this.advContents = advContents;
            this.actions = actions;
        }
    }


    /// <summary>
    /// DB.cs 의 생성자 => DB 연결
    /// </summary>
    public class CounselingDB : IDisposable
    {
        MySqlConnection conn;
        public CounselingDB()
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
        /// frmCounseling 의 SetData()를 통해 호출되는 메서드
        /// 1. 상담번호, 상담일, 직원ID, 학생ID, 점수, 상담내용, 조치사항의 정보를 가져온다.
        /// 2. DataTable dt 선언후 dt 반환
        /// </summary>
        /// <returns></returns>
        public DataTable LoadCounselingData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select advNum, advDate, staffID, stuID, mathScore, advContents, actions
                             from counseling;";
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
        /// Counseling 대해 Create 메서드
        /// 1. 상담번호, 상담일, 직원ID, 학생ID, 점수, 상담내용, 조치사항 입력받도록
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool CreateAdvice(SetCounselingText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"insert into counseling (advNum, advDate, staffID, stuID, mathScore, advContents, actions)
                                                 values (@advNum, @advDate, @staffID, @stuID, @mathScore, @advContents, @actions);";
                cmd.Connection = conn;

                cmd.Parameters.Add("@advNum", MySqlDbType.Int32);
                cmd.Parameters["@advNum"].Value = st.advNum;

                cmd.Parameters.Add("@advDate", MySqlDbType.VarChar);
                cmd.Parameters["@advDate"].Value = st.advDate.ToString("yy-MM-dd");

                cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
                cmd.Parameters["@@staffID"].Value = st.staffID;

                cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
                cmd.Parameters["@stuID"].Value = st.stuID;

                cmd.Parameters.Add("@mathScore", MySqlDbType.Int32);
                cmd.Parameters["@mathScore"].Value = st.mathScore;

                cmd.Parameters.Add("@advContents", MySqlDbType.VarChar);
                cmd.Parameters["@advContents"].Value = st.advContents;

                cmd.Parameters.Add("@actions", MySqlDbType.VarChar);
                cmd.Parameters["@actions"].Value = st.actions;


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
        /// Counseling 대해 Update 메서드
        /// 1. 상담번호, 상담일, 직원ID, 학생ID, 점수, 상담내용, 조치사항 입력받도록
        /// 2. 단, advNum(상담번호, Pk)가 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateAdvice(SetCounselingText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"update counseling 
                                    set advDate = @advDate, staffID = @staffID, stuID = @stuID,
                                        mathScore = @mathScore, advContents = @advContents, actions = @actions
                                  where advNum = @advNum;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@advNum", MySqlDbType.Int32);
                cmd.Parameters["@advNum"].Value = st.advNum;

                cmd.Parameters.Add("@advDate", MySqlDbType.VarChar);
                cmd.Parameters["@advDate"].Value = st.advDate.ToString("yy-MM-dd");

                cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
                cmd.Parameters["@@staffID"].Value = st.staffID;

                cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
                cmd.Parameters["@stuID"].Value = st.stuID;

                cmd.Parameters.Add("@mathScore", MySqlDbType.Int32);
                cmd.Parameters["@mathScore"].Value = st.mathScore;

                cmd.Parameters.Add("@advContents", MySqlDbType.VarChar);
                cmd.Parameters["@advContents"].Value = st.advContents;

                cmd.Parameters.Add("@actions", MySqlDbType.VarChar);
                cmd.Parameters["@actions"].Value = st.actions;


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
        /// 엑셀 저장 버튼을 통해 호출되는 메서드
        /// 더블클릭에서 선택된 상담번호를 조건으로 해당하는 상담번호, 상담일, 학생ID, 직원ID, 점수, 상담내용, 조치사항의 Data를 가져온다.
        /// 리턴 dt
        /// </summary>
        /// <param name="advNum"></param>
        /// <returns></returns>
        public DataTable GetCounselingList(string advNum)
        {
            try
            {
                string sql = @" select advNum, advDate, staffID, stuID, mathScore, advContents, actions
                            from counseling where advNum = @advNum;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add("@advNum", MySqlDbType.Int32);
                da.SelectCommand.Parameters["@advNum"].Value = advNum;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
