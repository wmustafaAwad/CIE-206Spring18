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
    public partial class TotalIncomeMenuStripForm : Form
    {
        public TotalIncomeMenuStripForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();

        private void button1_Click(object sender, EventArgs e)
        {
            string income = controllerObj.GetTotal_Income(listBox2.SelectedIndex + 1, Int16.Parse(textBox1.Text), listBox4.SelectedIndex + 1, Int16.Parse(textBox2.Text));
            textBox3.Text = income;
        }


    }
}
