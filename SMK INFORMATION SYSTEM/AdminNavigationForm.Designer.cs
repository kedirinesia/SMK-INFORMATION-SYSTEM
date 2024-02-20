namespace SMK_INFORMATION_SYSTEM
{
    partial class AdminNavigationForm
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
            this.lblEditProfile = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(107, 180);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(135, 35);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.Text = "MANAGE CLASS";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnTeachingSchedule
            // 
            this.btnTeachingSchedule.Location = new System.Drawing.Point(107, 126);
            this.btnTeachingSchedule.Name = "btnTeachingSchedule";
            this.btnTeachingSchedule.Size = new System.Drawing.Size(135, 37);
            this.btnTeachingSchedule.TabIndex = 10;
            this.btnTeachingSchedule.Text = "MANAGE TEACHER";
            this.btnTeachingSchedule.UseVisualStyleBackColor = true;
            this.btnTeachingSchedule.Click += new System.EventHandler(this.btnTeachingSchedule_Click);
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.Location = new System.Drawing.Point(107, 77);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(135, 33);
            this.lblEditProfile.TabIndex = 9;
            this.lblEditProfile.Text = "MANAGE STUDENT";
            this.lblEditProfile.UseVisualStyleBackColor = true;
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(25, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(208, 23);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome, [Admin Name]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "MANAGE SCHEDULE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.btnTeachingSchedule);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminNavigationForm";
            this.Load += new System.EventHandler(this.AdminNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button btnTeachingSchedule;
        private System.Windows.Forms.Button lblEditProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblWelcome;
    }
}