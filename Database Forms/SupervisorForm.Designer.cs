namespace Database_Forms
{
    partial class SupervisorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.branchHasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new Database_Forms.ProjectDataSet();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.branch_HasTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.Branch_HasTableAdapter();
            this.branchGetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchGetsTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.BranchGetsTableAdapter();
            this.warehouseHasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseHasTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.WarehouseHasTableAdapter();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.SupplyTableAdapter();
            this.custOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cust_OrderTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.Cust_OrderTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchHasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseHasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrderBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Warehouse Supplier Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Branch Warehouse Transaction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(39, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Warehouse Supplier Transaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(39, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Branch Warehouse Transaction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(39, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "View Active Customers";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(869, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 347);
            this.dataGridView1.TabIndex = 6;
            // 
            // branchHasBindingSource
            // 
            this.branchHasBindingSource.DataMember = "Branch_Has";
            this.branchHasBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Branch_Has ",
            "BranchGets",
            "Warehouse_Has"});
            this.listBox1.Location = new System.Drawing.Point(16, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 346);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tables:";
            // 
            // branch_HasTableAdapter
            // 
            this.branch_HasTableAdapter.ClearBeforeFill = true;
            // 
            // branchGetsBindingSource
            // 
            this.branchGetsBindingSource.DataMember = "BranchGets";
            this.branchGetsBindingSource.DataSource = this.projectDataSet;
            // 
            // branchGetsTableAdapter
            // 
            this.branchGetsTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseHasBindingSource
            // 
            this.warehouseHasBindingSource.DataMember = "WarehouseHas";
            this.warehouseHasBindingSource.DataSource = this.projectDataSet;
            // 
            // warehouseHasTableAdapter
            // 
            this.warehouseHasTableAdapter.ClearBeforeFill = true;
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
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
            // custOrderBindingSource
            // 
            this.custOrderBindingSource.DataMember = "Cust_Order";
            this.custOrderBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // cust_OrderTableAdapter
            // 
            this.cust_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
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
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click_1);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // SupervisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1254, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SupervisorForm";
            this.Text = "SupervisorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupervisorForm_FormClosed);
            this.Load += new System.EventHandler(this.SupervisorForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchHasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseHasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrderBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource branchHasBindingSource;
        private ProjectDataSetTableAdapters.Branch_HasTableAdapter branch_HasTableAdapter;
        private System.Windows.Forms.BindingSource branchGetsBindingSource;
        private ProjectDataSetTableAdapters.BranchGetsTableAdapter branchGetsTableAdapter;
        private System.Windows.Forms.BindingSource warehouseHasBindingSource;
        private ProjectDataSetTableAdapters.WarehouseHasTableAdapter warehouseHasTableAdapter;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private ProjectDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.BindingSource custOrderBindingSource;
        private ProjectDataSetTableAdapters.Cust_OrderTableAdapter cust_OrderTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}