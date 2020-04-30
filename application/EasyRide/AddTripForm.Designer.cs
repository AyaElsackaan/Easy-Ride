namespace EasyRide
{
    partial class AddTripForm
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
            this.Direction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTripWithData = new System.Windows.Forms.Button();
            this.addtrip_bus_no = new System.Windows.Forms.ComboBox();
            this.addtrip_driver_id = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trip_price = new System.Windows.Forms.NumericUpDown();
            this.triptime_hour = new System.Windows.Forms.NumericUpDown();
            this.triptime_minute = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trip_Region = new System.Windows.Forms.ComboBox();
            this.tripCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trip_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triptime_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triptime_minute)).BeginInit();
            this.SuspendLayout();
            // 
            // Direction
            // 
            this.Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "From",
            "To"});
            this.Direction.Location = new System.Drawing.Point(356, 202);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(95, 21);
            this.Direction.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Direction";
            // 
            // AddTripWithData
            // 
            this.AddTripWithData.Location = new System.Drawing.Point(365, 289);
            this.AddTripWithData.Name = "AddTripWithData";
            this.AddTripWithData.Size = new System.Drawing.Size(75, 23);
            this.AddTripWithData.TabIndex = 40;
            this.AddTripWithData.Text = "AddTrip";
            this.AddTripWithData.UseVisualStyleBackColor = true;
            this.AddTripWithData.Click += new System.EventHandler(this.AddTripWithData_Click_1);
            // 
            // addtrip_bus_no
            // 
            this.addtrip_bus_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addtrip_bus_no.FormattingEnabled = true;
            this.addtrip_bus_no.Location = new System.Drawing.Point(356, 110);
            this.addtrip_bus_no.Name = "addtrip_bus_no";
            this.addtrip_bus_no.Size = new System.Drawing.Size(74, 21);
            this.addtrip_bus_no.TabIndex = 39;
            // 
            // addtrip_driver_id
            // 
            this.addtrip_driver_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addtrip_driver_id.FormattingEnabled = true;
            this.addtrip_driver_id.Location = new System.Drawing.Point(356, 151);
            this.addtrip_driver_id.Name = "addtrip_driver_id";
            this.addtrip_driver_id.Size = new System.Drawing.Size(95, 21);
            this.addtrip_driver_id.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Bus No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Driver ID";
            // 
            // trip_price
            // 
            this.trip_price.Location = new System.Drawing.Point(113, 263);
            this.trip_price.Name = "trip_price";
            this.trip_price.Size = new System.Drawing.Size(79, 20);
            this.trip_price.TabIndex = 35;
            // 
            // triptime_hour
            // 
            this.triptime_hour.Location = new System.Drawing.Point(113, 218);
            this.triptime_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.triptime_hour.Name = "triptime_hour";
            this.triptime_hour.Size = new System.Drawing.Size(55, 20);
            this.triptime_hour.TabIndex = 34;
            // 
            // triptime_minute
            // 
            this.triptime_minute.Location = new System.Drawing.Point(174, 218);
            this.triptime_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.triptime_minute.Name = "triptime_minute";
            this.triptime_minute.Size = new System.Drawing.Size(48, 20);
            this.triptime_minute.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Minutes";
            // 
            // trip_Region
            // 
            this.trip_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trip_Region.FormattingEnabled = true;
            this.trip_Region.Location = new System.Drawing.Point(113, 151);
            this.trip_Region.Name = "trip_Region";
            this.trip_Region.Size = new System.Drawing.Size(100, 21);
            this.trip_Region.TabIndex = 30;
            // 
            // tripCode
            // 
            this.tripCode.Location = new System.Drawing.Point(113, 110);
            this.tripCode.Name = "tripCode";
            this.tripCode.Size = new System.Drawing.Size(55, 20);
            this.tripCode.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Trip code";
            // 
            // AddTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 358);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddTripWithData);
            this.Controls.Add(this.addtrip_bus_no);
            this.Controls.Add(this.addtrip_driver_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trip_price);
            this.Controls.Add(this.triptime_hour);
            this.Controls.Add(this.triptime_minute);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trip_Region);
            this.Controls.Add(this.tripCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTripForm";
            this.Text = "AddTripForm";
            ((System.ComponentModel.ISupportInitialize)(this.trip_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triptime_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triptime_minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Direction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddTripWithData;
        private System.Windows.Forms.ComboBox addtrip_bus_no;
        private System.Windows.Forms.ComboBox addtrip_driver_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown trip_price;
        private System.Windows.Forms.NumericUpDown triptime_hour;
        private System.Windows.Forms.NumericUpDown triptime_minute;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox trip_Region;
        private System.Windows.Forms.TextBox tripCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}