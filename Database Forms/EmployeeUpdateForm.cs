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
    public partial class EmployeeUpdateForm : Form
    {
        public EmployeeUpdateForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox8.SelectedIndex == 0 &&listBox6.SelectedIndex==0)
            {
                int no_of_rows = controllerObj.UpdateEmployee(textBox18.Text, textBox12.Text, textBox11.Text, listBox4.SelectedIndex, textBox10.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text, listBox3.SelectedIndex + 1, textBox13.Text, textBox1.Text, textBox2.Text, textBox3.Text, listBox1.SelectedIndex, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, listBox2.SelectedIndex + 1, textBox9.Text);
                controllerObj.UpdateJobWH(Int16.Parse(listBox7.GetItemText(listBox7.SelectedItem)), textBox4.Text, Int16.Parse(textBox19.Text));
                MessageBox.Show("Successful");
               
            }
            else if (listBox8.SelectedIndex == 1 &&listBox6.SelectedIndex==1)
            {
                int no_of_rows = controllerObj.UpdateEmployee(textBox18.Text, textBox12.Text, textBox11.Text, listBox4.SelectedIndex, textBox10.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text, listBox3.SelectedIndex + 1, textBox13.Text, textBox1.Text, textBox2.Text, textBox3.Text, listBox1.SelectedIndex, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, listBox2.SelectedIndex + 1, textBox9.Text);
                controllerObj.UpdateJobBr(Int16.Parse(listBox7.GetItemText(listBox7.SelectedItem)), textBox4.Text, Int16.Parse(textBox19.Text));
                MessageBox.Show("Successful");
            }
            else if(listBox8.SelectedIndex == 1 && listBox6.SelectedIndex == 0)
            {
                int no_of_rows = controllerObj.UpdateEmployee(textBox18.Text, textBox12.Text, textBox11.Text, listBox4.SelectedIndex, textBox10.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text, listBox3.SelectedIndex + 1, textBox13.Text, textBox1.Text, textBox2.Text, textBox3.Text, listBox1.SelectedIndex, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, listBox2.SelectedIndex + 1, textBox9.Text);
                controllerObj.InsertJobBr(Int16.Parse(listBox7.GetItemText(listBox7.SelectedItem)), textBox4.Text);
                controllerObj.DeleteJobWH(textBox4.Text);
                MessageBox.Show("Successful");
            }
            else if (listBox8.SelectedIndex == 0 && listBox6.SelectedIndex == 1)
            {
                int no_of_rows = controllerObj.UpdateEmployee(textBox18.Text, textBox12.Text, textBox11.Text, listBox4.SelectedIndex, textBox10.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text, listBox3.SelectedIndex + 1, textBox13.Text, textBox1.Text, textBox2.Text, textBox3.Text, listBox1.SelectedIndex, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, listBox2.SelectedIndex + 1, textBox9.Text);
                controllerObj.InsertJobWH(Int16.Parse(listBox7.GetItemText(listBox7.SelectedItem)), textBox4.Text);
                controllerObj.DeleteJobBr(textBox4.Text);
                MessageBox.Show("Successful");
            }
        }
        

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox8.SelectedIndex == 0)
            {
                listBox7.Items.Clear();
                listBox7.Visible = true;
                label14.Text = "WH or BrID";
                DataTable dt = controllerObj.GetWHID();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox7.Items.Add(Convert.ToString(dt.Rows[i]["WarehouseID"]));

                }
            }
            else if(listBox8.SelectedIndex == 1)
            {
                listBox7.Items.Clear();
                listBox7.Visible = true;
                label14.Text = "WH or BrID";
                DataTable dt = controllerObj.GetBrID();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox7.Items.Add(Convert.ToString(dt.Rows[i]["BranchID"]));

                }
            }
        }
    }
}
