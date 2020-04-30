namespace EasyRide
{
    partial class RemovingTrip
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
            this.RemoveTrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TripIDs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RemoveTrip
            // 
            this.RemoveTrip.Location = new System.Drawing.Point(199, 208);
            this.RemoveTrip.Name = "RemoveTrip";
            this.RemoveTrip.Size = new System.Drawing.Size(75, 23);
            this.RemoveTrip.TabIndex = 5;
            this.RemoveTrip.Text = "Remove";
            this.RemoveTrip.UseVisualStyleBackColor = true;
            this.RemoveTrip.Click += new System.EventHandler(this.RemoveTrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trip ID";
            // 
            // TripIDs
            // 
            this.TripIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TripIDs.FormattingEnabled = true;
            this.TripIDs.Location = new System.Drawing.Point(117, 47);
            this.TripIDs.Name = "TripIDs";
            this.TripIDs.Size = new System.Drawing.Size(121, 21);
            this.TripIDs.TabIndex = 3;
            // 
            // RemovingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 274);
            this.Controls.Add(this.RemoveTrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TripIDs);
            this.Name = "RemovingTrip";
            this.Text = "RemovingTrip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TripIDs;
    }
}