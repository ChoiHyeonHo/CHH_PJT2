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
    public struct SetText
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string phNum { get; set; }
        public string postalCode { get; set; }
        public string priCode { get; set; }
        public string detCode { get; set; }
        public string School { get; set; }
        public string Grade { get; set; }
        public DateTime birth { get; set; }
        public 
    }

    public class MainDB : IDisposable
    {
        MySqlConnection conn;
        public MainDB()
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
        /// 멤버폼 좌측상단 정보 출력
        /// </summary>
        /// <param name="staffID"></param>
        /// <returns></returns>
        //public Main GetID(string staffID)
        //{
        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.CommandText = "select staffID, staffName, jobClassifyID from staff;";
        //    cmd.Connection = conn;

        //    MySqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        Main main = new Main();
        //        main.staffID = reader[$"{staffID}"].ToString();
        //        //main.staffName = reader[$"{staffName}"].ToString();
        //        //main.Job = reader[$"{Job}"].ToString();

        //        return main;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public bool CreateMember(string stuID, string Name, string stuGender, string phNum, string postalCode, string priAddress, string detAddress, string school, string grade, DateTime dtpBirth, int lessonCode, DateTime dtpRegDate, string pPNum, string nsReprot, string antecedent)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $@"insert into student(stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, grade, birth, lessonCode, regDate, pPNum, nsReport, antecedent) values(stuID = {stuID}, stuName = {Name}, stuGender = {stuGender}, phNum = {phNum}, postalCode = {postalCode}, priAddress = {priAddress}, detAddress = {detAddress}, school = {school}, grade = {grade}, birth = {dtpBirth}, lessonCode = {lessonCode}, regDate = {dtpRegDate}, pPNum = {pPNum}, nsReport = {nsReprot}, antecedent = {antecedent}); ";
            cmd.Connection = conn;

            cmd.Parameters.Add($"{stuID}", MySqlDbType.VarChar);
            cmd.Parameters[$"{stuID}"].Value = stuID;

            cmd.Parameters.Add($"{Name}", MySqlDbType.VarChar);
            cmd.Parameters[$"{Name}"].Value = Name;

            cmd.Parameters.Add($"{stuGender}", MySqlDbType.VarChar);
            cmd.Parameters[$"{stuGender}"].Value = stuGender;

            cmd.Parameters.Add($"{phNum}", MySqlDbType.VarChar);
            cmd.Parameters[$"{phNum}"].Value = phNum;

            cmd.Parameters.Add($"{postalCode}", MySqlDbType.VarChar);
            cmd.Parameters[$"{postalCode}"].Value = postalCode;

            cmd.Parameters.Add($"{priAddress}", MySqlDbType.VarChar);
            cmd.Parameters[$"{priAddress}"].Value = priAddress;

            cmd.Parameters.Add($"{detAddress}", MySqlDbType.VarChar);
            cmd.Parameters[$"{detAddress}"].Value = detAddress;

            cmd.Parameters.Add($"{school}", MySqlDbType.VarChar);
            cmd.Parameters[$"{school}"].Value = school;

            cmd.Parameters.Add($"{grade}", MySqlDbType.VarChar);
            cmd.Parameters[$"{grade}"].Value = grade;

            cmd.Parameters.Add($"{dtpBirth}", MySqlDbType.Date);
            cmd.Parameters[$"{dtpBirth}"].Value = dtpBirth;

            cmd.Parameters.Add($"{lessonCode}", MySqlDbType.Int32);
            cmd.Parameters[$"{lessonCode}"].Value = lessonCode;

            cmd.Parameters.Add($"{dtpRegDate}", MySqlDbType.Date);
            cmd.Parameters[$"{dtpRegDate}"].Value = dtpRegDate;

            cmd.Parameters.Add($"{pPNum}", MySqlDbType.VarChar);
            cmd.Parameters[$"{pPNum}"].Value = pPNum;

            cmd.Parameters.Add($"{nsReprot}", MySqlDbType.VarChar);
            cmd.Parameters[$"{nsReprot}"].Value = nsReprot;

            cmd.Parameters.Add($"{antecedent}", MySqlDbType.VarChar);
            cmd.Parameters[$"{antecedent}"].Value = antecedent;

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

        public bool UpdateMember(string Name, string phNum, string school, string grade, DateTime dtpBirth, int ressonCode, DateTime dtpLegDate, string antecedent, string ppNum, string stuID)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"update student set stuName = @stuName, phNum = @phNum, school = @school,
	                                               grade = @grade, birth = @birth, lessonCode = @lessonCode,
	                                               regDate = @regDate, antecedent = @antecedent, pPNum = @pPNum
                                where stuID = @stuID;";
            cmd.Connection = conn;

            cmd.Parameters.Add("@stuName", MySqlDbType.VarChar);
            cmd.Parameters["@stuName"].Value = Name;

            cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
            cmd.Parameters["@phNum"].Value = phNum;

            cmd.Parameters.Add("@school", MySqlDbType.VarChar);
            cmd.Parameters["@school"].Value = school;

            cmd.Parameters.Add("@grade", MySqlDbType.VarChar);
            cmd.Parameters["@grade"].Value = grade;

            cmd.Parameters.Add("@birth", MySqlDbType.Date);
            cmd.Parameters["@birth"].Value = dtpBirth;

            cmd.Parameters.Add("@lessonCode", MySqlDbType.Int32);
            cmd.Parameters["@lessonCode"].Value = ressonCode;

            cmd.Parameters.Add("@regDate", MySqlDbType.Date);
            cmd.Parameters["@regDate"].Value = dtpLegDate;

            cmd.Parameters.Add("@antecedent", MySqlDbType.VarChar);
            cmd.Parameters["@antecedent"].Value = antecedent;

            cmd.Parameters.Add("@pPNum", MySqlDbType.VarChar);
            cmd.Parameters["@pPNum"].Value = ppNum;

            cmd.Parameters.Add("@stuID", MySqlDbType.VarChar);
            cmd.Parameters["@stuID"].Value = stuID;

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

        /// <summary>
        /// DataGridView 정보 출력
        /// </summary>
        /// <returns></returns>
        public DataTable LoadMemberData()
        {
            DataTable dt = new DataTable();
            string sql = @"select stuID, stuName, stuGender, phNum, postalCode, priAddress, detAddress, school, grade,              birth, lessonCode, regDate, pPNum, nsReport, deleted, antecedent, stuPic from student;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
    }

}
