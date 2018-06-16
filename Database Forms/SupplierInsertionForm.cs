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
    public partial class SupplierInsertionForm : Form
    {
        Controller controllerObj = new Controller();
        public SupplierInsertionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int No_of_rows = controllerObj.AddSupplier(Int16.Parse(textBox2.Text), textBox1.Text, textBox3.Text, textBox4.Text,textBox5.Text);
            if (No_of_rows == 0)
            {
                MessageBox.Show("Insertion Failed");
            }
            else
            {
                MessageBox.Show("Insertion succeeded");
            }
        }
    }
}
