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
    public partial class AddBranchWarehouseTransaction : Form
    {
        public AddBranchWarehouseTransaction()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj.AddBranch_WarehouseTransaction(listBox2.SelectedIndex+1, listBox3.SelectedIndex + 1, listBox4.SelectedIndex + 1, Convert.ToDateTime(textBox5.Text), Int16.Parse(textBox6.Text), listBox1.GetItemText(listBox1.SelectedItem), Int16.Parse(textBox8.Text));
        }

        private void AddBranchWarehouseTransaction_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetBrID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox2.Items.Add(dt.Rows[i]["BranchID"].ToString());
            }
            DataTable dt1 = controllerObj.GetWHID();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                listBox3.Items.Add(dt1.Rows[i]["WarehouseID"].ToString());
            }
            DataTable dt2 = controllerObj.GetSupplyName();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                listBox4.Items.Add(dt2.Rows[i]["Name"].ToString());
            }
            DataTable dt3 = controllerObj.GetUnits();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                listBox1.Items.Add(dt3.Rows[i]["Descr"].ToString());
            }
        }
    }
}
