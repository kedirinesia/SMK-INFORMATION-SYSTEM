namespace SMK_INFORMATION_SYSTEM
{
    partial class TeachingScheduleForm
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
            this.lblTeachingSchedule = new System.Windows.Forms.Label();
            this.DGTeachingSchedule = new System.Windows.Forms.DataGridView();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.DGStudentList = new System.Windows.Forms.DataGridView();
            this.buttonSubjectInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTeachingSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeachingSchedule
            // 
            this.lblTeachingSchedule.AutoSize = true;
            this.lblTeachingSchedule.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachingSchedule.Location = new System.Drawing.Point(283, 29);
            this.lblTeachingSchedule.Name = "lblTeachingSchedule";
            this.lblTeachingSchedule.Size = new System.Drawing.Size(233, 31);
            this.lblTeachingSchedule.TabIndex = 0;
            this.lblTeachingSchedule.Text = " Teaching Schedule";
            // 
            // DGTeachingSchedule
            // 
            this.DGTeachingSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTeachingSchedule.Location = new System.Drawing.Point(61, 63);
            this.DGTeachingSchedule.Name = "DGTeachingSchedule";
            this.DGTeachingSchedule.Size = new System.Drawing.Size(708, 171);
            this.DGTeachingSchedule.TabIndex = 1;
            this.DGTeachingSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTeachingSchedule_CellContentClick);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentList.Location = new System.Drawing.Point(351, 250);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(149, 31);
            this.lblStudentList.TabIndex = 2;
            this.lblStudentList.Text = "Student List";
            // 
            // DGStudentList
            // 
            this.DGStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGStudentList.Location = new System.Drawing.Point(254, 284);
            this.DGStudentList.Name = "DGStudentList";
            this.DGStudentList.Size = new System.Drawing.Size(339, 193);
            this.DGStudentList.TabIndex = 3;
            this.DGStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGStudentList_CellContentClick);
            // 
            // buttonSubjectInfo
            // 
            this.buttonSubjectInfo.Location = new System.Drawing.Point(357, 495);
            this.buttonSubjectInfo.Name = "buttonSubjectInfo";
            this.buttonSubjectInfo.Size = new System.Drawing.Size(130, 23);
            this.buttonSubjectInfo.TabIndex = 4;
            this.buttonSubjectInfo.Text = "View Subject Info";
            this.buttonSubjectInfo.UseVisualStyleBackColor = true;
            this.buttonSubjectInfo.Click += new System.EventHandler(this.buttonSubjectInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(55, -2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 42);
            this.button6.TabIndex = 22;
            this.button6.Text = "🔄";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TeachingScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSubjectInfo);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.DGTeachingSchedule);
            this.Controls.Add(this.lblTeachingSchedule);
            this.Controls.Add(this.DGStudentList);
            this.Name = "TeachingScheduleForm";
            this.Text = "TeachingScheduleForm";
            this.Load += new System.EventHandler(this.TeachingScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTeachingSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeachingSchedule;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Button buttonSubjectInfo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView DGTeachingSchedule;
        public System.Windows.Forms.DataGridView DGStudentList;
        private System.Windows.Forms.Button button6;
    }
}