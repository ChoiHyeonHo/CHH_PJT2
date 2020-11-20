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

    /// <summary>
    /// 1.  수강코드, 강의명, 클래스분류, 직원ID, 강의시작/종료일, 강의시작/종료시간, 수강료, 특이사항에 대한 Property
    /// 2. 각 Property에 대한 초기값 설정
    /// </summary>
    public class SetClassText
    {
        public string lessonCode { get; set; }
        public string lessonName { get; set; }
        public string classDistribution { get; set; }
        public string staffID { get; set; }
        public DateTime lessonStartDate { get; set; }
        public DateTime lessonEndDate { get; set; }
        public DateTime lessonStartTime { get; set; }
        public DateTime lessonEndTime { get; set; }
        public int lessonAmount { get; set; }
        public string NsReport { get; set; }

        public SetClassText(string lessonCode, string lessonName, string classDistribution, string staffID, DateTime lessonStartDate, DateTime lessonEndDate, DateTime lessonStartTime, DateTime lessonEndTime, int lessonAmount, string NsReport)
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

    /// <summary>
    /// DB.cs 의 생성자 => DB 연결
    /// </summary>
    class ClassDB : IDisposable
    {
        MySqlConnection conn;
        public ClassDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        /// <summary>
        /// frmClass 의 SetData()를 통해 호출되는 메서드
        /// 1. 강의코드, 강의명, 클래스분류, 직원ID, 학생ID, 강의시작/종료일, 강의시작/종료시간, 특이사항, 수강료의 정보를 가져온다.
        /// 2. DataTable dt 선언후 dt 반환
        /// </summary>
        /// <returns></returns>
        public DataTable LoadClassData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select lessonCode, lessonName, classDistribution, staffID, lessonStartDate, lessonEndDate, 
                                  lessonStartTime, lessonEndTime, lessonAmount, lessonNsReport from class;";
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
        /// 새로고침 버튼 클릭시 호출되는 메서드
        /// 1. 강의코드, 강의명, 클래스분류, 직원ID, 학생ID, 강의시작/종료일, 강의시작/종료시간, 특이사항, 수강료를 ComboBox 파라미터인 cboText를 조건으로 하여 가져온다
        /// 2. 리턴값 DataTable인 dt
        /// </summary>
        /// <param name="cboText"></param>
        /// <returns></returns>
        public DataTable LoadClass(string cboText)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select lessonCode, lessonName, classDistribution, staffID, lessonStartDate, lessonEndDate, 
                                  lessonStartTime, lessonEndTime, lessonAmount, lessonNsReport from class where lessonCode = '{cboText}';";
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
        ///  Class 대해 Create 메서드
        /// 1. 강의코드, 강의명, 클래스분류, 직원ID, 학생ID, 강의시작/종료일, 강의시작/종료시간, 수강료, 특이사항 입력받도록
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool CreateClass(SetClassText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = @"insert into class(lessonCode, lessonName, classDistribution, staffID, lessonStartDate, 
                                lessonEndDate, lessonStartTime, lessonEndTime, lessonAmount, lessonNsReport)
                                values (@lessonCode, @lessonName, @classDistribution, @staffID, @lessonStartDate,
                                @lessonEndDate, @lessonStartTime, @lessonEndTime, @lessonAmount, @lessonNsReport);";
                cmd.Connection = conn;

                cmd.Parameters.Add("@lessonCode", MySqlDbType.VarChar);
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
            catch (Exception err)
            {

                throw err;
            }
        }


        /// <summary>
        /// Class 대해 Update 메서드
        /// 1. 강의코드, 강의명, 클래스분류, 직원ID, 학생ID, 강의시작/종료일, 강의시작/종료시간, 수강료, 특이사항 입력받도록
        /// 2. 단, lessonCode(강의코드, Pk)가 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateClass(SetClassText st)
        {
            try
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

                cmd.Parameters.Add("@lessonCode", MySqlDbType.VarChar);
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
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// Class 대해 Delete 메서드
        /// 1. lessonCode(강의코드, PK)가 일치하면 Data 삭제
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool DeleteClass(SetClassText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = @"delete from class where lessonCode = @lessonCode;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@lessonCode", MySqlDbType.VarChar);
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
