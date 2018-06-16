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
    public partial class CashierPersonForm : Form
    {
        public CashierPersonForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        CashierCustomerForm Childform1 = new CashierCustomerForm();

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CashierAddCustomerForm ChildForm= new CashierAddCustomerForm();
           ChildForm.Show();
        }

        private void selectCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierCustomerForm ChildForm = new CashierCustomerForm();
            ChildForm.Show(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CashierPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetOID();
            int OID = Int16.Parse(dt.Rows[0]["OrderID"].ToString())+1;
            int n = controllerObj.AddOrder(2, Int16.Parse(textBox4.Text), Int16.Parse(textBox2.Text), double.Parse(textBox1.Text), Int16.Parse(textBox5.Text));
            
           
            if (n == 0)
            {
                MessageBox.Show("Insertion Failed");
            }
            else
            {
                MessageBox.Show("Insertion succeeded");
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                   DataTable dt1 = controllerObj.GetItemIDbyName(listBox1.GetItemText(listBox1.Items[i]));
                   string temp = dt1.Rows[0]["ID"].ToString();
                   controllerObj.AddOrder_Item(Convert.ToString(OID), temp,"1",textBox5.Text);
                }

            }
        }

        private void CashierPersonForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMenuItems();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                string temp = "button" + Convert.ToString(i+1);
                Control[] Array= this.Controls.Find(temp, true);
                Array[0].Text =dt.Rows[i]["Name"].ToString();
                Array[0].Visible = true;
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button1.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button1.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button23.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button23.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button22.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button22.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button21.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button21.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button20.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button20.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button19.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button19.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button18.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button18.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button17.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button17.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button16.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button16.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button15.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button15.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button14.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button14.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button13.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button13.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button12.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button12.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button11.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button11.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button10.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button10.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button9.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button9.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button8.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button8.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button7.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button7.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button6.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button6.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button5.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button5.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button4.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button4.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button3.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button3.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button2.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button2.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(button24.Text);
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.Add(button24.Text);
            textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) + buttonprice);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetPrice(listBox1.GetItemText(listBox1.SelectedItem));
            double buttonprice = double.Parse(dt.Rows[0]["Price"].ToString());
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            textBox1.Text = Convert.ToString((double.Parse(textBox1.Text) - buttonprice));
        }

        private void button25_Click(object sender, EventArgs e)
        {
           textBox2.Text = Controller.CID.ToString();
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderListForm childform =new OrderListForm();
            childform.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm childform = new UpdateCustomerForm();
            childform.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm childform = new ChangePasswordForm();
            childform.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    

