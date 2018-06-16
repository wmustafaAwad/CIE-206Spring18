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
    public partial class ItemByNamePopularityForm : Form
    {
        public ItemByNamePopularityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            textBox2.Text=controllerObj.GetPopularity(textBox1.Text);
        }
    }
}
