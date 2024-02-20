namespace SMK_INFORMATION_SYSTEM
{
    partial class FrmViewSchedule
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
            this.DGTeachingSchedule = new System.Windows.Forms.DataGridView();
            this.lblTeachingSchedule = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTeachingSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTeachingSchedule
            // 
            this.DGTeachingSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTeachingSchedule.Location = new System.Drawing.Point(12, 88);
            this.DGTeachingSchedule.Name = "DGTeachingSchedule";
            this.DGTeachingSchedule.Size = new System.Drawing.Size(776, 309);
            this.DGTeachingSchedule.TabIndex = 3;
            // 
            // lblTeachingSchedule
            // 
            this.lblTeachingSchedule.AutoSize = true;
            this.lblTeachingSchedule.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachingSchedule.Location = new System.Drawing.Point(303, 44);
            this.lblTeachingSchedule.Name = "lblTeachingSchedule";
            this.lblTeachingSchedule.Size = new System.Drawing.Size(178, 31);
            this.lblTeachingSchedule.TabIndex = 2;
            this.lblTeachingSchedule.Text = "View Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Subject Info";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGTeachingSchedule);
            this.Controls.Add(this.lblTeachingSchedule);
            this.Name = "FrmViewSchedule";
            this.Text = "FrmViewSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.DGTeachingSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTeachingSchedule;
        private System.Windows.Forms.Label lblTeachingSchedule;
        private System.Windows.Forms.Button button1;
    }
}