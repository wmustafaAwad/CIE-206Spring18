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
    public partial class ItemsbyPopularityForm : Form
    {
        public ItemsbyPopularityForm()
        {
            InitializeComponent();
        }

        private void ItemsbyPopularityForm_Load(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = controllerObj.DisplayByPopularity();
            dataGridView1.Refresh();

        }
    }
}
