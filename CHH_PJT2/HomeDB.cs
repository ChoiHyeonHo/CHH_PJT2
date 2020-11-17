using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace CHH_PJT2
{
    public class HomeDB : IDisposable
    {
        MySqlConnection conn;
        public HomeDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();

        }

        public DataTable GetRegDate(string cbo)
        {
            DataTable dt = new DataTable();
            string sql = $@"select month(regDate) mm, ifnull(count(stuID), '0') as stu
                                    from student where year(regDate) = {cbo}
                                    group by month(regDate);";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAttendance()
        {
            DataTable dt1 = new DataTable();
            string att = $@"select count(stuID), absence from attendance where absence = 'Y' and attendanceDate = '{DateTime.Today.ToString("yyyy-MM-dd")}';"; // 출석
            MySqlDataAdapter da1 = new MySqlDataAdapter(att, conn);
            da1.Fill(dt1);

            return dt1;
        }

        public DataTable GetAbsence()
        {
            DataTable dt2 = new DataTable();
            string abs = $@"select count(stuID), absence from attendance where absence = 'N' and attendanceDate = '{DateTime.Today.ToString("yyyy-MM-dd")}';"; // 출석
            MySqlDataAdapter da2 = new MySqlDataAdapter(abs, conn);
            da2.Fill(dt2);

            return dt2;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
