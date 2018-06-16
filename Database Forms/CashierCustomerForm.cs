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
    public partial class CashierCustomerForm : Form
    {
        public CashierCustomerForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void CashierCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.projectDataSet.Customer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Controller.CID = Int16.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt =controllerObj.GetCustomerBySearch(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Refresh();            
        }
    }
}
