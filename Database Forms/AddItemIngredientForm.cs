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
    public partial class AddItemIngredientForm : Form
    {
        public AddItemIngredientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            controllerObj.Add_Item_Ingredient(Int16.Parse(textBox2.Text), listBox2.SelectedIndex + 1, double.Parse(textBox1.Text));
        }
    }
}
