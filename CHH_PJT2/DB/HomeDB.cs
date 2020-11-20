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
    /// <summary>
    /// ProgressBar에 값을 담아 넘기기 위한 Property
    /// Att : 출석 학생수
    /// AllStu : 전체 학생수
    /// </summary>
    public class info
    {
        public int Att { get; set; }
        public int AllStu { get; set; }
    }

    public class HomeDB : IDisposable
    {
        MySqlConnection conn;

        /// <summary>
        /// HomeDB 로드시 DataBase 자동 연결
        /// </summary>
        public HomeDB()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
                conn.Open();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// ComboBox(연도)에 해당하는 값으로 등록한 학생 수 조회
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public DataTable GetRegDate(string cbo)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select month(regDate) mm, ifnull(count(stuID), '0') as stu
                                    from student where year(regDate) = {cbo}
                                    group by month(regDate);";
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
        /// 출석한 학생 수 조회
        /// 1. count(stuID) 수
        /// absence = 'N' (결석 No)
        /// </summary>
        /// <returns></returns>
        public DataTable GetAbsenceN()
        {
            try
            {
                DataTable dt2 = new DataTable();
                string abs = $@"select count(stuID), absence from attendance where absence = 'N' and attendanceDate = '{DateTime.Today.ToString("yyyy-MM-dd")}';"; // 출석
                MySqlDataAdapter da2 = new MySqlDataAdapter(abs, conn);
                da2.Fill(dt2);

                return dt2;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// 결석한 학생 수 조회
        /// 1. count(stuID) 수
        /// 2. absence ='Y' (결석 Yes)
        /// </summary>
        /// <returns></returns>
        public DataTable GetAbsenceY()
        {
            try
            {
                DataTable dt1 = new DataTable();
                string att = $@"select count(stuID), absence from attendance where absence = 'Y' and attendanceDate = '{DateTime.Today.ToString("yyyy-MM-dd")}';";
                MySqlDataAdapter da1 = new MySqlDataAdapter(att, conn);
                da1.Fill(dt1);

                return dt1;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// ProgressBar에 전달할 값 조회
        /// 1. DataReader로 조회
        /// 2. att = 출석한 학생 수 => (Info 클래스에 정의한 info타입의 Att(prop)가 받는다.)
        /// 3. allstu = 전체 학생수 => (Info 클래스에 정의한 info타입의 AllStu(prop)가 받는다.)
        /// </summary>
        /// <returns></returns>
        public info SetProgressBarValue()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"select count(stuID) as att, 
                                                            (select count(stuID) 
                                                            from attendance A1 
                                                            where A1.attendanceDate=A2.attendanceDate) allstu 
                                                        from attendance A2 where absence = 'Y' and attendanceDate = '{DateTime.Today.ToString("yyyy-MM-dd")}';";
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    info info = new info();
                    info.Att = Convert.ToInt32(reader["att"].ToString());
                    info.AllStu = Convert.ToInt32(reader["allstu"].ToString());
                    return info;
                }
                else
                    return null;
            }
            catch (Exception err)
            {
                throw err;
            }
            
        }

        
        public void Dispose()
        {
            conn.Close();
        }
    }
}
