﻿namespace CHH_PJT2
{
    partial class frmDetAttendance
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEnteringTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEntranceTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecordContent = new System.Windows.Forms.TextBox();
            this.lblLate = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.rbtnLatenessY = new System.Windows.Forms.RadioButton();
            this.rbtnLatenessN = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnLeaveY = new System.Windows.Forms.RadioButton();
            this.rbtnLeaveN = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.Location = new System.Drawing.Point(243, 47);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(144, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "수강코드";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCode.Location = new System.Drawing.Point(243, 96);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(144, 22);
            this.txtCode.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출결";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "기타";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "결석";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CHH_PJT2.Properties.Resources.icons8_warning_triangle_64;
            this.pictureBox4.Location = new System.Drawing.Point(260, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "출석";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CHH_PJT2.Properties.Resources.icons8_delete_128;
            this.pictureBox3.Location = new System.Drawing.Point(151, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CHH_PJT2.Properties.Resources.icons8_checkmark_144;
            this.pictureBox2.Location = new System.Drawing.Point(46, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "입실 시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "퇴실 시간";
            // 
            // dtpEnteringTime
            // 
            this.dtpEnteringTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnteringTime.Location = new System.Drawing.Point(243, 150);
            this.dtpEnteringTime.Name = "dtpEnteringTime";
            this.dtpEnteringTime.Size = new System.Drawing.Size(147, 22);
            this.dtpEnteringTime.TabIndex = 10;
            // 
            // dtpEntranceTime
            // 
            this.dtpEntranceTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntranceTime.Location = new System.Drawing.Point(243, 203);
            this.dtpEntranceTime.Name = "dtpEntranceTime";
            this.dtpEntranceTime.Size = new System.Drawing.Size(147, 22);
            this.dtpEntranceTime.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔바른고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(709, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecordContent);
            this.groupBox2.Location = new System.Drawing.Point(409, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 240);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사유";
            // 
            // txtRecordContent
            // 
            this.txtRecordContent.Location = new System.Drawing.Point(7, 21);
            this.txtRecordContent.Multiline = true;
            this.txtRecordContent.Name = "txtRecordContent";
            this.txtRecordContent.Size = new System.Drawing.Size(307, 216);
            this.txtRecordContent.TabIndex = 0;
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(472, 53);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(55, 16);
            this.lblLate.TabIndex = 14;
            this.lblLate.Text = "지각 여부";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Location = new System.Drawing.Point(472, 99);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(55, 16);
            this.lblLeave.TabIndex = 15;
            this.lblLeave.Text = "조퇴 여부";
            // 
            // rbtnLatenessY
            // 
            this.rbtnLatenessY.AutoSize = true;
            this.rbtnLatenessY.Location = new System.Drawing.Point(3, 3);
            this.rbtnLatenessY.Name = "rbtnLatenessY";
            this.rbtnLatenessY.Size = new System.Drawing.Size(32, 18);
            this.rbtnLatenessY.TabIndex = 16;
            this.rbtnLatenessY.TabStop = true;
            this.rbtnLatenessY.Text = "Y";
            this.rbtnLatenessY.UseVisualStyleBackColor = true;
            // 
            // rbtnLatenessN
            // 
            this.rbtnLatenessN.AutoSize = true;
            this.rbtnLatenessN.Location = new System.Drawing.Point(56, 3);
            this.rbtnLatenessN.Name = "rbtnLatenessN";
            this.rbtnLatenessN.Size = new System.Drawing.Size(34, 18);
            this.rbtnLatenessN.TabIndex = 17;
            this.rbtnLatenessN.TabStop = true;
            this.rbtnLatenessN.Text = "N";
            this.rbtnLatenessN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnLatenessY);
            this.panel1.Controls.Add(this.rbtnLatenessN);
            this.panel1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(550, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 27);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnLeaveY);
            this.panel2.Controls.Add(this.rbtnLeaveN);
            this.panel2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(550, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 27);
            this.panel2.TabIndex = 19;
            // 
            // rbtnLeaveY
            // 
            this.rbtnLeaveY.AutoSize = true;
            this.rbtnLeaveY.Location = new System.Drawing.Point(3, 3);
            this.rbtnLeaveY.Name = "rbtnLeaveY";
            this.rbtnLeaveY.Size = new System.Drawing.Size(32, 18);
            this.rbtnLeaveY.TabIndex = 16;
            this.rbtnLeaveY.TabStop = true;
            this.rbtnLeaveY.Text = "Y";
            this.rbtnLeaveY.UseVisualStyleBackColor = true;
            // 
            // rbtnLeaveN
            // 
            this.rbtnLeaveN.AutoSize = true;
            this.rbtnLeaveN.Location = new System.Drawing.Point(56, 3);
            this.rbtnLeaveN.Name = "rbtnLeaveN";
            this.rbtnLeaveN.Size = new System.Drawing.Size(34, 18);
            this.rbtnLeaveN.TabIndex = 17;
            this.rbtnLeaveN.TabStop = true;
            this.rbtnLeaveN.Text = "N";
            this.rbtnLeaveN.UseVisualStyleBackColor = true;
            // 
            // frmDetAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.lblLate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEntranceTime);
            this.Controls.Add(this.dtpEnteringTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDetAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDetAttendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEnteringTime;
        private System.Windows.Forms.DateTimePicker dtpEntranceTime;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnLatenessY;
        private System.Windows.Forms.RadioButton rbtnLatenessN;
        private System.Windows.Forms.RadioButton rbtnLeaveY;
        private System.Windows.Forms.RadioButton rbtnLeaveN;
        public System.Windows.Forms.Label lblLate;
        public System.Windows.Forms.Label lblLeave;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtRecordContent;
    }
}