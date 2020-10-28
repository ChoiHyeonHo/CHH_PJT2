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
    public partial class frmMain : MetroForm
    {
        public static frmMain frm;
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmMain CreateMainForm()
        {
            if (frm == null)
            {
                frm = new frmMain();
            }
            return frm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
