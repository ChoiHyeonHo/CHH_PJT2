using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CHH_PJT2
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HomeFrom HF = new HomeFrom();
            HF.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(HF);
            HF.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            HomeFrom HF = new HomeFrom();
            HF.TopLevel = false;
            HF.Show();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(HF);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MemberFrom MF = new MemberFrom();
            MF.TopLevel = false;
            MF.Show();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(MF);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ClassForm CF = new ClassForm();
            CF.TopLevel = false;
            CF.Show();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(CF);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            AttendanceForm AF = new AttendanceForm();
            AF.TopLevel = false;
            AF.Show();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(AF);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            CounselingForm COF = new CounselingForm();
            COF.TopLevel = false;
            COF.Show();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(COF);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            BoardFrom BF = new BoardFrom();
            BF.TopLevel = false;
            BF.Show();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(BF);
        }
    }
}
