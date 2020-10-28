using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CHH_PJT2.DB
{
    class LogInDB : IDisposable
    {
        MySqlConnection conn;
        public LogInDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }
        public struct StaffInfo
        {
            public string staffID;
            public string staffPwd;
            public string phNum;
            public string address;
            public string birth;
            public int jobClassifyID;

            public StaffInfo(string staffID, string staffPwd, string phNum, string address, string birth, int jobClassifyID)
            {
                this.staffID = staffID;
                this.staffPwd = staffPwd;
                this.phNum = phNum;
                this.address = address;
                this.birth = birth;
                this.jobClassifyID = jobClassifyID;
            }
        }

        public bool LogInCheck(StaffInfo staffInfo)
        {
            string sql = $@"select staffID, staffpwd  from staff where staffID= @staffID and staffPwd= @staffPwd;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
            cmd.Parameters.Add("@staffPwd", MySqlDbType.VarChar);
            cmd.Parameters["@staffID"].Value = staffInfo.staffID;
            cmd.Parameters["@staffPwd"].Value = staffInfo.staffPwd;

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
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
