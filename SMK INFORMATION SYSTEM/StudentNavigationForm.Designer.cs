namespace SMK_INFORMATION_SYSTEM
{
    partial class StudentNavigationForm
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
            this.BtnLogout = new System.Windows.Forms.Button();
            this.btnTeachingSchedule = new System.Windows.Forms.Button();
            this.BtnEditProfile = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(97, 177);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(135, 35);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnTeachingSchedule
            // 
            this.btnTeachingSchedule.Location = new System.Drawing.Point(97, 123);
            this.btnTeachingSchedule.Name = "btnTeachingSchedule";
            this.btnTeachingSchedule.Size = new System.Drawing.Size(135, 37);
            this.btnTeachingSchedule.TabIndex = 6;
            this.btnTeachingSchedule.Text = "Class Schedule";
            this.btnTeachingSchedule.UseVisualStyleBackColor = true;
            this.btnTeachingSchedule.Click += new System.EventHandler(this.btnTeachingSchedule_Click);
            // 
            // BtnEditProfile
            // 
            this.BtnEditProfile.Location = new System.Drawing.Point(97, 74);
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.Size = new System.Drawing.Size(135, 33);
            this.BtnEditProfile.TabIndex = 5;
            this.BtnEditProfile.Text = "EDIT PROFILE";
            this.BtnEditProfile.UseVisualStyleBackColor = true;
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(15, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(219, 23);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome, [Student Name]";
            // 
            // StudentNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 305);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.btnTeachingSchedule);
            this.Controls.Add(this.BtnEditProfile);
            this.Controls.Add(this.lblWelcome);
            this.Name = "StudentNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentNavigationForm";
            this.Load += new System.EventHandler(this.StudentNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button btnTeachingSchedule;
        private System.Windows.Forms.Button BtnEditProfile;
        public System.Windows.Forms.Label lblWelcome;
    }
}