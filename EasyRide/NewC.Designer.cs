namespace EasyRide
{
    partial class NewC
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
            this.Add_C_S_A = new System.Windows.Forms.Button();
            this.C_S_A_Region = new System.Windows.Forms.ComboBox();
            this.C_S_A_salary = new System.Windows.Forms.NumericUpDown();
            this.Password = new System.Windows.Forms.TextBox();
            this.C_S_A_ID = new System.Windows.Forms.TextBox();
            this.C_S_A_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.C_S_A_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_C_S_A
            // 
            this.Add_C_S_A.Location = new System.Drawing.Point(394, 232);
            this.Add_C_S_A.Name = "Add_C_S_A";
            this.Add_C_S_A.Size = new System.Drawing.Size(75, 23);
            this.Add_C_S_A.TabIndex = 21;
            this.Add_C_S_A.Text = "Add";
            this.Add_C_S_A.UseVisualStyleBackColor = true;
            this.Add_C_S_A.Click += new System.EventHandler(this.Add_C_S_A_Click);
            // 
            // C_S_A_Region
            // 
            this.C_S_A_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_S_A_Region.FormattingEnabled = true;
            this.C_S_A_Region.Location = new System.Drawing.Point(129, 172);
            this.C_S_A_Region.Name = "C_S_A_Region";
            this.C_S_A_Region.Size = new System.Drawing.Size(121, 21);
            this.C_S_A_Region.TabIndex = 20;
            // 
            // C_S_A_salary
            // 
            this.C_S_A_salary.Location = new System.Drawing.Point(409, 57);
            this.C_S_A_salary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.C_S_A_salary.Name = "C_S_A_salary";
            this.C_S_A_salary.Size = new System.Drawing.Size(100, 20);
            this.C_S_A_salary.TabIndex = 19;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(409, 107);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 18;
            // 
            // C_S_A_ID
            // 
            this.C_S_A_ID.Location = new System.Drawing.Point(129, 57);
            this.C_S_A_ID.Name = "C_S_A_ID";
            this.C_S_A_ID.Size = new System.Drawing.Size(100, 20);
            this.C_S_A_ID.TabIndex = 17;
            // 
            // C_S_A_Name
            // 
            this.C_S_A_Name.Location = new System.Drawing.Point(129, 107);
            this.C_S_A_Name.Name = "C_S_A_Name";
            this.C_S_A_Name.Size = new System.Drawing.Size(100, 20);
            this.C_S_A_Name.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // NewC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 298);
            this.Controls.Add(this.Add_C_S_A);
            this.Controls.Add(this.C_S_A_Region);
            this.Controls.Add(this.C_S_A_salary);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.C_S_A_ID);
            this.Controls.Add(this.C_S_A_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewC";
            this.Text = "NewC";
            ((System.ComponentModel.ISupportInitialize)(this.C_S_A_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_C_S_A;
        private System.Windows.Forms.ComboBox C_S_A_Region;
        private System.Windows.Forms.NumericUpDown C_S_A_salary;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox C_S_A_ID;
        private System.Windows.Forms.TextBox C_S_A_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}