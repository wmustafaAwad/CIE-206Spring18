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
    public partial class EmployeeSearchForm : Form
    {
        public EmployeeSearchForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource= controllerObj.GetEmployeeBySearch(textBox1.Text, textBox2.Text, textBox3.Text, listBox1.SelectedIndex, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text,listBox2.SelectedIndex+1 ,textBox9.Text);
            dataGridView1.Refresh();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.SelectedIndex = -1;
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.SelectedIndex = -1;
        }
    }
}
