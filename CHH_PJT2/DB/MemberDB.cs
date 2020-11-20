using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace CHH_PJT2
{
    /// <summary>
    ///1.  ID, 이름, 성별, 번호, 주소, 학교, 반, 생일, 수강코드, 등록일, 보호자번호, 특이사항, 선행학습정도, ComboBox에 대한 Property
    ///2. 각 Property에 대한 초기값 설정
    /// </summary>
    public class SetMemberText
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string phNum { get; set; }
        public string postalCode { get; set; }
        public string priAddress { get; set; }
        public string detAddress { get; set; }
        public string School { get; set; }
        public string Class { get; set; }
        public DateTime birth { get; set; }
        public string lessonCode { get; set; }
        public DateTime regDate { get; set; }
        public string ppNum { get; set; }
        public string nsReport { get; set; }
        public string antecedent { get; set; }
        public string combobox { get; set; }

        public SetMemberText(string ID, string Name, string Gender, string phNum, string postalCode, string priAddress, string detAddress, string School, string Class, DateTime birth, string lessonCode, DateTime regDate, string ppNum, string nsReport, string antecedent)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.phNum = phNum;
            this.postalCode = postalCode;
            this.priAddress = priAddress;
            this.detAddress = detAddress;
            this.School = School;
            this.Class = Class;
            this.birth = birth;
            this.lessonCode = lessonCode;
            this.regDate = regDate;
            this.ppNum = ppNum;
            this.nsReport = nsReport;
            this.antecedent = antecedent;
        }

        public SetMemberText(string combobox)
        {
            this.combobox = combobox;
        }
    }

    /// <summary>
    /// DB.cs 의 생성자 => DB 연결
    /// </summary>
    public class MemberDB : IDisposable
    {
        MySqlConnection conn;
        public MemberDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// Member에 대해 Create 메서드
        /// 1. ID, 이름, 성별, 번호, 주소, 학교, 반, 생일, 수강코드, 등록일, 보호자 번호, 특이사항, 선행학습정도 입력받도록
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool CreateMember(SetMemberText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"insert into student(stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, class, birth, lessonCode, regDate, pPNum, nsReport, antecedent) values(@stuID, @stuName, @stuGender, @phNum, @postalCode, @priAddress, @detAddress, @school, @class, @birth, @lessonCode, @regDate, @pPNum, @nsReport, @antecedent); ";
                cmd.Connection = conn;

                cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
                cmd.Parameters["@stuID"].Value = st.ID;

                cmd.Parameters.Add("@stuName", MySqlDbType.VarChar);
                cmd.Parameters["@stuName"].Value = st.Name;

                cmd.Parameters.Add("@stuGender", MySqlDbType.VarChar);
                cmd.Parameters["@@stuGender"].Value = st.Gender;

                cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
                cmd.Parameters["@phNum"].Value = st.phNum;

                cmd.Parameters.Add("@postalCode", MySqlDbType.VarChar);
                cmd.Parameters["@postalCode"].Value = st.postalCode;

                cmd.Parameters.Add("@priAddress", MySqlDbType.VarChar);
                cmd.Parameters["@priAddress"].Value = st.priAddress;

                cmd.Parameters.Add("@detAddress", MySqlDbType.VarChar);
                cmd.Parameters["@detAddress"].Value = st.detAddress;

                cmd.Parameters.Add("@school", MySqlDbType.VarChar);
                cmd.Parameters["@school"].Value = st.School;

                cmd.Parameters.Add("@class", MySqlDbType.VarChar);
                cmd.Parameters["@class"].Value = st.Class;

                cmd.Parameters.Add("@birth", MySqlDbType.Date);
                cmd.Parameters["@birth"].Value = st.birth;

                cmd.Parameters.Add("@lessonCode", MySqlDbType.VarChar);
                cmd.Parameters["@lessonCode"].Value = st.lessonCode;

                cmd.Parameters.Add("@regDate", MySqlDbType.Date);
                cmd.Parameters["@regDate"].Value = st.regDate;

                cmd.Parameters.Add("@pPNum", MySqlDbType.VarChar);
                cmd.Parameters["@pPNum"].Value = st.ppNum;

                cmd.Parameters.Add("@nsReport", MySqlDbType.VarChar);
                cmd.Parameters["@nsReport"].Value = st.nsReport;

                cmd.Parameters.Add("@antecedent", MySqlDbType.VarChar);
                cmd.Parameters["@antecedent"].Value = st.antecedent;

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
        /// Member에 대해 Update 메서드
        /// 1. ID, 이름, 성별, 번호, 주소, 학교, 반, 생일, 수강코드, 등록일, 보호자번호, 특이사항, 선행학습정도 입력받도록
        /// 2. 단, stuId(학생 번호, Pk)가 일치하면 수행
        /// 3. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 4. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool UpdateMember(SetMemberText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"update student set stuName = @stuName, stuGender =@stuGender, 
                                 phNum = @phNum, postalCode =@postalCode, priAddress =@priAddress, 
                                 detAddress = @detAddress, school = @school, class = @class, 
                                 birth = @birth, lessonCode = @lessonCode, regDate = @regDate, 
                                 pPNum = @pPNum, nsReport = @nsReport, antecedent = @antecedent 
                                 where stuId = @stuId;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
                cmd.Parameters["@stuID"].Value = st.ID;

                cmd.Parameters.Add("@stuName", MySqlDbType.VarChar);
                cmd.Parameters["@stuName"].Value = st.Name;

                cmd.Parameters.Add("@stuGender", MySqlDbType.VarChar);
                cmd.Parameters["@stuGender"].Value = st.Gender;

                cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
                cmd.Parameters["@phNum"].Value = st.phNum;

                cmd.Parameters.Add("@postalCode", MySqlDbType.VarChar);
                cmd.Parameters["@postalCode"].Value = st.postalCode;

                cmd.Parameters.Add("@priAddress", MySqlDbType.VarChar);
                cmd.Parameters["@priAddress"].Value = st.priAddress;

                cmd.Parameters.Add("@detAddress", MySqlDbType.VarChar);
                cmd.Parameters["@detAddress"].Value = st.detAddress;

                cmd.Parameters.Add("@school", MySqlDbType.VarChar);
                cmd.Parameters["@school"].Value = st.School;

                cmd.Parameters.Add("@class", MySqlDbType.VarChar);
                cmd.Parameters["@class"].Value = st.Class;

                cmd.Parameters.Add("@birth", MySqlDbType.Date);
                cmd.Parameters["@birth"].Value = st.birth;

                cmd.Parameters.Add("@lessonCode", MySqlDbType.VarChar);
                cmd.Parameters["@lessonCode"].Value = st.lessonCode;

                cmd.Parameters.Add("@regDate", MySqlDbType.Date);
                cmd.Parameters["@regDate"].Value = st.regDate;

                cmd.Parameters.Add("@pPNum", MySqlDbType.VarChar);
                cmd.Parameters["@pPNum"].Value = st.ppNum;

                cmd.Parameters.Add("@nsReport", MySqlDbType.VarChar);
                cmd.Parameters["@nsReport"].Value = st.nsReport;

                cmd.Parameters.Add("@antecedent", MySqlDbType.VarChar);
                cmd.Parameters["@antecedent"].Value = st.antecedent;

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
        /// Member에 대해 Delete 메서드
        /// 1. stuid(학생번호, PK)가 일치하면 Data 삭제
        /// 2. ExecuteNonQuery() 수행한 행의 결과를 int rows에 담아서
        /// 3. 행의 결과가 0보다 크면 true, 아니면 false 반환
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public bool DeleteMember(SetMemberText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = $@"delete from student where stuid = @stuid;";
                cmd.Connection = conn;

                cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
                cmd.Parameters["@stuID"].Value = st.ID;

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
        /// frmMember 의 SetData()를 통해 호출되는 메서드
        /// 1. ID, 이름, 성별, 번호, 주소, 학교, 반, 생일, 수강코드, 등록일, 보호자번호, 특이사항, 삭제여부, 선행학습정도, 학생 사진의 정보를 가져온다.
        /// 2. DataTable dt 선언후 dt 반환
        /// </summary>
        /// <returns></returns>
        public DataTable LoadMemberData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, class, 
                                               birth, lessonCode, regDate, pPNum, nsReport, deleted, antecedent, stuPic from student;";
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
        /// cboText의 내용은 공통코드인 ClassType
        /// </summary>
        /// <param name="cboText"></param>
        /// <returns></returns>
        public DataTable LoadClass(string cboText)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, class,              birth, lessonCode, regDate, pPNum, nsReport, deleted, antecedent, stuPic from student where class = '{cboText}'";
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
        /// 공통코드를 가져오는 메서드
        /// </summary>
        /// <param name="categorys"></param>
        /// <returns></returns>
        public DataSet GetCommonCode(string[] categorys)
        {
            string sql = @"SELECT Code, Category, Name, PCode
                            from CommonCode where Category = @Category
                            order by Name;";

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@Category", MySqlDbType.VarChar);

            foreach (string category in categorys)
            {
                da.SelectCommand.Parameters["@Category"].Value = category;
                da.Fill(ds, category);
            }
            return ds;
        }
    }
}

