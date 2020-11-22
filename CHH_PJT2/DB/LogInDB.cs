using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace CHH_PJT2
{
    public class LogIn
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string phNum { get; set; }
        public string address { get; set; }
        public DateTime birth { get; set; }
        public string JobClassifyID { get; set; }
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
            cmd.CommandText = @"select staffID, staffName, phNum, postalCode, birth, 
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
                login.Name = reader["staffName"].ToString();
                login.JobClassifyID =reader["jobClassifyID"].ToString();
                return login;
            }
            else
            {
                return null;
            }
        }

        //ID 유효한지 체크
        public int SearchID(string Name, string phNum, DateTime Birth, string job)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"select count(*) from staff where staffName = @staffName and 
                                phNum = @phNum and birth = @birth and jobClassifyID = @jobClassifyID;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@staffName", MySqlDbType.VarChar);
            cmd.Parameters["@staffName"].Value = Name;

            cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
            cmd.Parameters["@phNum"].Value = phNum;

            cmd.Parameters.Add("@birth", MySqlDbType.Date);
            cmd.Parameters["@birth"].Value = Birth.ToString("yyyy-MM-dd");

            cmd.Parameters.Add("@jobClassifyID", MySqlDbType.VarChar);
            cmd.Parameters["@jobClassifyID"].Value = job;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Pwd찾기에서 입력한 정보가 유효한지 체크
        public int CheckPwd(string Name, string phNum, string ID, string Job)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"select count(*) from staff where staffName = @staffName 
                                and staffID = @staffID and  phNum = @phNum and jobClassifyID = @jobClassifyID;";
            cmd.Connection = conn;

            LogIn logIn = new LogIn();
            cmd.Parameters.Add("@staffName", MySqlDbType.VarChar);
            cmd.Parameters["@staffName"].Value = Name;

            cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
            cmd.Parameters["@staffID"].Value = ID;

            cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
            cmd.Parameters["@phNum"].Value = phNum;

            cmd.Parameters.Add("@jobClassifyID", MySqlDbType.VarChar);
            cmd.Parameters["@jobClassifyID"].Value = Job;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //ID 찾은 결과 반환
        public string ResultID(string Name, string phNum, DateTime birth, string Classify)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = @"select staffID from staff where staffName = @staffName 
                                and phNum = @phNum and birth = @birth and jobClassifyID = @jobClassifyID;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@staffName", MySqlDbType.VarChar);
                cmd.Parameters["@staffName"].Value = Name;

                cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
                cmd.Parameters["@phNum"].Value = phNum;

                cmd.Parameters.Add("@birth", MySqlDbType.Date);
                cmd.Parameters["@birth"].Value = birth.ToString("yyyy-MM-dd");

                cmd.Parameters.Add("@jobClassifyID", MySqlDbType.VarChar);
                cmd.Parameters["@jobClassifyID"].Value = Classify;

                string uid = (string)cmd.ExecuteScalar();

                return uid;
            }
            catch (Exception err)
            {

                throw err;
            }
            
        }

        //Pwd 변경
        public bool ChangePwd(string Name, string phNum, string ID, string Job, string Pwd)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"update staff set staffPwd = @staffPwd where staffName = @staffName 
                                and phNum = @phNum and staffID = @staffID and jobClassifyID = @jobClassifyID;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@staffPwd", MySqlDbType.VarChar);
            cmd.Parameters["@staffPwd"].Value = Pwd;

            cmd.Parameters.Add("@staffName", MySqlDbType.VarChar);
            cmd.Parameters["@staffName"].Value = Name;

            cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
            cmd.Parameters["@phNum"].Value = phNum;

            cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
            cmd.Parameters["@staffID"].Value = ID;

            cmd.Parameters.Add("@jobClassifyID", MySqlDbType.VarChar);
            cmd.Parameters["@jobClassifyID"].Value = Job;

            int rowResult = cmd.ExecuteNonQuery();

            if (rowResult > 0)
                return true;
            else
                return false;
        }

        public DataTable Category(string category)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select Code, Name from CommonCode where Category = @Category order by Code;";
            cmd.Connection = conn;
            cmd.Parameters.Add("@Category", MySqlDbType.VarChar);
            cmd.Parameters["@Category"].Value = category;

            da.SelectCommand = cmd;

            da.Fill(dt);
            return dt;
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
