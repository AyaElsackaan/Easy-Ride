namespace EasyRide
{
    partial class MyWallet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.textBoxPromo = new System.Windows.Forms.TextBox();
            this.textBoxAddPromo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promotion:";
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(251, 48);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.ReadOnly = true;
            this.textBoxCredit.Size = new System.Drawing.Size(100, 20);
            this.textBoxCredit.TabIndex = 2;
            // 
            // textBoxPromo
            // 
            this.textBoxPromo.Location = new System.Drawing.Point(251, 100);
            this.textBoxPromo.Name = "textBoxPromo";
            this.textBoxPromo.ReadOnly = true;
            this.textBoxPromo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPromo.TabIndex = 3;
            // 
            // textBoxAddPromo
            // 
            this.textBoxAddPromo.Location = new System.Drawing.Point(251, 195);
            this.textBoxAddPromo.Name = "textBoxAddPromo";
            this.textBoxAddPromo.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPromo.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(204, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Promo Code";
            // 
            // MyWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddPromo);
            this.Controls.Add(this.textBoxPromo);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyWallet";
            this.Text = "MyWallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.TextBox textBoxPromo;
        private System.Windows.Forms.TextBox textBoxAddPromo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
    }
}