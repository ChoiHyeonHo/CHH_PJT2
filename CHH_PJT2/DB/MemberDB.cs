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
        public int lessonCode { get; set; }
        public DateTime regDate { get; set; }
        public string ppNum { get; set; }
        public string nsReport { get; set; }
        public string antecedent { get; set; }
        public string combobox { get; set; }

        public SetMemberText(string ID, string Name, string Gender, string phNum, string postalCode, string priAddress, string detAddress, string School, string Class, DateTime birth, int lessonCode, DateTime regDate, string ppNum, string nsReport, string antecedent)
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

        public bool SetCombo(SetMemberText st)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, class, birth, lessonCode, regDate, pPNum, nsReport, antecedent
                                                       from student where class = @class; ";
            cmd.Connection = conn;

            cmd.Parameters.Add("@class", MySqlDbType.VarChar);
            cmd.Parameters["@class"].Value = st.combobox;
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

        public bool CreateMember(SetMemberText st)
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

            cmd.Parameters.Add("@lessonCode", MySqlDbType.Int32);
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

        public bool UpdateMember(SetMemberText st)
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

            cmd.Parameters.Add("@lessonCode", MySqlDbType.Int32);
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

        public bool DeleteMember(SetMemberText st)
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

        public DataTable LoadMemberData()
        {
            DataTable dt = new DataTable();
            string sql = @"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, class,              birth, lessonCode, regDate, pPNum, nsReport, deleted, antecedent, stuPic from student;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
        public DataTable LoadClass(string cboText)
        {
            DataTable dt = new DataTable();
            //frmMember frm = new frmMember();
            //string cla =frm.comboBox1.
            string sql = $@"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, class,              birth, lessonCode, regDate, pPNum, nsReport, deleted, antecedent, stuPic from student where class = '{cboText}'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

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

