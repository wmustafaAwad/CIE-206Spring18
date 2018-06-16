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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Cust_Order' table. You can move, or remove it, as needed.
            this.cust_OrderTableAdapter.Fill(this.projectDataSet.Cust_Order);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int ID = Int16.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int n = controllerObj.EditOrderStatus(listBox1.GetItemText(listBox1.SelectedItem), ID);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cust_OrderTableAdapter.Fill(this.projectDataSet.Cust_Order);
            dataGridView1.Refresh();
        }
    }
}
