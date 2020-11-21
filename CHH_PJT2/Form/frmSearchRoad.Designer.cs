namespace CHH_PJT2
{
    partial class frmSearchRoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRoad = new System.Windows.Forms.Button();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.txtRoadZipcode = new System.Windows.Forms.TextBox();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunZipCode = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "도로명 주소 검색";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearch.Location = new System.Drawing.Point(127, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(339, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(674, 252);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnRoad
            // 
            this.btnRoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoad.Location = new System.Drawing.Point(19, 303);
            this.btnRoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(86, 55);
            this.btnRoad.TabIndex = 4;
            this.btnRoad.Text = "주소 확인";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.btnRoad_Click);
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr1.Location = new System.Drawing.Point(111, 303);
            this.txtRoadAddr1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.ReadOnly = true;
            this.txtRoadAddr1.Size = new System.Drawing.Size(582, 25);
            this.txtRoadAddr1.TabIndex = 5;
            // 
            // txtRoadZipcode
            // 
            this.txtRoadZipcode.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadZipcode.Location = new System.Drawing.Point(111, 333);
            this.txtRoadZipcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoadZipcode.Name = "txtRoadZipcode";
            this.txtRoadZipcode.ReadOnly = true;
            this.txtRoadZipcode.Size = new System.Drawing.Size(164, 25);
            this.txtRoadZipcode.TabIndex = 6;
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr2.Location = new System.Drawing.Point(281, 333);
            this.txtRoadAddr2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.ReadOnly = true;
            this.txtRoadAddr2.Size = new System.Drawing.Size(412, 25);
            this.txtRoadAddr2.TabIndex = 7;
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr2.Location = new System.Drawing.Point(281, 396);
            this.txtJibunAddr2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.ReadOnly = true;
            this.txtJibunAddr2.Size = new System.Drawing.Size(412, 25);
            this.txtJibunAddr2.TabIndex = 11;
            // 
            // txtJibunZipCode
            // 
            this.txtJibunZipCode.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunZipCode.Location = new System.Drawing.Point(111, 396);
            this.txtJibunZipCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJibunZipCode.Name = "txtJibunZipCode";
            this.txtJibunZipCode.ReadOnly = true;
            this.txtJibunZipCode.Size = new System.Drawing.Size(164, 25);
            this.txtJibunZipCode.TabIndex = 10;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr1.Location = new System.Drawing.Point(111, 366);
            this.txtJibunAddr1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.ReadOnly = true;
            this.txtJibunAddr1.Size = new System.Drawing.Size(582, 25);
            this.txtJibunAddr1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "주소 확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSearchRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 431);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunZipCode);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRoadAddr2);
            this.Controls.Add(this.txtRoadZipcode);
            this.Controls.Add(this.txtRoadAddr1);
            this.Controls.Add(this.btnRoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSearchRoad";
            this.Text = "frmSearchRoad";
            this.Load += new System.EventHandler(this.frmSearchRoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.TextBox txtRoadZipcode;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunZipCode;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.Button button1;
    }
}