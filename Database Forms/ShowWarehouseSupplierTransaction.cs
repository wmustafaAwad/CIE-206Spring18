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
    public partial class ShowWarehouseSupplierTransaction : Form
    {
        public ShowWarehouseSupplierTransaction()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void ShowWarehouseSupplierTransaction_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetWHID();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i]["WarehouseID"].ToString());
            }
            DataTable dt1 = controllerObj.GetSupplyName();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                listBox2.Items.Add(dt1.Rows[i]["Name"].ToString());
            }
            DataTable dt2 = controllerObj.GetSupplierName();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                listBox3.Items.Add(dt2.Rows[i]["Name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource= controllerObj.ShowWareHouse_SupplierTransaction(listBox1.GetItemText(listBox1.SelectedItem), Convert.ToString(listBox2.SelectedIndex+1), Convert.ToString(listBox3.SelectedIndex + 1), textBox4.Text, textBox5.Text);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
