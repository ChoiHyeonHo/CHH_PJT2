﻿namespace CHH_PJT2
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBoard = new MetroFramework.Controls.MetroButton();
            this.btnCounseling = new MetroFramework.Controls.MetroButton();
            this.btnAttendance = new MetroFramework.Controls.MetroButton();
            this.btnClass = new MetroFramework.Controls.MetroButton();
            this.btnMember = new MetroFramework.Controls.MetroButton();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBoard);
            this.splitContainer1.Panel1.Controls.Add(this.btnCounseling);
            this.splitContainer1.Panel1.Controls.Add(this.btnAttendance);
            this.splitContainer1.Panel1.Controls.Add(this.btnClass);
            this.splitContainer1.Panel1.Controls.Add(this.btnMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 640);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnBoard
            // 
            this.btnBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoard.Location = new System.Drawing.Point(0, 530);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(139, 106);
            this.btnBoard.TabIndex = 5;
            this.btnBoard.Text = "게시판";
            this.btnBoard.UseSelectable = true;
            this.btnBoard.Click += new System.EventHandler(this.btnBoard_Click);
            // 
            // btnCounseling
            // 
            this.btnCounseling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCounseling.Location = new System.Drawing.Point(0, 424);
            this.btnCounseling.Name = "btnCounseling";
            this.btnCounseling.Size = new System.Drawing.Size(139, 106);
            this.btnCounseling.TabIndex = 4;
            this.btnCounseling.Text = "상담관리";
            this.btnCounseling.UseSelectable = true;
            this.btnCounseling.Click += new System.EventHandler(this.btnCounseling_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.Location = new System.Drawing.Point(0, 318);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(139, 106);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "출결관리";
            this.btnAttendance.UseSelectable = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.Location = new System.Drawing.Point(0, 212);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(139, 106);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "수업관리";
            this.btnClass.UseSelectable = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.Location = new System.Drawing.Point(0, 106);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(139, 106);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "학생관리";
            this.btnMember.UseSelectable = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 106);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "홈";
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 사용자: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(109, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "staffName";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblId.Location = new System.Drawing.Point(290, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "staffID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(227, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "사용 ID: ";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblJob.Location = new System.Drawing.Point(459, 33);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(99, 19);
            this.lblJob.TabIndex = 6;
            this.lblJob.Text = "jobClassfyID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(376, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "업무 형태: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton btnBoard;
        private MetroFramework.Controls.MetroButton btnCounseling;
        private MetroFramework.Controls.MetroButton btnAttendance;
        private MetroFramework.Controls.MetroButton btnClass;
        private MetroFramework.Controls.MetroButton btnMember;
        private MetroFramework.Controls.MetroButton btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label label6;
    }
}