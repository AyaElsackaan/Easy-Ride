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
    public partial class LogIn : Form
    {
        char user;
        int ID;
        public LogIn(char C)
        {
            InitializeComponent();
            user = C;
            if (C=='R')
            {
                buttonSign.Enabled = true;
                buttonSign.Visible = true;

            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string t = textBoxPassword.Text;
            int id =Convert.ToInt32( numericUpDownID.Value);
            if (t == "")
            {
                MessageBox.Show("please enter your password!");
            }
            else if (user=='R')
            {
                
                Controller controllerObj = new Controller();
                int n = Convert.ToInt32(controllerObj.checkidRider(id));
                if (n == 0)
                {
                    MessageBox.Show("This ID doesn't exist");
                }
                else
                {
                    
                    int n2 = Convert.ToInt32(controllerObj.checkPassRider(id, t));
                    if (n2 == 0)
                    {
                        MessageBox.Show("Invalid Password");
                    }
                    else
                    {
                        ID = id;
                        Welcome w = new Welcome(ID);
                        w.Show();
                    }
               }
               
            }
            else if (user == 'D')
            {
                Controller controllerObj = new Controller();
                int n = Convert.ToInt32(controllerObj.checkidDriver(id));
                if (n == 0)
                {
                    MessageBox.Show("This ID doesn't exist");
                }
                else
                {

                    int n2 = Convert.ToInt32(controllerObj.checkPassDriver(id, t));
                    if (n2 == 0)
                    {
                        MessageBox.Show("Invalid Password");
                    }
                    else
                    {
                        ID = id;
                        DriverWelcome w = new DriverWelcome(ID);
                        w.Show();
                    }
                }

            }
            else if (user == 'C')
            {
                Controller controllerObj = new Controller();
                int n = Convert.ToInt32(controllerObj.checkidCSA(id));
                if (n == 0)
                {
                    MessageBox.Show("This ID doesn't exist");
                }
                else
                {

                    int n2 = Convert.ToInt32(controllerObj.checkPassCSA(id, t));
                    if (n2 == 0)
                    {
                        MessageBox.Show("Invalid Password");
                    }
                    else
                    {
                        ID = id;
                        Customer_Service cs = new Customer_Service(ID);
                        cs.Show();
                    }
                }
               

            }
            else if (user == 'M')
            {
                

                Controller controllerObj = new Controller();
                int n = Convert.ToInt32(controllerObj.checkidManager(id));
                if (n == 0)
                {
                    MessageBox.Show("This ID doesn't exist");
                }
                else
                {

                    int n2 = Convert.ToInt32(controllerObj.checkPassManager(id, t));
                    if (n2 == 0)
                    {
                        MessageBox.Show("Invalid Password");
                    }
                    else
                    {
                        ID = id;
                        ManagerView m = new ManagerView(ID);
                         m.Show();
                    }
                }

            }




        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            sn.Show();
        }
    }
}
