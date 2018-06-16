namespace Database_Forms
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemByPopularityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.projectDataSet = new Database_Forms.ProjectDataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.SupplierTableAdapter();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.SupplyTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.EmployeeTableAdapter();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.BranchTableAdapter();
            this.branchHasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branch_HasTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.Branch_HasTableAdapter();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.WarehouseTableAdapter();
            this.worksAtBrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worksAtBrTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.WorksAtBrTableAdapter();
            this.worksAtWHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worksAtWHTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.WorksAtWHTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchHasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksAtBrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksAtWHBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Supplier",
            "Supply",
            "Employee",
            "Branch",
            "Warehouse",
            "WorksAt_Br",
            "WorksAt_WH"});
            this.listBox1.Location = new System.Drawing.Point(12, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 244);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tables:";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalIncomeToolStripMenuItem,
            this.suppliesToolStripMenuItem,
            this.activeCustomersToolStripMenuItem,
            this.itemByPopularityToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // totalIncomeToolStripMenuItem
            // 
            this.totalIncomeToolStripMenuItem.Name = "totalIncomeToolStripMenuItem";
            this.totalIncomeToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.totalIncomeToolStripMenuItem.Text = "Total Income ";
            this.totalIncomeToolStripMenuItem.Click += new System.EventHandler(this.totalIncomeToolStripMenuItem_Click);
            // 
            // suppliesToolStripMenuItem
            // 
            this.suppliesToolStripMenuItem.Name = "suppliesToolStripMenuItem";
            this.suppliesToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.suppliesToolStripMenuItem.Text = "Most Used Item";
            this.suppliesToolStripMenuItem.Click += new System.EventHandler(this.suppliesToolStripMenuItem_Click);
            // 
            // activeCustomersToolStripMenuItem
            // 
            this.activeCustomersToolStripMenuItem.Name = "activeCustomersToolStripMenuItem";
            this.activeCustomersToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.activeCustomersToolStripMenuItem.Text = "Active Customers";
            this.activeCustomersToolStripMenuItem.Click += new System.EventHandler(this.activeCustomersToolStripMenuItem_Click);
            // 
            // itemByPopularityToolStripMenuItem
            // 
            this.itemByPopularityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allItemsToolStripMenuItem,
            this.itemByNameToolStripMenuItem});
            this.itemByPopularityToolStripMenuItem.Name = "itemByPopularityToolStripMenuItem";
            this.itemByPopularityToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.itemByPopularityToolStripMenuItem.Text = "Item by Popularity";
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.allItemsToolStripMenuItem.Text = "All Items";
            this.allItemsToolStripMenuItem.Click += new System.EventHandler(this.allItemsToolStripMenuItem_Click);
            // 
            // itemByNameToolStripMenuItem
            // 
            this.itemByNameToolStripMenuItem.Name = "itemByNameToolStripMenuItem";
            this.itemByNameToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.itemByNameToolStripMenuItem.Text = "Item by Name";
            this.itemByNameToolStripMenuItem.Click += new System.EventHandler(this.itemByNameToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(36, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(329, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 77);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(188, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 77);
            this.button4.TabIndex = 9;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(470, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 77);
            this.button5.TabIndex = 8;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.projectDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.projectDataSet;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.projectDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // projectDataSetBindingSource1
            // 
            this.projectDataSetBindingSource1.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource1.Position = 0;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.projectDataSet;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // branchHasBindingSource
            // 
            this.branchHasBindingSource.DataMember = "Branch_Has";
            this.branchHasBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // branch_HasTableAdapter
            // 
            this.branch_HasTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.projectDataSet;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // worksAtBrBindingSource
            // 
            this.worksAtBrBindingSource.DataMember = "WorksAtBr";
            this.worksAtBrBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // worksAtBrTableAdapter
            // 
            this.worksAtBrTableAdapter.ClearBeforeFill = true;
            // 
            // worksAtWHBindingSource
            // 
            this.worksAtWHBindingSource.DataMember = "WorksAtWH";
            this.worksAtWHBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // worksAtWHTableAdapter
            // 
            this.worksAtWHTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 22);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "SpyID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(772, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 165);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Material Price";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchHasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksAtBrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksAtWHBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private ProjectDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private ProjectDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ProjectDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource1;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private ProjectDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.BindingSource branchHasBindingSource;
        private ProjectDataSetTableAdapters.Branch_HasTableAdapter branch_HasTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private ProjectDataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.BindingSource worksAtBrBindingSource;
        private ProjectDataSetTableAdapters.WorksAtBrTableAdapter worksAtBrTableAdapter;
        private System.Windows.Forms.BindingSource worksAtWHBindingSource;
        private ProjectDataSetTableAdapters.WorksAtWHTableAdapter worksAtWHTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem activeCustomersToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem itemByPopularityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}