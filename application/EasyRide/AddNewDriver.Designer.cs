namespace EasyRide
{
    partial class AddNewDriver
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
            this.Driver_salary = new System.Windows.Forms.NumericUpDown();
            this.Password = new System.Windows.Forms.TextBox();
            this.Driver_ID = new System.Windows.Forms.TextBox();
            this.Driver_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DriverPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Driver_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // Driver_salary
            // 
            this.Driver_salary.Location = new System.Drawing.Point(391, 35);
            this.Driver_salary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Driver_salary.Name = "Driver_salary";
            this.Driver_salary.Size = new System.Drawing.Size(100, 20);
            this.Driver_salary.TabIndex = 16;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(391, 85);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 15;
            // 
            // Driver_ID
            // 
            this.Driver_ID.Location = new System.Drawing.Point(111, 35);
            this.Driver_ID.Name = "Driver_ID";
            this.Driver_ID.Size = new System.Drawing.Size(100, 20);
            this.Driver_ID.TabIndex = 14;
            // 
            // Driver_Name
            // 
            this.Driver_Name.Location = new System.Drawing.Point(111, 85);
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.Size = new System.Drawing.Size(100, 20);
            this.Driver_Name.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // DriverPhone
            // 
            this.DriverPhone.Location = new System.Drawing.Point(111, 142);
            this.DriverPhone.Name = "DriverPhone";
            this.DriverPhone.Size = new System.Drawing.Size(100, 20);
            this.DriverPhone.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone";
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(391, 208);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 19;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // AddNewDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 291);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DriverPhone);
            this.Controls.Add(this.Driver_salary);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Driver_ID);
            this.Controls.Add(this.Driver_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewDriver";
            this.Text = "AddDriver";
            ((System.ComponentModel.ISupportInitialize)(this.Driver_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Driver_salary;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Driver_ID;
        private System.Windows.Forms.TextBox Driver_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DriverPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonADD;
    }
}