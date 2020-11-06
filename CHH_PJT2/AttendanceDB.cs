using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace CHH_PJT2
{
    public class SetAttendanceText
    {
        public int attendanceNum { get; set; }
        public string stuID { get; set; }
        public string enteringTime { get; set; }
        public string entranceTime { get; set; }
        public char lateness { get; set; }
        public char absence { get; set; }
        public char early_Leave { get; set; }
        public string attendanceDate { get; set; }
        public string recordContent { get; set; }
        public string stuName { get; set; }
        public int lessonCode { get; set; }

        public SetAttendanceText(string enteringTime, string entranceTime,string stuName, int lessonCode)
        {
            this.enteringTime = enteringTime;
            this.entranceTime = entranceTime;
            this.stuName = stuName;
            this.lessonCode = lessonCode;
        }

    }
    class AttendanceDB : IDisposable
    {
        MySqlConnection conn;

        public AttendanceDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        public DataTable LoadAttendanceData()
        {
            DataTable dt = new DataTable();
            string sql = @"select A.attendanceNum, A.stuID, A.enteringTime, A.entranceTime, A.lateness, A.absence, 
	                              A.early_Leave, A.attendanceDate, A.recordContent, S.stuName, S.lessonCode
                                  from attendance A inner join student S on A.stuID = S.stuID; ";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateEnteringTime(SetAttendanceText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"update attendance set enteringTime = @enteringTime where stuID = @stuID;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@enteringTime", MySqlDbType.VarChar);
            cmd.Parameters["@enteringTime"].Value = st.enteringTime;

            cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
            cmd.Parameters["@stuID"].Value = st.stuID;


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

        public void Dispose()
        {
            conn.Close();
        }
    }
}
