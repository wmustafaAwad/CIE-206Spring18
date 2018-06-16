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
    public partial class EmployeeInsertionForm : Form
    {
        public EmployeeInsertionForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();


        private void button1_Click(object sender, EventArgs e)
        {
            bool Gender = false;
            string SuperID = "null";
            if (textBox9.Text != "")
            {
                SuperID = textBox9.Text;
            }
            if (listBox1.SelectedIndex == 0)
            {
                Gender = false;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                Gender = true;
            }
            if (listBox3.SelectedIndex == 0)
            {
                int no_of_rows = controllerObj.AddEmployee(textBox1.Text, textBox2.Text, textBox3.Text, Gender, Int16.Parse(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, Int16.Parse(textBox8.Text), listBox2.GetItemText(listBox2.SelectedItem), SuperID);
                if (no_of_rows == 0)
                {
                    MessageBox.Show("Insertion Failed");
                }
                else
                {
                    controllerObj.InsertJobWH(Int16.Parse(listBox4.GetItemText(listBox4.SelectedItem)), textBox4.Text);
                    MessageBox.Show("Insertion succeeded");
                }
            }
            else if (listBox3.SelectedIndex == 1)
            {
                int no_of_rows = controllerObj.AddEmployee(textBox1.Text, textBox2.Text, textBox3.Text, Gender, Int16.Parse(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, Int16.Parse(textBox8.Text), listBox2.GetItemText(listBox2.SelectedItem), SuperID);
                if (no_of_rows == 0)
                {
                    MessageBox.Show("Insertion Failed");
                }
                else
                {
                    controllerObj.InsertJobBr(Int16.Parse(listBox4.GetItemText(listBox4.SelectedItem)), textBox4.Text);
                    MessageBox.Show("Insertion succeeded");
                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {
                listBox4.Items.Clear();
                listBox4.Visible = true;
                label14.Text = "WHID";
                DataTable dt = controllerObj.GetWHID();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox4.Items.Add(Convert.ToString(dt.Rows[i]["WarehouseID"]));
                   
                }
            }
            else if(listBox3.SelectedIndex == 1)
            {
                listBox4.Items.Clear();
                listBox4.Visible = true;
                label14.Text = "BrID";
                DataTable dt = controllerObj.GetBrID();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox4.Items.Add(Convert.ToString(dt.Rows[i]["BranchID"]));
                }
            }
        }
    }
}
