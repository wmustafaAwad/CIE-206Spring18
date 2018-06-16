namespace Database_Forms
{
    partial class OrderListForm
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
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTimeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new Database_Forms.ProjectDataSet();
            this.cust_OrderTableAdapter = new Database_Forms.ProjectDataSetTableAdapters.Cust_OrderTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.oTimeStampDataGridViewTextBoxColumn,
            this.oStatusIDDataGridViewTextBoxColumn,
            this.cashierIDDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.netPriceDataGridViewTextBoxColumn,
            this.servicePriceDataGridViewTextBoxColumn,
            this.taxPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.custOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oTimeStampDataGridViewTextBoxColumn
            // 
            this.oTimeStampDataGridViewTextBoxColumn.DataPropertyName = "OTimeStamp";
            this.oTimeStampDataGridViewTextBoxColumn.HeaderText = "OTimeStamp";
            this.oTimeStampDataGridViewTextBoxColumn.Name = "oTimeStampDataGridViewTextBoxColumn";
            this.oTimeStampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oStatusIDDataGridViewTextBoxColumn
            // 
            this.oStatusIDDataGridViewTextBoxColumn.DataPropertyName = "OStatusID";
            this.oStatusIDDataGridViewTextBoxColumn.HeaderText = "OStatusID";
            this.oStatusIDDataGridViewTextBoxColumn.Name = "oStatusIDDataGridViewTextBoxColumn";
            this.oStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashierIDDataGridViewTextBoxColumn
            // 
            this.cashierIDDataGridViewTextBoxColumn.DataPropertyName = "CashierID";
            this.cashierIDDataGridViewTextBoxColumn.HeaderText = "CashierID";
            this.cashierIDDataGridViewTextBoxColumn.Name = "cashierIDDataGridViewTextBoxColumn";
            this.cashierIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netPriceDataGridViewTextBoxColumn
            // 
            this.netPriceDataGridViewTextBoxColumn.DataPropertyName = "NetPrice";
            this.netPriceDataGridViewTextBoxColumn.HeaderText = "NetPrice";
            this.netPriceDataGridViewTextBoxColumn.Name = "netPriceDataGridViewTextBoxColumn";
            this.netPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicePriceDataGridViewTextBoxColumn
            // 
            this.servicePriceDataGridViewTextBoxColumn.DataPropertyName = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.HeaderText = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.Name = "servicePriceDataGridViewTextBoxColumn";
            this.servicePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxPriceDataGridViewTextBoxColumn
            // 
            this.taxPriceDataGridViewTextBoxColumn.DataPropertyName = "TaxPrice";
            this.taxPriceDataGridViewTextBoxColumn.HeaderText = "TaxPrice";
            this.taxPriceDataGridViewTextBoxColumn.Name = "taxPriceDataGridViewTextBoxColumn";
            this.taxPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custOrderBindingSource
            // 
            this.custOrderBindingSource.DataMember = "Cust_Order";
            this.custOrderBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cust_OrderTableAdapter
            // 
            this.cust_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order List:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(485, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Order Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(992, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Served",
            "Pending",
            "Cancelled"});
            this.listBox1.Location = new System.Drawing.Point(539, 359);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 20);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource custOrderBindingSource;
        private ProjectDataSetTableAdapters.Cust_OrderTableAdapter cust_OrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTimeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}