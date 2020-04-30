namespace EasyRide
{
    partial class UpdateDriverSalary
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
            this.DriverID = new System.Windows.Forms.ComboBox();
            this.NewSalary = new System.Windows.Forms.NumericUpDown();
            this.Update_driver_salary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverID
            // 
            this.DriverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriverID.FormattingEnabled = true;
            this.DriverID.Location = new System.Drawing.Point(148, 48);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(121, 21);
            this.DriverID.TabIndex = 9;
            // 
            // NewSalary
            // 
            this.NewSalary.Location = new System.Drawing.Point(149, 116);
            this.NewSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NewSalary.Name = "NewSalary";
            this.NewSalary.Size = new System.Drawing.Size(120, 20);
            this.NewSalary.TabIndex = 8;
            // 
            // Update_driver_salary
            // 
            this.Update_driver_salary.Location = new System.Drawing.Point(119, 191);
            this.Update_driver_salary.Name = "Update_driver_salary";
            this.Update_driver_salary.Size = new System.Drawing.Size(75, 23);
            this.Update_driver_salary.TabIndex = 7;
            this.Update_driver_salary.Text = "Update ";
            this.Update_driver_salary.UseVisualStyleBackColor = true;
            this.Update_driver_salary.Click += new System.EventHandler(this.Update_driver_salary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Driver ID";
            // 
            // UpdateDriverSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.DriverID);
            this.Controls.Add(this.NewSalary);
            this.Controls.Add(this.Update_driver_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDriverSalary";
            this.Text = "UpdateDriverSalary";
            ((System.ComponentModel.ISupportInitialize)(this.NewSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DriverID;
        private System.Windows.Forms.NumericUpDown NewSalary;
        private System.Windows.Forms.Button Update_driver_salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}