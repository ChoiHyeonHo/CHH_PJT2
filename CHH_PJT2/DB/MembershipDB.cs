using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CHH_PJT2
{
    public class SetMembershipText
    {
        public string staffID { get; set; }
        public string staffName { get; set; }
        public string staffNum { get; set; }
        public string staffPwd { get; set; }
        public DateTime staffBirth { get; set; }
        public string jobClassify { get; set; }
        public string addrCode { get; set; }
        public string priAddr { get; set; }
        public string detAddr { get; set; }

        public SetMembershipText(string staffID, string staffName, string staffNum, string staffPwd, DateTime staffBirth, string jobClassify, string addrCode, string priAddr, string detAddr)
        {
            this.staffID = staffID;
            this.staffName = staffName;
            this.staffNum = staffNum;
            this.staffPwd = staffPwd;
            this.staffBirth = staffBirth;
            this.jobClassify = jobClassify;
            this.addrCode = addrCode;
            this.priAddr = priAddr;
            this.detAddr = detAddr;
        }
    }
    class MembershipDB
    {
        MySqlConnection conn;

        public MembershipDB()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            conn.Open();
        }

        public bool CreateMembership(SetMembershipText st)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = @"insert into staff(staffID, staffName, phNum, postalCode, birth, jobClassifyID, staffPwd, priAddress, detAddress)
                                                                values (@staffID, @staffName, @phNum, @postalCode, @birth, @jobClassifyID, @staffPwd, @priAddress, @detAddress);";
                cmd.Connection = conn;

                cmd.Parameters.Add("@staffID", MySqlDbType.VarChar);
                cmd.Parameters["@staffID"].Value = st.staffID;

                cmd.Parameters.Add("@staffName", MySqlDbType.VarChar);
                cmd.Parameters["@staffName"].Value = st.staffName;

                cmd.Parameters.Add("@phNum", MySqlDbType.VarChar);
                cmd.Parameters["@phNum"].Value = st.staffNum;

                cmd.Parameters.Add("@postalCode", MySqlDbType.VarChar);
                cmd.Parameters["@postalCode"].Value = st.addrCode;

                cmd.Parameters.Add("@birth", MySqlDbType.Date);
                cmd.Parameters["@birth"].Value = st.staffBirth;

                cmd.Parameters.Add("@jobClassifyID", MySqlDbType.VarChar);
                cmd.Parameters["@jobClassifyID"].Value = st.jobClassify;

                cmd.Parameters.Add("@staffPwd", MySqlDbType.VarChar);
                cmd.Parameters["@staffPwd"].Value = st.staffPwd;

                cmd.Parameters.Add("@priAddress", MySqlDbType.VarChar);
                cmd.Parameters["@priAddress"].Value = st.priAddr;

                cmd.Parameters.Add("@detAddress", MySqlDbType.VarChar);
                cmd.Parameters["@detAddress"].Value = st.detAddr;

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
    }
}
