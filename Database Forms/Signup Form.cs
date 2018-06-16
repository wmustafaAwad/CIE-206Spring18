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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        Controller controllerObj = new Controller();

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            string p1 = Password_TextBox.Text;
            string p2 = ConfirmPassword_TextBox.Text;
            if (p1.CompareTo(p2) != 0)
                MessageBox.Show("Passwords do not match. Please re-enter your password and try again.", "Password Error");
            else
            {
                int privNum = Privilege_ComboBox.SelectedIndex + 1;
                string privilege = privNum.ToString();
                int x = controllerObj.AddUser(Username_TextBox.Text, p1, privilege);
                if (x != 1)
                    MessageBox.Show("Username not valid.", "Username Error");
                else
                {

                    MessageBox.Show("User has been added successfully.");
                    LoginForm ChildForm = new LoginForm();
                    this.Hide();
                    ChildForm.Show();
                }
            }
        }

        private void ConfirmPassword_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Privilege_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserButton_Click_1(object sender, EventArgs e)
        {
            string p1 = Password_TextBox.Text;
            string p2 = ConfirmPassword_TextBox.Text;
            if (p1.CompareTo(p2) != 0)
                MessageBox.Show("Passwords do not match. Please re-enter your password and try again.", "Password Error");
            else
            {
                int privNum = Privilege_ComboBox.SelectedIndex + 1;
                string privilege = privNum.ToString();
                int x = controllerObj.AddUser(Username_TextBox.Text, p1, privilege);
                if (x != 1)
                    MessageBox.Show("Username not valid.", "Username Error");
                else
                {

                    MessageBox.Show("User has been added successfully.");
                    LoginForm ChildForm = new LoginForm();
                    this.Hide();
                    ChildForm.Show();
                }
            }
        }
    }
}
