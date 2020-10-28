﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using CHH_PJT2.DB;

namespace CHH_PJT2
{
    public partial class frmLogIn : MetroForm
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInDB.StaffInfo info = new LogInDB.StaffInfo();
            LogInDB db = new LogInDB();

            bool result = db.LogInCheck(staffInfo);
            db.Dispose();

            if (result)
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                MessageBox.Show("이거 아닌데");
            }
        }
    }
}