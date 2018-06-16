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
    public partial class CashierAddCustomerForm : Form
    {
        public CashierAddCustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int no_of_rows =controllerObj.AddCustomer(Int16.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,textBox6.Text,textBox7.Text);
            if (no_of_rows == 1)
                MessageBox.Show("Successful");
            else MessageBox.Show("Failed");

        }
    }
}
