using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CHH_PJT2
{
    public class LogIn
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string phNum { get; set; }
        public string address { get; set; }
        public DateTime birth { get; set; }
        public int JobClassifyID { get; set; }
        public string pwd { get; set; }
    }

    public class LogInDB : IDisposable
    {
        MySqlConnection conn;
        public LogInDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }


        public LogIn LogIn(string staffid, string pwd)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"select staffID, staffName, phNum, address, birth, 
                                jobClassifyID, staffPwd from staff 
                                where staffID = @staffID and staffPwd = @staffPwd;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
            cmd.Parameters["@staffID"].Value = staffid;

            cmd.Parameters.Add("@staffPwd", MySqlDbType.VarChar);
            cmd.Parameters["@staffPwd"].Value = pwd;

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                LogIn login = new LogIn();
                login.ID = reader["staffID"].ToString();
                login.pwd = reader["staffPwd"].ToString();

                return login;
            }
            else
            {
                return null;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
