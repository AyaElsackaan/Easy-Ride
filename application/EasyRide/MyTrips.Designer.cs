namespace EasyRide
{
    partial class MyTrips
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
            this.comboBoxUpcoming = new System.Windows.Forms.ComboBox();
            this.comboBoxPrevious = new System.Windows.Forms.ComboBox();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonComplain = new System.Windows.Forms.Button();
            this.buttonRate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxUpcoming
            // 
            this.comboBoxUpcoming.FormattingEnabled = true;
            this.comboBoxUpcoming.Location = new System.Drawing.Point(178, 47);
            this.comboBoxUpcoming.Name = "comboBoxUpcoming";
            this.comboBoxUpcoming.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUpcoming.TabIndex = 0;
            // 
            // comboBoxPrevious
            // 
            this.comboBoxPrevious.FormattingEnabled = true;
            this.comboBoxPrevious.Location = new System.Drawing.Point(178, 114);
            this.comboBoxPrevious.Name = "comboBoxPrevious";
            this.comboBoxPrevious.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrevious.TabIndex = 1;
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(411, 35);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(109, 42);
            this.buttonDetails.TabIndex = 2;
            this.buttonDetails.Text = "View Trip Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // buttonComplain
            // 
            this.buttonComplain.Location = new System.Drawing.Point(475, 156);
            this.buttonComplain.Name = "buttonComplain";
            this.buttonComplain.Size = new System.Drawing.Size(83, 41);
            this.buttonComplain.TabIndex = 3;
            this.buttonComplain.Text = "Complain";
            this.buttonComplain.UseVisualStyleBackColor = true;
            this.buttonComplain.Click += new System.EventHandler(this.buttonComplain_Click);
            // 
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(91, 156);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(92, 41);
            this.buttonRate.TabIndex = 4;
            this.buttonRate.Text = "Rate Trip";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upcoming Trips:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Previous Trips:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(147, 410);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(78, 33);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please provide a rating from [0-5] where 5: excellent, 0: very bad.";
            this.label3.Visible = false;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxRating.Location = new System.Drawing.Point(120, 330);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRating.TabIndex = 8;
            this.comboBoxRating.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "How was your trip?";
            this.label4.Visible = false;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(520, 410);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(95, 33);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Visible = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(436, 273);
            this.richTextBox1.MaxLength = 1000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 116);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "What went wrong? Please tell us more.";
            this.label5.Visible = false;
            // 
            // MyTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 565);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.buttonComplain);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.comboBoxPrevious);
            this.Controls.Add(this.comboBoxUpcoming);
            this.Name = "MyTrips";
            this.Text = "MyTrips";
            this.Load += new System.EventHandler(this.MyTrips_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUpcoming;
        private System.Windows.Forms.ComboBox comboBoxPrevious;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonComplain;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
    }
}