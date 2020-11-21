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
    /// 1.  출석번호, 학생ID, 입/퇴실 시간, 지각, 결석, 조퇴여부, 출석일, 기록사항, 학생이름, 수강코드에 대한 Property
    ///2. 각 Property에 대한 초기값 설정
    /// </summary>
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
        public string lessonCode { get; set; }

        public SetAttendanceText()
        {

        }
        /// <summary>
        /// DetAttendance폼의 출석이미지 클릭을 위함
        /// </summary>
        /// <param name="enteringTime"></param>
        /// <param name="stuName"></param>
        public SetAttendanceText(DateTime enteringTime, string stuName)
        {
            this.enteringTime = enteringTime;
            this.stuName = stuName;
        }

        /// <summary>
        /// DetAttendance폼의 결석이미지 클릭을 위함
        /// </summary>
        /// <param name="entranceTime"></param>
        /// <param name="stuName"></param>
        /// <param name="recordContent"></param>
        public SetAttendanceText(DateTime entranceTime, string stuName, string recordContent)
        {
            this.entranceTime = entranceTime;
            this.stuName = stuName;
            this.recordContent = recordContent;
        }

        /// <summary>
        /// DetAttendance폼의 기타이미지 클릭을 위함
        /// </summary>
        /// <param name="enteringTime"></param>
        /// <param name="entranceTime"></param>
        /// <param name="lateness"></param>
        /// <param name="early_Leave"></param>
        /// <param name="recordContent"></param>
        /// <param name="stuName"></param>
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


    /// <summary>
    /// DB.cs 의 생성자 => DB 연결
    /// </summary>
    class AttendanceDB : IDisposable
    {
        MySqlConnection conn;

        public AttendanceDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }


        /// <summary>
        /// frmAttendance 의 SetData()를 통해 호출되는 메서드
        /// 1. DB의 student 테이블에서 학생이름, 수강코드
        /// 2. DB의 attendance 테이블에서 출석번호, 학생ID, 입/퇴실시간, 지각, 조퇴, 결석여부, 출석일, 기록사항을 가져온다
        /// 3. 1과2의 내용을 쿼리문 Join 사용
        /// 2. DataTable dt 선언후 dt 반환
        /// </summary>
        /// <returns></returns>
        public DataTable LoadAttendanceData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select A.attendanceNum, A.stuID, A.enteringTime, A.entranceTime, A.lateness, A.absence, 
	                              A.early_Leave, A.attendanceDate, A.recordContent, S.stuName, S.lessonCode
                                  from student S inner join attendance A on A.stuID = S.stuID; ";
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
        /// 파라미터인 cboText의 내용을 쿼리문 where절에 담아 수행하는 메서드
        /// cboText의 내용은 공통코드인 LessonType
        /// </summary>
        /// <param name="cboText"></param>
        /// <returns></returns>
        public DataTable LoadLesson(string cboText)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select A.attendanceNum, A.stuID, A.enteringTime, A.entranceTime, A.lateness, A.absence, 
	                              A.early_Leave, A.attendanceDate, A.recordContent, S.stuName, S.lessonCode
                                  from student S inner join attendance A on A.stuID = S.stuID where S.lessonCode = '{cboText}'; ";
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
        /// DetAttendance 대해 입실시간 Update 메서드
        /// 1. 입실시간(attendance 테이블), 학생이름(student 테이블) 입력받도록 => inner join사용, on stuID
        /// 2. 단, stuName(학생 이름)이 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateEnteringTime(SetAttendanceText st)
        {
            try
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
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// DetAttendance 대해 퇴실시간 Update 메서드
        /// 1. 퇴실시간(attendance 테이블), 학생이름(student 테이블) 입력받도록 => inner join사용, on stuID
        /// 2. 퇴실시간, 기록사항과 결석여부 Y변경
        /// 2. 단, stuName(학생 이름)이 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateEnteranceTime(SetAttendanceText st)
        {
            try
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
            catch (Exception err)
            {
                throw err;
            }
        }


        /// <summary>
        /// DetAttendance 대해 기타 Update 메서드
        /// 1. 입실시간, 퇴실시간, 지각여부, 결석여부, 조퇴여부, 학생이름 입력받도록 => inner join사용, on stuID
        /// 2. 단, stuName(학생 이름)이 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateETC(SetAttendanceText st)
        {
            try
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
