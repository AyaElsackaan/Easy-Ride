using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRide
{
    public partial class Inbox : Form
    {
        int ID;
        public Inbox(int id)
        {
            InitializeComponent();
            ID = id;

            Controller controllerObj = new Controller();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = controllerObj.getComNo(ID);
            comboBox1.DisplayMember = "comp_no";

        }

       
        private void buttonShow_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            Controller controllerObj = new Controller();
            int comp=Convert.ToInt32(comboBox1.Text);
            richTextBox1.Text = controllerObj.getReply(comp).ToString();
        }
    }
}
