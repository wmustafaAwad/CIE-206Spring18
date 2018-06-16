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
    public partial class AddMenuItemForm : Form
    {
        public AddMenuItemForm()
        {
            InitializeComponent();
        }
        Controller controllerObj = new Controller();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetMaxIID();
            int ID = Int16.Parse(dt.Rows[0]["ID"].ToString())+1;
            controllerObj.AddMenu_Item(ID, textBox1.Text, Int16.Parse(textBox2.Text), listBox1.SelectedIndex + 1, true);
        }

        private void AddMenuItemForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetItemCategory();
            for(int i=0;i<dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i]["Descr"].ToString());
            }
        }
    }
}
