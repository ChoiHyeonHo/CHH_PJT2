using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CHH_PJT2
{
    public class Main
    {
        public string staffID { get; set; }
        public string staffName { get; set; }
        public string Job { get; set; }
    }

    public class MainDB : IDisposable
    {
        MySqlConnection conn;
        public MainDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public Main GetID(string staffID)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select staffID, staffName, jobClassifyID from staff;";
            cmd.Connection = conn;

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Main main = new Main();
                main.staffID = reader[$"{staffID}"].ToString();
                //main.staffName = reader[$"{staffName}"].ToString();
                //main.Job = reader[$"{Job}"].ToString();

                return main;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 20201101 여기까지함
        /// </summary>
        /// <returns></returns>
        public DataTable LoadMemberData()
        {
            DataTable dt = new DataTable();
            string sql = @"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, grade,              birth, lessonCode, regDate, pPNum, nsReport, deleted, antecedent, stuPic from student;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
    }

}
