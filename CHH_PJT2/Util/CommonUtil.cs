using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CHH_PJT2
{
    class CommonUtil
    {
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        public static void AddGridTextColumn( 
                           DataGridView dgv, 
                           string headertext,
                           string dataPropertyName,
                           int colWidth = 100,
                           bool visibility = true,
                           DataGridViewContentAlignment textalien = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headertext;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textalien;
            col.Visible = visibility;
            col.ReadOnly = true;
            dgv.Columns.Add(col);
        }

        public static void BindingComboBox(ComboBox cbo, System.Data.DataTable dt, string valueMember, string displayMember, bool blankItemAdd = true)
        {
            if (blankItemAdd)
            {
                DataRow dr = dt.NewRow();
                dr[displayMember] = "";
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.DataSource = dt;
        }
    }
}
