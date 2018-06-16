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
    public partial class ManagerForm : Form
    {
        Controller controllerObj = new Controller();
        public ManagerForm()
        {
            InitializeComponent();
        }





        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                SupplierInsertionForm childform = new SupplierInsertionForm();
                childform.Show();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                SupplyInsertionForm childform = new SupplyInsertionForm();
                childform.Show();
            }
            else if (listBox1.SelectedIndex == 2)
            {
                EmployeeInsertionForm childform = new EmployeeInsertionForm();
                childform.Show();
            }
            else if (listBox1.SelectedIndex == 3)
            {
                BranchInsertionForm childform = new BranchInsertionForm();
                childform.Show();
            }
            else if (listBox1.SelectedIndex == 4)
            {
                WarehouseInsertionForm childform = new WarehouseInsertionForm();
                childform.Show();
            }
            
        }

        private void totalIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalIncomeMenuStripForm childform = new TotalIncomeMenuStripForm();
            childform.Show();
        }

        private void suppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostUsedItemMenuStripForm childform = new MostUsedItemMenuStripForm();
            childform.Show();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.WorksAtWH' table. You can move, or remove it, as needed.
            this.worksAtWHTableAdapter.Fill(this.projectDataSet.WorksAtWH);
            // TODO: This line of code loads data into the 'projectDataSet.WorksAtBr' table. You can move, or remove it, as needed.
            this.worksAtBrTableAdapter.Fill(this.projectDataSet.WorksAtBr);
            // TODO: This line of code loads data into the 'projectDataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.projectDataSet.Warehouse);
            // TODO: This line of code loads data into the 'projectDataSet.Branch_Has' table. You can move, or remove it, as needed.
            this.branch_HasTableAdapter.Fill(this.projectDataSet.Branch_Has);
            // TODO: This line of code loads data into the 'projectDataSet.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.projectDataSet.Branch);
            // TODO: This line of code loads data into the 'projectDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.projectDataSet.Employee);
            // TODO: This line of code loads data into the 'projectDataSet.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.projectDataSet.Supply);
            // TODO: This line of code loads data into the 'projectDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.projectDataSet.Supplier);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.Supplier;
                dataGridView1.Refresh();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.Supply;
                dataGridView1.Refresh();
            }
            else if (listBox1.SelectedIndex == 2)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.Employee;
                dataGridView1.Refresh();
            }
            else if (listBox1.SelectedIndex == 3)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.Branch;
                dataGridView1.Refresh();
            }
            else if (listBox1.SelectedIndex == 4)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.Warehouse;
                dataGridView1.Refresh();
            }

            else if (listBox1.SelectedIndex == 5)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.WorksAtBr;
                dataGridView1.Refresh();
            }
            else if (listBox1.SelectedIndex == 6)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = projectDataSet.WorksAtWH;
                dataGridView1.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.WorksAtWH' table. You can move, or remove it, as needed.
            this.worksAtWHTableAdapter.Fill(this.projectDataSet.WorksAtWH);
            // TODO: This line of code loads data into the 'projectDataSet.WorksAtBr' table. You can move, or remove it, as needed.
            this.worksAtBrTableAdapter.Fill(this.projectDataSet.WorksAtBr);
            // TODO: This line of code loads data into the 'projectDataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.projectDataSet.Warehouse);
            // TODO: This line of code loads data into the 'projectDataSet.Branch_Has' table. You can move, or remove it, as needed.
            this.branch_HasTableAdapter.Fill(this.projectDataSet.Branch_Has);
            // TODO: This line of code loads data into the 'projectDataSet.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.projectDataSet.Branch);
            // TODO: This line of code loads data into the 'projectDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.projectDataSet.Employee);
            // TODO: This line of code loads data into the 'projectDataSet.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.projectDataSet.Supply);
            // TODO: This line of code loads data into the 'projectDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.projectDataSet.Supplier);
            dataGridView1.Refresh();
        }

        private void activeCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveCustomersForm childform = new ActiveCustomersForm();
            childform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj.UpdateRawMaterialPrice(Int16.Parse(textBox1.Text), Int16.Parse(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSearchForm childform = new EmployeeSearchForm();
            childform.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 2)
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    EmployeeUpdateForm childform = new EmployeeUpdateForm();
                    childform.Show();
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    childform.textBox1.Text = Convert.ToString(selectedRow.Cells["FName"].Value);
                    childform.textBox2.Text = Convert.ToString(selectedRow.Cells["MNames"].Value);
                    childform.textBox3.Text = Convert.ToString(selectedRow.Cells["LName"].Value);
                    childform.textBox4.Text = Convert.ToString(selectedRow.Cells["ID"].Value);
                    childform.textBox5.Text = Convert.ToString(selectedRow.Cells["NatID"].Value); ;
                    childform.textBox6.Text = Convert.ToString(selectedRow.Cells["Phone_Num"].Value);
                    childform.textBox7.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                    childform.textBox8.Text = Convert.ToString(selectedRow.Cells["BasicSalary"].Value);
                    childform.textBox9.Text = Convert.ToString(selectedRow.Cells["SupervisorID"].Value);
                    DataTable dt = controllerObj.GetWorksAt(Int16.Parse(childform.textBox4.Text));
                    string BranchID = Convert.ToString(dt.Rows[0]["BranchID"]);
                    string WarehouseID = Convert.ToString(dt.Rows[0]["WarehouseID"]);
                    if (WarehouseID != "")
                    {
                        childform.listBox6.SelectedIndex = 0;
                        childform.label14.Visible = true;
                        childform.label14.Text = "WHID";
                        childform.textBox19.Text = WarehouseID;
                        childform.textBox19.Visible = true;
                    }
                    else if (BranchID != "")
                    {
                        childform.listBox6.SelectedIndex = 1;
                        childform.label14.Visible = true;
                        childform.label14.Text = "BrID";
                        childform.textBox19.Text = BranchID;
                        childform.textBox19.Visible = true;
                    }

                        bool Gender = Convert.ToBoolean(selectedRow.Cells["Gender"].Value);
                    if (Gender == true)
                    {
                        childform.listBox1.SelectedIndex =1;
                    }
                    else
                    {
                        childform.listBox1.SelectedIndex = 0;
                    }
                    childform.listBox2.SelectedIndex = Int16.Parse(Convert.ToString(selectedRow.Cells["JobID"].Value))-1;
                    
                }

            }
          

        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsbyPopularityForm childform = new ItemsbyPopularityForm();
            childform.Show();
        }

        private void itemByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemByNamePopularityForm childform = new ItemByNamePopularityForm();
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
    

