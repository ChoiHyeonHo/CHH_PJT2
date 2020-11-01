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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlessonCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAntecedent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPPNum = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.txtName.TabIndex = 1;
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
            this.txtNum.TabIndex = 3;
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
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(61, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "000-000";
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
            this.txtSchool.TabIndex = 7;
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
            this.txtGrade.TabIndex = 9;
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
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(391, 18);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(167, 21);
            this.txtBirth.TabIndex = 11;
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
            this.txtlessonCode.TabIndex = 13;
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
            this.txtAntecedent.TabIndex = 15;
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
            this.txtPPNum.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(583, 387);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10.Size = new System.Drawing.Size(235, 243);
            this.textBox10.TabIndex = 19;
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
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dtpRegDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPPNum);
            this.groupBox1.Controls.Add(this.textBox3);
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
            this.groupBox1.Controls.Add(this.txtBirth);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 260);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // textBox13
            // 
            this.textBox13.ForeColor = System.Drawing.Color.Gray;
            this.textBox13.Location = new System.Drawing.Point(61, 219);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(497, 21);
            this.textBox13.TabIndex = 30;
            this.textBox13.Text = "상세 주소";
            // 
            // textBox11
            // 
            this.textBox11.ForeColor = System.Drawing.Color.Gray;
            this.textBox11.Location = new System.Drawing.Point(61, 192);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(497, 21);
            this.textBox11.TabIndex = 29;
            this.textBox11.Text = "기본 주소";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(292, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "주소 검색";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegDate.Location = new System.Drawing.Point(391, 76);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(167, 21);
            this.dtpRegDate.TabIndex = 27;
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
            this.txtID.TabIndex = 25;
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(221, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 19);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "여";
            this.radioButton2.Text = "여";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(170, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 19);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "남";
            this.radioButton1.Text = "남";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(664, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "신규";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(583, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(200, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "새로고침";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(745, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 642);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox10);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlessonCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAntecedent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPPNum;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button5;
    }
}