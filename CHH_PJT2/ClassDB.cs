using MySql.Data.MySqlClient;
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
    public class SetClassText
    {
        public int lessonCode { get; set; }
        public string lessonName { get; set; }
        public string classDistribution { get; set; }
        public string staffID { get; set; }
        public DateTime lessonStartDate { get; set; }
        public DateTime lessonEndDate { get; set; }
        public DateTime lessonStartTime { get; set; }
        public DateTime lessonEndTime { get; set; }
        public int lessonAmount { get; set; }
        public string NsReport { get; set; }

        public SetClassText(int lessonCode, string lessonName, string classDistribution, string staffID, DateTime lessonStartDate, DateTime lessonEndDate, DateTime lessonStartTime, DateTime lessonEndTime, int lessonAmount, string NsReport)
        {
            this.lessonCode = lessonCode;
            this.lessonName = lessonName;
            this.classDistribution = classDistribution;
            this.staffID = staffID;
            this.lessonStartDate = lessonStartDate;
            this.lessonEndDate = lessonEndDate;
            this.lessonStartTime = lessonStartTime;
            this.lessonEndTime = lessonEndTime;
            this.lessonAmount = lessonAmount;
            this.NsReport = NsReport;
        }
    }
    class ClassDB : IDisposable
    {
        MySqlConnection conn;
        public ClassDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        public DataTable LoadMemberData()
        {
            DataTable dt = new DataTable();
            string sql = @"select lessonCode, lessonName, classDistribution, staffID, lessonStartDate, lessonEndDate, 
                                  lessonStartTime, lessonEndTime, lessonAmount, lessonNsReport from class;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public bool CreateClass(SetClassText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into class(lessonCode, lessonName, classDistribution, staffID, lessonStartDate, 
                                lessonEndDate, lessonStartTime, lessonEndTime, lessonAmount, lessonNsReport)
                                values (@lessonCode, @lessonName, @classDistribution, @staffID, @lessonStartDate,
                                @lessonEndDate, @lessonStartTime, @lessonEndTime, @lessonAmount, @lessonNsReport);";
            cmd.Connection = conn;

            cmd.Parameters.Add("@lessonCode", MySqlDbType.Int32);
            cmd.Parameters["@lessonCode"].Value = st.lessonCode;

            cmd.Parameters.Add("@lessonName", MySqlDbType.VarChar);
            cmd.Parameters["@lessonName"].Value = st.lessonName;

            cmd.Parameters.Add("@classDistribution", MySqlDbType.VarChar);
            cmd.Parameters["@classDistribution"].Value = st.classDistribution;

            cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
            cmd.Parameters["@staffID"].Value = st.staffID;

            cmd.Parameters.Add("@lessonStartDate", MySqlDbType.Date);
            cmd.Parameters["@lessonStartDate"].Value = st.lessonStartDate;

            cmd.Parameters.Add("@lessonEndDate", MySqlDbType.Date);
            cmd.Parameters["@lessonEndDate"].Value = st.lessonEndDate;

            cmd.Parameters.Add("@lessonStartTime", MySqlDbType.VarChar);
            cmd.Parameters["@lessonStartTime"].Value = st.lessonStartTime.ToString("HH:mm");

            cmd.Parameters.Add("@lessonEndTime", MySqlDbType.VarChar);
            cmd.Parameters["@lessonEndTime"].Value = st.lessonEndTime.ToString("HH:mm");

            cmd.Parameters.Add("@lessonAmount", MySqlDbType.Int32);
            cmd.Parameters["@lessonAmount"].Value = st.lessonAmount;

            cmd.Parameters.Add("@lessonNsReport", MySqlDbType.Text);
            cmd.Parameters["@lessonNsReport"].Value = st.NsReport;

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

        public bool UpdateClass(SetClassText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"update class set lessonName = @lessonName, classDistribution = @classDistribution, 
                                 staffID = @staffID, lessonStartDate = @lessonStartDate, lessonEndDate = @lessonEndDate, 
                                 lessonStartTime = @lessonStartTime, lessonEndTime = @lessonEndTime, lessonAmount = @lessonAmount,
                                 lessonNsReport = @lessonNsReport where lessonCode = @lessonCode;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@lessonName", MySqlDbType.VarChar);
            cmd.Parameters["@lessonName"].Value = st.lessonName;

            cmd.Parameters.Add("@classDistribution", MySqlDbType.VarChar);
            cmd.Parameters["@classDistribution"].Value = st.classDistribution;

            cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
            cmd.Parameters["@staffID"].Value = st.staffID;

            cmd.Parameters.Add("@lessonStartDate", MySqlDbType.Date);
            cmd.Parameters["@lessonStartDate"].Value = st.lessonStartDate;

            cmd.Parameters.Add("@lessonEndDate", MySqlDbType.Date);
            cmd.Parameters["@lessonEndDate"].Value = st.lessonEndDate;

            cmd.Parameters.Add("@lessonStartTime", MySqlDbType.VarChar);
            cmd.Parameters["@lessonStartTime"].Value = st.lessonStartTime.ToString("HH:mm");

            cmd.Parameters.Add("@lessonEndTime", MySqlDbType.VarChar);
            cmd.Parameters["@lessonEndTime"].Value = st.lessonEndTime.ToString("HH:mm");

            cmd.Parameters.Add("@lessonAmount", MySqlDbType.Int32);
            cmd.Parameters["@lessonAmount"].Value = st.lessonAmount;

            cmd.Parameters.Add("@lessonNsReport", MySqlDbType.Text);
            cmd.Parameters["@lessonNsReport"].Value = st.NsReport;

            cmd.Parameters.Add("@lessonCode", MySqlDbType.Int32);
            cmd.Parameters["@lessonCode"].Value = st.lessonCode;

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

        public bool DeleteClass(SetClassText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"delete from class where lessonCode = @lessonCode;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@lessonCode", MySqlDbType.Int32);
            cmd.Parameters["@lessonCode"].Value = st.lessonCode;

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
