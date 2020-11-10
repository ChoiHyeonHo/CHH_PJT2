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

        public DataTable LoadCounselingData()
        {
            DataTable dt = new DataTable();
            string sql = @"select advNum, advDate, staffID, stuID, mathScore, advContents, actions
                             from counseling;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public bool InsertAdvice(SetCounselingText st)
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

        public bool UpdateAdvice(SetCounselingText st)
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

        public DataTable GetCounselingList(string advNum)
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
    }
}
