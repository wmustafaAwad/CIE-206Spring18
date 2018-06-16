using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Forms
{
    public partial class ChangePasswordForm : Form
    {
        Controller controllerObj = new Controller();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePassword_Button_Click(object sender, EventArgs e)
        {
            string p1 = NewPassword_TextBox.Text;
            string p2 = ConfirmPassword_TextBox.Text;
            if (p1.CompareTo(p2) != 0)
                MessageBox.Show("Passwords do not match. Please re-enter your password and try again.", "Password Error");
            else
            {
                int x = controllerObj.ChangePassword(Username_TextBox.Text, CurrentPassword_TextBox.Text, p1);
                if (x == -1)
                    MessageBox.Show("Username or password incorrect.", "Error");
                else
                {
                    this.Hide();
                    MessageBox.Show("Password has been updated successfully.");
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
