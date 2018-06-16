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
    public partial class ShowBranchWarehouseTransactionForm : Form
    {
        public ShowBranchWarehouseTransactionForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();

        private void ShowBranchWarehouseTransactionForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetBrID();
            DataTable dt1 = controllerObj.GetWHID();
            DataTable dt2 = controllerObj.GetSupplyName();
            for(int i=0;i<dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i]["BranchID"].ToString());
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                listBox2.Items.Add(dt1.Rows[i]["WarehouseID"].ToString());
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                listBox3.Items.Add(dt2.Rows[i]["Name"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource=controllerObj.ShowBranch_WarehouseTransaction(Convert.ToString(listBox1.SelectedIndex + 1), Convert.ToString(listBox2.SelectedIndex + 1), Convert.ToString(listBox3.SelectedIndex + 1), textBox4.Text);
            dataGridView1.Refresh();
        }
    }
}
