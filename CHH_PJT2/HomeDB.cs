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

        public List<int> GetGraphChart()
        {
            List<int> usercount = new List<int>();
            
            for (int i = 1; i < 13; i++)
            {
                string sql = $"select count(stuID) as 등록수 from student where month(regDate) = '{i}'";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
                usercount.Add(Convert.ToInt32(dt.Rows[0][0]));
            }
            return usercount;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
