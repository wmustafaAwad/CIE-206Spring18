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
    public partial class BranchInsertionForm : Form
    {
        public BranchInsertionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int i = controllerObj.AddBranch(Int16.Parse(textBox1.Text),Int16.Parse(textBox2.Text),textBox3.Text,textBox4.Text,textBox5.Text,Int16.Parse(textBox6.Text),textBox7.Text);
            if (i == 0)
            {
                MessageBox.Show("Branch Addition Failed");
            }
            else MessageBox.Show("Branch Addition succeeded");
        }
    }
}
