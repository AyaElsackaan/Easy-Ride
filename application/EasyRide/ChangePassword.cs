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
    public partial class ChangePassword : Form
    {
        int ID;
        char USER;
        public ChangePassword(int id,char user)
        {
            InitializeComponent();
            ID = id;
            USER = user;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            if (USER == 'R')
            {
                int n = Convert.ToInt32(controllerObj.checkPassRider(ID, textBoxOld.Text));
                if (n == 0)
                {
                    MessageBox.Show("Incorrect password!");
                }
                else if (textBoxNew.Text == "")
                {
                    MessageBox.Show("Please write your new password!");

                }
                else
                {
                    int x = controllerObj.UpdatePasswordRider(ID, textBoxNew.Text);
                    if (x != 0)
                    {
                        MessageBox.Show("Your Password was updated successfully!");
                    }
                }
            }
            else if(USER=='M')
            {  int n = Convert.ToInt32(controllerObj.checkPassManager(ID, textBoxOld.Text));
                if (n == 0)
                {
                    MessageBox.Show("Incorrect password!");
                }
                else if (textBoxNew.Text == "")
                {
                    MessageBox.Show("Please write your new password!");

                }
                else
                {
                    int x = controllerObj.UpdatePasswordManager(ID, textBoxNew.Text);
                    if (x != 0)
                    {
                        MessageBox.Show("Your Password was updated successfully!");
                    }
                }

            }
            else if(USER=='C')
            {
                int n = Convert.ToInt32(controllerObj.checkPassCSA(ID, textBoxOld.Text));
                if (n == 0)
                {
                    MessageBox.Show("Incorrect password!");
                }
                else if (textBoxNew.Text == "")
                {
                    MessageBox.Show("Please write your new password!");

                }
                else
                {
                    int x = controllerObj.UpdatePasswordCSA(ID, textBoxNew.Text);
                    if (x != 0)
                    {
                        MessageBox.Show("Your Password was updated successfully!");
                    }
                }
                
            }
            else if (USER=='D')
            {

            }
        }
    }
}
