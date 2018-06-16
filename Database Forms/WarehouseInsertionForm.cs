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
    public partial class WarehouseInsertionForm : Form
    {
        public WarehouseInsertionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int i =controllerObj.AddWarehouse(Int16.Parse(textBox1.Text), Int16.Parse(textBox2.Text), textBox3.Text, textBox4.Text);
            if (i == 0)
                MessageBox.Show("Warehouse Addition Failed");
            else
                MessageBox.Show("Warehouse Addition Succeeded");
        }
    }
}
