namespace EasyRide
{
    partial class SelectUser
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
            this.buttonRider = new System.Windows.Forms.Button();
            this.buttonDriver = new System.Windows.Forms.Button();
            this.buttonCS = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRider
            // 
            this.buttonRider.Location = new System.Drawing.Point(60, 106);
            this.buttonRider.Name = "buttonRider";
            this.buttonRider.Size = new System.Drawing.Size(107, 67);
            this.buttonRider.TabIndex = 0;
            this.buttonRider.Text = "Rider";
            this.buttonRider.UseVisualStyleBackColor = true;
            this.buttonRider.Click += new System.EventHandler(this.buttonRider_Click);
            // 
            // buttonDriver
            // 
            this.buttonDriver.Location = new System.Drawing.Point(60, 228);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Size = new System.Drawing.Size(107, 67);
            this.buttonDriver.TabIndex = 1;
            this.buttonDriver.Text = "Driver";
            this.buttonDriver.UseVisualStyleBackColor = true;
            this.buttonDriver.Click += new System.EventHandler(this.buttonDriver_Click);
            // 
            // buttonCS
            // 
            this.buttonCS.Location = new System.Drawing.Point(279, 106);
            this.buttonCS.Name = "buttonCS";
            this.buttonCS.Size = new System.Drawing.Size(101, 67);
            this.buttonCS.TabIndex = 2;
            this.buttonCS.Text = "CSagent";
            this.buttonCS.UseVisualStyleBackColor = true;
            this.buttonCS.Click += new System.EventHandler(this.buttonCS_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(279, 228);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(101, 67);
            this.buttonManager.TabIndex = 3;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome to Easy Ride!";
            // 
            // SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonCS);
            this.Controls.Add(this.buttonDriver);
            this.Controls.Add(this.buttonRider);
            this.Name = "SelectUser";
            this.Text = "SelectUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRider;
        private System.Windows.Forms.Button buttonDriver;
        private System.Windows.Forms.Button buttonCS;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Label label2;
    }
}