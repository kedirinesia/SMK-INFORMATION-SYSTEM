namespace SMK_INFORMATION_SYSTEM
{
    partial class TeacherNavigationForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEditProfile = new System.Windows.Forms.Button();
            this.btnTeachingSchedule = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(35, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(217, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [Teacher Name]";
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.Location = new System.Drawing.Point(117, 81);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(135, 33);
            this.lblEditProfile.TabIndex = 1;
            this.lblEditProfile.Text = "EDIT PROFILE";
            this.lblEditProfile.UseVisualStyleBackColor = true;
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            // 
            // btnTeachingSchedule
            // 
            this.btnTeachingSchedule.Location = new System.Drawing.Point(117, 130);
            this.btnTeachingSchedule.Name = "btnTeachingSchedule";
            this.btnTeachingSchedule.Size = new System.Drawing.Size(135, 37);
            this.btnTeachingSchedule.TabIndex = 2;
            this.btnTeachingSchedule.Text = "Teaching Schedule";
            this.btnTeachingSchedule.UseVisualStyleBackColor = true;
            this.btnTeachingSchedule.Click += new System.EventHandler(this.btnTeachingSchedule_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(117, 184);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(135, 35);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // TeacherNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 265);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.btnTeachingSchedule);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.lblWelcome);
            this.Name = "TeacherNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherNavigationForm";
            this.Load += new System.EventHandler(this.TeacherNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lblEditProfile;
        private System.Windows.Forms.Button btnTeachingSchedule;
        private System.Windows.Forms.Button BtnLogout;
        public System.Windows.Forms.Label lblWelcome;
    }
}