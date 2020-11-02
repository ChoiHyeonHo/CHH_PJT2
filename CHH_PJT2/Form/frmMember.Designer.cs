namespace CHH_PJT2
{
    partial class frmMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlessonCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAntecedent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPPNum = new System.Windows.Forms.TextBox();
            this.txtNs = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtDetAddress = new System.Windows.Forms.TextBox();
            this.txtPriAddress = new System.Windows.Forms.TextBox();
            this.btnSearchAddress = new System.Windows.Forms.Button();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtnGenderW = new System.Windows.Forms.RadioButton();
            this.rbtnGenderM = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.memberDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memberDataGridView.ColumnHeadersHeight = 25;
            this.memberDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.memberDataGridView.Location = new System.Drawing.Point(12, 46);
            this.memberDataGridView.Name = "memberDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.memberDataGridView.RowTemplate.Height = 23;
            this.memberDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memberDataGridView.Size = new System.Drawing.Size(806, 318);
            this.memberDataGridView.TabIndex = 0;
            this.memberDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataGridView_CellDoubleClick);
            this.memberDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.memberDataGridView_DataBindingComplete);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "번호: ";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(61, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(211, 21);
            this.txtNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "주소: ";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode.Location = new System.Drawing.Point(61, 163);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(213, 21);
            this.txtPostalCode.TabIndex = 7;
            this.txtPostalCode.Text = "000-000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "학교: ";
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(61, 90);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(212, 21);
            this.txtSchool.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "학년: ";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(61, 127);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(89, 21);
            this.txtGrade.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "생년월일:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "수강과정: ";
            // 
            // txtlessonCode
            // 
            this.txtlessonCode.Location = new System.Drawing.Point(391, 45);
            this.txtlessonCode.Name = "txtlessonCode";
            this.txtlessonCode.Size = new System.Drawing.Size(167, 21);
            this.txtlessonCode.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "선행여부:";
            // 
            // txtAntecedent
            // 
            this.txtAntecedent.Location = new System.Drawing.Point(391, 103);
            this.txtAntecedent.Name = "txtAntecedent";
            this.txtAntecedent.Size = new System.Drawing.Size(167, 21);
            this.txtAntecedent.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "보호자 번호:";
            // 
            // txtPPNum
            // 
            this.txtPPNum.Location = new System.Drawing.Point(391, 130);
            this.txtPPNum.Name = "txtPPNum";
            this.txtPPNum.Size = new System.Drawing.Size(167, 21);
            this.txtPPNum.TabIndex = 14;
            // 
            // txtNs
            // 
            this.txtNs.Location = new System.Drawing.Point(583, 414);
            this.txtNs.Multiline = true;
            this.txtNs.Name = "txtNs";
            this.txtNs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNs.Size = new System.Drawing.Size(235, 216);
            this.txtNs.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBirth);
            this.groupBox1.Controls.Add(this.txtDetAddress);
            this.groupBox1.Controls.Add(this.txtPriAddress);
            this.groupBox1.Controls.Add(this.btnSearchAddress);
            this.groupBox1.Controls.Add(this.dtpRegDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbtnGenderW);
            this.groupBox1.Controls.Add(this.rbtnGenderM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPPNum);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAntecedent);
            this.groupBox1.Controls.Add(this.txtSchool);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlessonCode);
            this.groupBox1.Controls.Add(this.txtGrade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 260);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(391, 18);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(167, 21);
            this.dtpBirth.TabIndex = 10;
            // 
            // txtDetAddress
            // 
            this.txtDetAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtDetAddress.Location = new System.Drawing.Point(61, 219);
            this.txtDetAddress.Name = "txtDetAddress";
            this.txtDetAddress.Size = new System.Drawing.Size(497, 21);
            this.txtDetAddress.TabIndex = 9;
            this.txtDetAddress.Text = "상세 주소";
            // 
            // txtPriAddress
            // 
            this.txtPriAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtPriAddress.Location = new System.Drawing.Point(61, 192);
            this.txtPriAddress.Name = "txtPriAddress";
            this.txtPriAddress.Size = new System.Drawing.Size(497, 21);
            this.txtPriAddress.TabIndex = 8;
            this.txtPriAddress.Text = "기본 주소";
            // 
            // btnSearchAddress
            // 
            this.btnSearchAddress.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchAddress.Location = new System.Drawing.Point(292, 163);
            this.btnSearchAddress.Name = "btnSearchAddress";
            this.btnSearchAddress.Size = new System.Drawing.Size(267, 23);
            this.btnSearchAddress.TabIndex = 28;
            this.btnSearchAddress.Text = "주소 검색";
            this.btnSearchAddress.UseVisualStyleBackColor = true;
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegDate.Location = new System.Drawing.Point(391, 76);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(167, 21);
            this.dtpRegDate.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(155, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 21);
            this.txtID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "등록일: ";
            // 
            // rbtnGenderW
            // 
            this.rbtnGenderW.AutoSize = true;
            this.rbtnGenderW.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnGenderW.Location = new System.Drawing.Point(221, 128);
            this.rbtnGenderW.Name = "rbtnGenderW";
            this.rbtnGenderW.Size = new System.Drawing.Size(40, 19);
            this.rbtnGenderW.TabIndex = 6;
            this.rbtnGenderW.TabStop = true;
            this.rbtnGenderW.Tag = "여";
            this.rbtnGenderW.Text = "여";
            this.rbtnGenderW.UseVisualStyleBackColor = true;
            // 
            // rbtnGenderM
            // 
            this.rbtnGenderM.AutoSize = true;
            this.rbtnGenderM.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnGenderM.Location = new System.Drawing.Point(170, 128);
            this.rbtnGenderM.Name = "rbtnGenderM";
            this.rbtnGenderM.Size = new System.Drawing.Size(40, 19);
            this.rbtnGenderM.TabIndex = 5;
            this.rbtnGenderM.TabStop = true;
            this.rbtnGenderM.Tag = "남";
            this.rbtnGenderM.Text = "남";
            this.rbtnGenderM.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.Location = new System.Drawing.Point(664, 17);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "신규";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(583, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenew.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRenew.Location = new System.Drawing.Point(200, 15);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(86, 23);
            this.btnRenew.TabIndex = 25;
            this.btnRenew.Text = "새로고침";
            this.btnRenew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(745, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(584, 370);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(234, 40);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "항목 초기화";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 642);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNs);
            this.Controls.Add(this.memberDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMember";
            this.Text = "MemberFrom";
            this.Activated += new System.EventHandler(this.frmMember_Activated);
            this.Load += new System.EventHandler(this.frmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlessonCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAntecedent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPPNum;
        private System.Windows.Forms.TextBox txtNs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtnGenderW;
        private System.Windows.Forms.RadioButton rbtnGenderM;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.TextBox txtDetAddress;
        private System.Windows.Forms.TextBox txtPriAddress;
        private System.Windows.Forms.Button btnSearchAddress;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnRemove;
    }
}