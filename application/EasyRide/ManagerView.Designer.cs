namespace EasyRide
{
    partial class ManagerView
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
            this.AddCustomerServiceAgent = new System.Windows.Forms.Button();
            this.RemoveTrip = new System.Windows.Forms.Button();
            this.AddTrip = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Update_CSAsalary = new System.Windows.Forms.Button();
            this.AddDriver = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTotIncome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCustomerServiceAgent
            // 
            this.AddCustomerServiceAgent.Location = new System.Drawing.Point(465, 124);
            this.AddCustomerServiceAgent.Name = "AddCustomerServiceAgent";
            this.AddCustomerServiceAgent.Size = new System.Drawing.Size(136, 45);
            this.AddCustomerServiceAgent.TabIndex = 7;
            this.AddCustomerServiceAgent.Text = "Add Customer Service Agent";
            this.AddCustomerServiceAgent.UseVisualStyleBackColor = true;
            this.AddCustomerServiceAgent.Click += new System.EventHandler(this.AddCustomerServiceAgent_Click_1);
            // 
            // RemoveTrip
            // 
            this.RemoveTrip.Location = new System.Drawing.Point(49, 194);
            this.RemoveTrip.Name = "RemoveTrip";
            this.RemoveTrip.Size = new System.Drawing.Size(120, 45);
            this.RemoveTrip.TabIndex = 6;
            this.RemoveTrip.Text = "Remove Trip";
            this.RemoveTrip.UseVisualStyleBackColor = true;
            this.RemoveTrip.Click += new System.EventHandler(this.RemoveTrip_Click);
            // 
            // AddTrip
            // 
            this.AddTrip.Location = new System.Drawing.Point(61, 124);
            this.AddTrip.Name = "AddTrip";
            this.AddTrip.Size = new System.Drawing.Size(92, 45);
            this.AddTrip.TabIndex = 5;
            this.AddTrip.Text = "Add Trip";
            this.AddTrip.UseVisualStyleBackColor = true;
            this.AddTrip.Click += new System.EventHandler(this.AddTrip_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(214, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 45);
            this.button5.TabIndex = 9;
            this.button5.Text = "Update Driver Salary";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Update_CSAsalary
            // 
            this.Update_CSAsalary.Location = new System.Drawing.Point(425, 194);
            this.Update_CSAsalary.Name = "Update_CSAsalary";
            this.Update_CSAsalary.Size = new System.Drawing.Size(207, 45);
            this.Update_CSAsalary.TabIndex = 8;
            this.Update_CSAsalary.Text = "Update Customer Service Salary";
            this.Update_CSAsalary.UseVisualStyleBackColor = true;
            this.Update_CSAsalary.Click += new System.EventHandler(this.Update_CSAsalary_Click);
            // 
            // AddDriver
            // 
            this.AddDriver.Location = new System.Drawing.Point(226, 124);
            this.AddDriver.Name = "AddDriver";
            this.AddDriver.Size = new System.Drawing.Size(143, 45);
            this.AddDriver.TabIndex = 10;
            this.AddDriver.Text = "Add Driver";
            this.AddDriver.UseVisualStyleBackColor = true;
            this.AddDriver.Click += new System.EventHandler(this.AddDriver_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(330, 334);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(99, 35);
            this.buttonLogOut.TabIndex = 11;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(153, 334);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(99, 35);
            this.buttonPass.TabIndex = 12;
            this.buttonPass.Text = "Change Password";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(82, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Welcome to Easy Ride!";
            // 
            // buttonTotIncome
            // 
            this.buttonTotIncome.Location = new System.Drawing.Point(182, 259);
            this.buttonTotIncome.Name = "buttonTotIncome";
            this.buttonTotIncome.Size = new System.Drawing.Size(94, 58);
            this.buttonTotIncome.TabIndex = 14;
            this.buttonTotIncome.Text = "Capacity Per Region";
            this.buttonTotIncome.UseVisualStyleBackColor = true;
            this.buttonTotIncome.Click += new System.EventHandler(this.buttonTotIncome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Statistics of Customer Service Agents";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTotIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.AddDriver);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Update_CSAsalary);
            this.Controls.Add(this.AddCustomerServiceAgent);
            this.Controls.Add(this.RemoveTrip);
            this.Controls.Add(this.AddTrip);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerServiceAgent;
        private System.Windows.Forms.Button RemoveTrip;
        private System.Windows.Forms.Button AddTrip;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Update_CSAsalary;
        private System.Windows.Forms.Button AddDriver;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTotIncome;
        private System.Windows.Forms.Button button1;
    }
}