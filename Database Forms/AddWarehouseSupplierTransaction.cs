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
    public partial class AddWarehouseSupplierTransaction : Form
    {
        public AddWarehouseSupplierTransaction()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void AddWarehouseSupplierTransaction_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetWHID();
            for (int i = 0; i < dt.Rows.Count; i++)
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
            DataTable dt3 = controllerObj.GetUnits();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                listBox4.Items.Add(dt3.Rows[i]["Descr"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int no_of_rows= controllerObj.AddWareHouse_SupplierTransaction(listBox1.GetItemText(listBox1.SelectedItem), Convert.ToString(listBox2.SelectedIndex + 1), Convert.ToString(listBox3.SelectedIndex + 1), textBox1.Text, listBox4.GetItemText(listBox4.SelectedItem), textBox2.Text, textBox3.Text, textBox4.Text);
            if (no_of_rows == 0)
            {
                MessageBox.Show("Addition Failed");
            }
            else
            {
                MessageBox.Show("Addition Succeeded");
            }
        }
    }
}
