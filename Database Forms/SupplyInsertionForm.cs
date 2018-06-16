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
    public partial class SupplyInsertionForm : Form
    {
        public SupplyInsertionForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void button1_Click(object sender, EventArgs e)
        {
        int no_of_rows = controllerObj.AddSupply(Int16.Parse(textBox3.Text), textBox1.Text, Int16.Parse(textBox2.Text),listBox1.GetItemText(listBox1.SelectedItem));
            if (no_of_rows == 0)
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
