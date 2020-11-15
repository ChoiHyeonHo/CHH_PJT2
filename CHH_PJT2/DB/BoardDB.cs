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
    public class SetBoardText
    {
        public int boardID { get; set; }
        public string boardName { get; set; }
        public string boardContent { get; set; }
        public string postingDate { get; set; }
        public string staffID { get; set; }
        public string correctDate { get; set; }

        public SetBoardText(int boardID, string boardName, string boardContent, string postingDate, string staffID, string correctDate)
        {
            this.boardID = boardID;
            this.boardName = boardName;
            this.boardContent = boardContent;
            this.postingDate = postingDate;
            this.staffID = staffID;
            this.correctDate = correctDate;
        }
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
        public string staffID { get; set; }
    }

    public class GetStaffID
    {
        public string staffID { get; set; }
    }
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

        public DataTable LoadBoardData()
        {
            DataTable dt = new DataTable();
            string sql = @"select boardID, boardName, boardContent, postingDate, staffID, correctDate from Board;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
        public bool DeleteBoard(SetBoardText st)
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

        public DataTable SearchBoard(string cboText)
        {
            DataTable dt = new DataTable();
            string sql = $@"select boardID, boardName, boardContent, postingDate, staffID, correctDate
                                     from Board where boardName like '%{cboText}%'; ";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateBoard(SetBoardText st)
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

        public bool InsertBoard(SetBoardText st)
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
    }
}
