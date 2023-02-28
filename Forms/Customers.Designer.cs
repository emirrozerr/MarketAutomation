namespace MarketAutomation.Forms
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNSaveCustomer = new System.Windows.Forms.Button();
            this.BTNDeleteCustomer = new System.Windows.Forms.Button();
            this.DG_Customers = new System.Windows.Forms.DataGridView();
            this.TxSearch = new System.Windows.Forms.TextBox();
            this.TxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTNRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(19, 87);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(163, 29);
            this.BTNUpdate.TabIndex = 0;
            this.BTNUpdate.Text = "Müşteri Güncelle";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNSaveCustomer
            // 
            this.BTNSaveCustomer.Location = new System.Drawing.Point(19, 22);
            this.BTNSaveCustomer.Name = "BTNSaveCustomer";
            this.BTNSaveCustomer.Size = new System.Drawing.Size(163, 29);
            this.BTNSaveCustomer.TabIndex = 1;
            this.BTNSaveCustomer.Text = "Müşteri Ekle";
            this.BTNSaveCustomer.UseVisualStyleBackColor = true;
            this.BTNSaveCustomer.Click += new System.EventHandler(this.BTNSaveCustomer_Click);
            // 
            // BTNDeleteCustomer
            // 
            this.BTNDeleteCustomer.Location = new System.Drawing.Point(19, 152);
            this.BTNDeleteCustomer.Name = "BTNDeleteCustomer";
            this.BTNDeleteCustomer.Size = new System.Drawing.Size(163, 29);
            this.BTNDeleteCustomer.TabIndex = 2;
            this.BTNDeleteCustomer.Text = "Müşteri Sil";
            this.BTNDeleteCustomer.UseVisualStyleBackColor = true;
            this.BTNDeleteCustomer.Click += new System.EventHandler(this.BTNDeleteCustomer_Click);
            // 
            // DG_Customers
            // 
            this.DG_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Customers.Location = new System.Drawing.Point(119, 0);
            this.DG_Customers.Name = "DG_Customers";
            this.DG_Customers.Size = new System.Drawing.Size(530, 237);
            this.DG_Customers.TabIndex = 3;
            // 
            // TxSearch
            // 
            this.TxSearch.Location = new System.Drawing.Point(73, 39);
            this.TxSearch.Name = "TxSearch";
            this.TxSearch.Size = new System.Drawing.Size(169, 20);
            this.TxSearch.TabIndex = 4;
            this.TxSearch.TextChanged += new System.EventHandler(this.TxSearch_TextChanged);
            // 
            // TxName
            // 
            this.TxName.Location = new System.Drawing.Point(119, 112);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(100, 20);
            this.TxName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Müşteri Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxName);
            this.groupBox1.Location = new System.Drawing.Point(344, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 245);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxSearch);
            this.groupBox2.Location = new System.Drawing.Point(0, -16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 81);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri Ara";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.BTNSaveCustomer);
            this.groupBox3.Controls.Add(this.BTNUpdate);
            this.groupBox3.Controls.Add(this.BTNDeleteCustomer);
            this.groupBox3.Location = new System.Drawing.Point(119, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 245);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // BTNRefresh
            // 
            this.BTNRefresh.BackColor = System.Drawing.Color.White;
            this.BTNRefresh.Location = new System.Drawing.Point(563, 198);
            this.BTNRefresh.Name = "BTNRefresh";
            this.BTNRefresh.Size = new System.Drawing.Size(75, 23);
            this.BTNRefresh.TabIndex = 13;
            this.BTNRefresh.Text = "Yenile";
            this.BTNRefresh.UseVisualStyleBackColor = false;
            this.BTNRefresh.Click += new System.EventHandler(this.BTNRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductStock,
            this.Customer,
            this.DebtPayment,
            this.Sale,
            this.Report});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 504);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductStock
            // 
            this.ProductStock.AutoSize = false;
            this.ProductStock.Image = ((System.Drawing.Image)(resources.GetObject("ProductStock.Image")));
            this.ProductStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductStock.Name = "ProductStock";
            this.ProductStock.Size = new System.Drawing.Size(113, 100);
            this.ProductStock.Text = "Ürün/Stok";
            this.ProductStock.Click += new System.EventHandler(this.ProductStock_Click);
            // 
            // Customer
            // 
            this.Customer.AutoSize = false;
            this.Customer.Image = ((System.Drawing.Image)(resources.GetObject("Customer.Image")));
            this.Customer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(113, 100);
            this.Customer.Text = "Müşteri";
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // DebtPayment
            // 
            this.DebtPayment.AutoSize = false;
            this.DebtPayment.Image = ((System.Drawing.Image)(resources.GetObject("DebtPayment.Image")));
            this.DebtPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DebtPayment.Name = "DebtPayment";
            this.DebtPayment.Size = new System.Drawing.Size(113, 100);
            this.DebtPayment.Text = "Borç Ödeme";
            this.DebtPayment.Click += new System.EventHandler(this.DebtPayment_Click);
            // 
            // Sale
            // 
            this.Sale.AutoSize = false;
            this.Sale.Image = ((System.Drawing.Image)(resources.GetObject("Sale.Image")));
            this.Sale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(113, 100);
            this.Sale.Text = "Satış";
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // Report
            // 
            this.Report.AutoSize = false;
            this.Report.Image = ((System.Drawing.Image)(resources.GetObject("Report.Image")));
            this.Report.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(113, 100);
            this.Report.Text = "Rapor";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(650, 504);
            this.Controls.Add(this.BTNRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_Customers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Customers";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNSaveCustomer;
        private System.Windows.Forms.Button BTNDeleteCustomer;
        private System.Windows.Forms.DataGridView DG_Customers;
        private System.Windows.Forms.TextBox TxSearch;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTNRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Sale;
        private System.Windows.Forms.ToolStripMenuItem ProductStock;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem DebtPayment;
        private System.Windows.Forms.ToolStripMenuItem Report;
    }
}