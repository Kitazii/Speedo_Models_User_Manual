namespace Employee_User_Manual
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmployeeUserManual = new System.Windows.Forms.Label();
            this.btnVideoTutorials = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmployeeUserManual
            // 
            this.lblEmployeeUserManual.AutoSize = true;
            this.lblEmployeeUserManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeUserManual.Location = new System.Drawing.Point(110, 260);
            this.lblEmployeeUserManual.Name = "lblEmployeeUserManual";
            this.lblEmployeeUserManual.Size = new System.Drawing.Size(406, 146);
            this.lblEmployeeUserManual.TabIndex = 2;
            this.lblEmployeeUserManual.Text = "Employee\r\nUser Manual";
            this.lblEmployeeUserManual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVideoTutorials
            // 
            this.btnVideoTutorials.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoTutorials.Location = new System.Drawing.Point(231, 441);
            this.btnVideoTutorials.Name = "btnVideoTutorials";
            this.btnVideoTutorials.Size = new System.Drawing.Size(174, 76);
            this.btnVideoTutorials.TabIndex = 3;
            this.btnVideoTutorials.Text = "Video Tutorials";
            this.btnVideoTutorials.UseVisualStyleBackColor = true;
            this.btnVideoTutorials.Click += new System.EventHandler(this.btnVideoTutorials_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 587);
            this.Controls.Add(this.btnVideoTutorials);
            this.Controls.Add(this.lblEmployeeUserManual);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speedo Models - Employee User Manual";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmployeeUserManual;
        private System.Windows.Forms.Button btnVideoTutorials;
    }
}

