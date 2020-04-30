namespace EasyRide
{
    partial class Welcome
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
            this.buttonInbox = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.buttonFrom = new System.Windows.Forms.Button();
            this.buttonWallet = new System.Windows.Forms.Button();
            this.buttonTrips = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonInbox
            // 
            this.buttonInbox.Location = new System.Drawing.Point(75, 198);
            this.buttonInbox.Name = "buttonInbox";
            this.buttonInbox.Size = new System.Drawing.Size(105, 47);
            this.buttonInbox.TabIndex = 0;
            this.buttonInbox.Text = "Inbox";
            this.buttonInbox.UseVisualStyleBackColor = true;
            this.buttonInbox.Click += new System.EventHandler(this.buttonInbox_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(12, 359);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(105, 44);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonPassword
            // 
            this.buttonPassword.Location = new System.Drawing.Point(154, 361);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(105, 40);
            this.buttonPassword.TabIndex = 2;
            this.buttonPassword.Text = "Change Password";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // buttonFrom
            // 
            this.buttonFrom.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFrom.Location = new System.Drawing.Point(478, 252);
            this.buttonFrom.Name = "buttonFrom";
            this.buttonFrom.Size = new System.Drawing.Size(121, 49);
            this.buttonFrom.TabIndex = 3;
            this.buttonFrom.Text = "Book Now!";
            this.buttonFrom.UseVisualStyleBackColor = true;
            this.buttonFrom.Click += new System.EventHandler(this.buttonFrom_Click);
            // 
            // buttonWallet
            // 
            this.buttonWallet.Location = new System.Drawing.Point(27, 280);
            this.buttonWallet.Name = "buttonWallet";
            this.buttonWallet.Size = new System.Drawing.Size(94, 40);
            this.buttonWallet.TabIndex = 5;
            this.buttonWallet.Text = "My Wallet";
            this.buttonWallet.UseVisualStyleBackColor = true;
            this.buttonWallet.Click += new System.EventHandler(this.buttonWallet_Click);
            // 
            // buttonTrips
            // 
            this.buttonTrips.Location = new System.Drawing.Point(143, 280);
            this.buttonTrips.Name = "buttonTrips";
            this.buttonTrips.Size = new System.Drawing.Size(88, 40);
            this.buttonTrips.TabIndex = 6;
            this.buttonTrips.Text = "My Trips";
            this.buttonTrips.UseVisualStyleBackColor = true;
            this.buttonTrips.Click += new System.EventHandler(this.buttonTrips_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(154, 105);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "My Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(317, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome to Easy Ride!";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonTrips);
            this.Controls.Add(this.buttonWallet);
            this.Controls.Add(this.buttonFrom);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonInbox);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInbox;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonPassword;
        private System.Windows.Forms.Button buttonFrom;
        private System.Windows.Forms.Button buttonWallet;
        private System.Windows.Forms.Button buttonTrips;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

