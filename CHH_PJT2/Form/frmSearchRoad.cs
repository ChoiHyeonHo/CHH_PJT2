using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CHH_PJT2
{
    public partial class frmSearchRoad : Form
    {
        string zip, address1, address2;
        public string ZipCode
        {
            get { return zip; }
        }

        public string Address1
        {
            get { return address1; }
        }

        public string Address2
        {
            get { return address2; }
        }
        public frmSearchRoad()
        {
            InitializeComponent();
        }

        private void frmSearchRoad_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dataGridView1);

            CommonUtil.AddGridTextColumn(dataGridView1, "우편번호", "zipNo", 80);
            CommonUtil.AddGridTextColumn(dataGridView1, "주소1", "roadAddr", 200);
            CommonUtil.AddGridTextColumn(dataGridView1, "주소2", "jibunAddr", 200);
            CommonUtil.AddGridTextColumn(dataGridView1, "주소1", "roadAddrPart1", 10, false);
            CommonUtil.AddGridTextColumn(dataGridView1, "주소1", "roadAddrPart2", 10, false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("검색하실 주소를 입력하세요.");
                return;
            }
            string url = "http://www.juso.go.kr/addrlink/addrLinkApi.do";
            string apiKey = ConfigurationManager.AppSettings["RoadAPIKey"].ToString();

            string apiUrl = $"{url}?confmKey={apiKey}&currentPage=1&countPerPage=1000&keyword={txtSearch.Text.Trim()}";

            WebClient wc = new WebClient();
            XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));
            DataSet ds = new DataSet();
            ds.ReadXml(reader);

            if (ds.Tables.Count > 1)
                dataGridView1.DataSource = ds.Tables[1];
            else
                MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //btnSearch_Click(null, null);
                btnSearch.PerformClick();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoadZipcode.Text = dataGridView1["zipNo", e.RowIndex].Value.ToString();
            txtRoadAddr1.Text = dataGridView1["roadAddrPart1", e.RowIndex].Value.ToString();
            txtRoadAddr2.Text = dataGridView1["roadAddrPart2", e.RowIndex].Value.ToString();

            txtJibunZipCode.Text = dataGridView1["zipNo", e.RowIndex].Value.ToString();
            txtJibunZipCode.Text = dataGridView1["jibunAddr", e.RowIndex].Value.ToString();
            txtJibunAddr2.Text = "";
        }

        private void btnRoad_Click(object sender, EventArgs e)
        {
            if (txtRoadAddr1.Text.Length > 0)
            {
                this.zip = txtRoadZipcode.Text;
                this.address1 = txtRoadAddr1.Text;
                this.address2 = txtRoadAddr2.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("주소를 검색하여 선택해주세요.");
            }
        }
    }
}
