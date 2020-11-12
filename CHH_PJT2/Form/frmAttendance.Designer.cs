namespace CHH_PJT2
{
    partial class frmAttendance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEnteringTime = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEntranceTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLessonCode = new System.Windows.Forms.TextBox();
            this.AttDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.출결변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결석변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타사항ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRenew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(700, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 99);
            this.button3.TabIndex = 60;
            this.button3.Text = "퇴실";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Enabled = false;
            this.dtpAttendanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(58, 85);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(182, 21);
            this.dtpAttendanceDate.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID: ";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(58, 21);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(182, 21);
            this.txtID.TabIndex = 56;
            // 
            // txtEnteringTime
            // 
            this.txtEnteringTime.BackColor = System.Drawing.Color.White;
            this.txtEnteringTime.Enabled = false;
            this.txtEnteringTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEnteringTime.Location = new System.Drawing.Point(334, 54);
            this.txtEnteringTime.Name = "txtEnteringTime";
            this.txtEnteringTime.ReadOnly = true;
            this.txtEnteringTime.Size = new System.Drawing.Size(182, 21);
            this.txtEnteringTime.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(58, 53);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(182, 21);
            this.txtName.TabIndex = 47;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(18, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "날짜: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(268, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "입실 시간: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "이름: ";
            // 
            // txtEntranceTime
            // 
            this.txtEntranceTime.BackColor = System.Drawing.Color.White;
            this.txtEntranceTime.Enabled = false;
            this.txtEntranceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEntranceTime.Location = new System.Drawing.Point(334, 86);
            this.txtEntranceTime.Name = "txtEntranceTime";
            this.txtEntranceTime.ReadOnly = true;
            this.txtEntranceTime.Size = new System.Drawing.Size(182, 21);
            this.txtEntranceTime.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(268, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "퇴실 시간: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLessonCode);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtEntranceTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpAttendanceDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtEnteringTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(18, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 119);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(580, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 99);
            this.button1.TabIndex = 65;
            this.button1.Text = "출석";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(268, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "수강코드:";
            // 
            // txtLessonCode
            // 
            this.txtLessonCode.BackColor = System.Drawing.Color.White;
            this.txtLessonCode.Enabled = false;
            this.txtLessonCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLessonCode.Location = new System.Drawing.Point(334, 22);
            this.txtLessonCode.Name = "txtLessonCode";
            this.txtLessonCode.ReadOnly = true;
            this.txtLessonCode.Size = new System.Drawing.Size(182, 21);
            this.txtLessonCode.TabIndex = 63;
            // 
            // AttDataGridView
            // 
            this.AttDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AttDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttDataGridView.ColumnHeadersHeight = 25;
            this.AttDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.AttDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.AttDataGridView.Location = new System.Drawing.Point(18, 49);
            this.AttDataGridView.Name = "AttDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AttDataGridView.RowTemplate.Height = 23;
            this.AttDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AttDataGridView.Size = new System.Drawing.Size(806, 448);
            this.AttDataGridView.TabIndex = 66;
            this.AttDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttDataGridView_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출결변경ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // 출결변경ToolStripMenuItem
            // 
            this.출결변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출석변경ToolStripMenuItem,
            this.결석변경ToolStripMenuItem,
            this.기타사항ToolStripMenuItem});
            this.출결변경ToolStripMenuItem.Name = "출결변경ToolStripMenuItem";
            this.출결변경ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.출결변경ToolStripMenuItem.Text = "출석 설정";
            // 
            // 출석변경ToolStripMenuItem
            // 
            this.출석변경ToolStripMenuItem.Name = "출석변경ToolStripMenuItem";
            this.출석변경ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.출석변경ToolStripMenuItem.Text = "출석변경";
            this.출석변경ToolStripMenuItem.Click += new System.EventHandler(this.출결변경ToolStripMenuItem_Click_1);
            // 
            // 결석변경ToolStripMenuItem
            // 
            this.결석변경ToolStripMenuItem.Name = "결석변경ToolStripMenuItem";
            this.결석변경ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.결석변경ToolStripMenuItem.Text = "결석변경";
            this.결석변경ToolStripMenuItem.Click += new System.EventHandler(this.결석변경ToolStripMenuItem_Click);
            // 
            // 기타사항ToolStripMenuItem
            // 
            this.기타사항ToolStripMenuItem.Name = "기타사항ToolStripMenuItem";
            this.기타사항ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.기타사항ToolStripMenuItem.Text = "기타사항";
            this.기타사항ToolStripMenuItem.Click += new System.EventHandler(this.기타사항ToolStripMenuItem_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRenew.Location = new System.Drawing.Point(183, 12);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(86, 23);
            this.btnRenew.TabIndex = 67;
            this.btnRenew.Text = "새로고침";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 642);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.AttDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendance";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.frnAttendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEnteringTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEntranceTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLessonCode;
        private System.Windows.Forms.DataGridView AttDataGridView;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 출결변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출석변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결석변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타사항ToolStripMenuItem;
    }
}