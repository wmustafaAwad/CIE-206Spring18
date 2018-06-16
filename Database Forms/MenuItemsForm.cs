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
    public partial class MenuItemsForm : Form
    {
        public MenuItemsForm()
        {
            InitializeComponent();
        }

        Controller controllerObj = new Controller();
        private void MenuItemsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMenuItems();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i]["Name"].ToString());
                Boolean av = Boolean.Parse(controllerObj.GetAv(dt.Rows[i]["Name"].ToString()).ToString());
                listView1.Items[i].Checked = av;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMenuItemForm childform = new AddMenuItemForm();
            childform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItemIngredientForm childform = new AddItemIngredientForm();
            childform.textBox2.Text = listView1.SelectedItems[0].Text;
            DataTable dt =controllerObj.GetSupplyName();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                childform.listBox2.Items.Add(dt.Rows[i]["Name"].ToString());
            }
            childform.Show();
        }



 

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMenuItems();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i]["Name"].ToString());
                Boolean av = Boolean.Parse(controllerObj.GetAv(dt.Rows[i]["Name"].ToString()).ToString());
                listView1.Items[i].Checked = av;
            }
            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Dt = controllerObj.GetItemIDbyName(listView1.SelectedItems[0].Text);
            controllerObj.Edit_ItemAvailability(Int16.Parse(Dt.Rows[0]["ID"].ToString()));
            listView1.Clear();
            DataTable dt = controllerObj.GetMenuItems();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i]["Name"].ToString());
                Boolean av = Boolean.Parse(controllerObj.GetAv(dt.Rows[i]["Name"].ToString()).ToString());
                listView1.Items[i].Checked = av;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable Dt = controllerObj.GetItemIDbyName(listView1.SelectedItems[0].Text);
            DataTable Dt1 = controllerObj.View_ItemContents(Int16.Parse(Dt.Rows[0]["ID"].ToString()));
            ItemContentsForm childform = new ItemContentsForm();
            childform.dataGridView1.AutoGenerateColumns = true;
            childform.dataGridView1.DataSource = Dt1;
            childform.Show();
        }
    }
}
