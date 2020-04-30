namespace EasyRide
{
    partial class DriverWelcome
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
            this.buttonViewTrip = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewTrip
            // 
            this.buttonViewTrip.Location = new System.Drawing.Point(323, 92);
            this.buttonViewTrip.Name = "buttonViewTrip";
            this.buttonViewTrip.Size = new System.Drawing.Size(140, 68);
            this.buttonViewTrip.TabIndex = 0;
            this.buttonViewTrip.Text = "View My Trips";
            this.buttonViewTrip.UseVisualStyleBackColor = true;
            this.buttonViewTrip.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(241, 254);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(109, 51);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(435, 254);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(108, 51);
            this.buttonPass.TabIndex = 2;
            this.buttonPass.Text = "Change Password";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // DriverWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonViewTrip);
            this.Name = "DriverWelcome";
            this.Text = "DriverWelcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewTrip;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonPass;
    }
}