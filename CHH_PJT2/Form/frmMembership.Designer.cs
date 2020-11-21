namespace CHH_PJT2
{
    partial class frmMembership
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetAddr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPriAddr = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "번호: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "생년월일: ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "업무구분:";
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPwd.Location = new System.Drawing.Point(121, 52);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(156, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNum.Location = new System.Drawing.Point(121, 118);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(156, 21);
            this.txtNum.TabIndex = 6;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPostalCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode.Location = new System.Drawing.Point(121, 206);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(156, 21);
            this.txtPostalCode.TabIndex = 7;
            this.txtPostalCode.Text = "000-000";
            // 
            // cboJob
            // 
            this.cboJob.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboJob.FormattingEnabled = true;
            this.cboJob.Location = new System.Drawing.Point(121, 178);
            this.cboJob.Name = "cboJob";
            this.cboJob.Size = new System.Drawing.Size(156, 22);
            this.cboJob.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(15, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDetAddr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cboJob);
            this.groupBox1.Controls.Add(this.txtPriAddr);
            this.groupBox1.Controls.Add(this.dtpBirth);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 343);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직원등록";
            // 
            // txtDetAddr
            // 
            this.txtDetAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetAddr.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDetAddr.ForeColor = System.Drawing.Color.Gray;
            this.txtDetAddr.Location = new System.Drawing.Point(15, 266);
            this.txtDetAddr.Name = "txtDetAddr";
            this.txtDetAddr.Size = new System.Drawing.Size(262, 21);
            this.txtDetAddr.TabIndex = 14;
            this.txtDetAddr.Text = "상세 주소";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(16, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "우편번호 찾기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPriAddr
            // 
            this.txtPriAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriAddr.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPriAddr.ForeColor = System.Drawing.Color.Gray;
            this.txtPriAddr.Location = new System.Drawing.Point(15, 236);
            this.txtPriAddr.Name = "txtPriAddr";
            this.txtPriAddr.Size = new System.Drawing.Size(262, 21);
            this.txtPriAddr.TabIndex = 13;
            this.txtPriAddr.Text = "기본 주소";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(121, 148);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(156, 21);
            this.dtpBirth.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(121, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 21);
            this.txtID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID: ";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(121, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 21);
            this.txtName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "이름: ";
            // 
            // frmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 369);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMembership";
            this.Text = "MembershipFrom";
            this.Load += new System.EventHandler(this.frmMembership_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetAddr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPriAddr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
    }
}