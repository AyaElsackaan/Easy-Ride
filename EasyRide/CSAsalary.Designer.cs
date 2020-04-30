namespace EasyRide
{
    partial class CSAsalary
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
            this.Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSalary = new System.Windows.Forms.NumericUpDown();
            this.CSA_IDs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(177, 173);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Service Agent ID";
            // 
            // NewSalary
            // 
            this.NewSalary.Location = new System.Drawing.Point(249, 117);
            this.NewSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NewSalary.Name = "NewSalary";
            this.NewSalary.Size = new System.Drawing.Size(120, 20);
            this.NewSalary.TabIndex = 6;
            // 
            // CSA_IDs
            // 
            this.CSA_IDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CSA_IDs.FormattingEnabled = true;
            this.CSA_IDs.Location = new System.Drawing.Point(249, 42);
            this.CSA_IDs.Name = "CSA_IDs";
            this.CSA_IDs.Size = new System.Drawing.Size(121, 21);
            this.CSA_IDs.TabIndex = 5;
            // 
            // CSAsalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 271);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewSalary);
            this.Controls.Add(this.CSA_IDs);
            this.Name = "CSAsalary";
            this.Text = "CSAsalary";
            ((System.ComponentModel.ISupportInitialize)(this.NewSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NewSalary;
        private System.Windows.Forms.ComboBox CSA_IDs;
    }
}