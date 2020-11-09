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
        public DateTime enteringTime { get; set; }
        public DateTime entranceTime { get; set; }
        public char lateness { get; set; }
        public char absence { get; set; }
        public char early_Leave { get; set; }
        public DateTime attendanceDate { get; set; }
        public string recordContent { get; set; }
        public string stuName { get; set; }
        public int lessonCode { get; set; }

        public SetAttendanceText(DateTime enteringTime, string stuName)
        {
            this.enteringTime = enteringTime;
            this.stuName = stuName;
        }

        public SetAttendanceText(DateTime entranceTime, string stuName, string recordContent)
        {
            this.entranceTime = entranceTime;
            this.stuName = stuName;
            this.recordContent = recordContent;
        }

        public SetAttendanceText(DateTime enteringTime, DateTime entranceTime, char lateness, char early_Leave, string recordContent, string stuName)
        {
            this.enteringTime = enteringTime;
            this.entranceTime = entranceTime;
            this.lateness = lateness;
            this.early_Leave = early_Leave;
            this.recordContent = recordContent;
            this.stuName = stuName;
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
                                  from student S inner join attendance A on A.stuID = S.stuID; ";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public bool UpdateEnteringTime(SetAttendanceText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"update attendance A inner join student S
                                 on A.stuID = S.stuID
                                 set enteringTime = @enteringTime
                                 where S.stuName = @stuName;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@enteringTime", MySqlDbType.VarChar);
            cmd.Parameters["@enteringTime"].Value = st.enteringTime.ToString("HH:mm");

            cmd.Parameters.Add("@stuName", MySqlDbType.VarChar);
            cmd.Parameters["@stuName"].Value = st.stuName;


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

        public bool UpdateEnteranceTime(SetAttendanceText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"update attendance A inner join student S
                                 on A.stuID = S.stuID
                                 set A.entranceTime = @entranceTime , A.absence = 'Y', A.recordContent = @recordContent
                                 where S.stuName = @stuName;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@entranceTime", MySqlDbType.VarChar);
            cmd.Parameters["@entranceTime"].Value = st.entranceTime.ToString("HH:mm");

            cmd.Parameters.Add("@recordContent", MySqlDbType.Text);
            cmd.Parameters["@recordContent"].Value = st.recordContent;

            cmd.Parameters.Add("@stuName", MySqlDbType.VarChar);
            cmd.Parameters["@stuName"].Value = st.stuName;


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

        public bool UpdateETC(SetAttendanceText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"update attendance A inner join student S
                                 on A.stuID = S.stuID
                                 set A.enteringTime = @enteringTime, A.entranceTime = @entranceTime, A.lateness = @lateness, 
                                     early_Leave = @early_Leave, recordContent = @recordContent
                                 where S.stuName = @stuName;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@enteringTime", MySqlDbType.VarChar);
            cmd.Parameters["@enteringTime"].Value = st.enteringTime.ToString("HH:mm");

            cmd.Parameters.Add("@entranceTime", MySqlDbType.VarChar);
            cmd.Parameters["@entranceTime"].Value = st.entranceTime.ToString("HH:mm");

            cmd.Parameters.Add("@lateness", MySqlDbType.VarChar);
            cmd.Parameters["@lateness"].Value = st.lateness;

            cmd.Parameters.Add("@early_Leave", MySqlDbType.VarChar);
            cmd.Parameters["@early_Leave"].Value = st.early_Leave;

            cmd.Parameters.Add("@recordContent", MySqlDbType.Text);
            cmd.Parameters["@recordContent"].Value = st.recordContent;

            cmd.Parameters.Add("@stuName", MySqlDbType.VarChar);
            cmd.Parameters["@stuName"].Value = st.stuName;


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
