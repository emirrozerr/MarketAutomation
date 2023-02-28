namespace MarketAutomation.Forms
{
    partial class DebtPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtPayment));
            this.DG_Customers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_DebtPayment = new System.Windows.Forms.Button();
            this.TxDebtPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_Customers
            // 
            this.DG_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Customers.Location = new System.Drawing.Point(122, 12);
            this.DG_Customers.Name = "DG_Customers";
            this.DG_Customers.Size = new System.Drawing.Size(432, 216);
            this.DG_Customers.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxSearch);
            this.groupBox2.Location = new System.Drawing.Point(122, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 81);
            this.groupBox2.TabIndex = 19;
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
            // TxSearch
            // 
            this.TxSearch.Location = new System.Drawing.Point(70, 37);
            this.TxSearch.Name = "TxSearch";
            this.TxSearch.Size = new System.Drawing.Size(169, 20);
            this.TxSearch.TabIndex = 4;
            this.TxSearch.TextChanged += new System.EventHandler(this.TxSearch_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductStock,
            this.Customer,
            this.toolStripMenuItem1,
            this.Sale,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 504);
            this.menuStrip1.TabIndex = 20;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 100);
            this.toolStripMenuItem1.Text = "Borç Ödeme";
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 100);
            this.toolStripMenuItem2.Text = "Rapor";
            // 
            // BTN_DebtPayment
            // 
            this.BTN_DebtPayment.Location = new System.Drawing.Point(596, 132);
            this.BTN_DebtPayment.Name = "BTN_DebtPayment";
            this.BTN_DebtPayment.Size = new System.Drawing.Size(162, 31);
            this.BTN_DebtPayment.TabIndex = 21;
            this.BTN_DebtPayment.Text = "Borç Öde";
            this.BTN_DebtPayment.UseVisualStyleBackColor = true;
            this.BTN_DebtPayment.Click += new System.EventHandler(this.BTN_DebtPayment_Click);
            // 
            // TxDebtPayment
            // 
            this.TxDebtPayment.Location = new System.Drawing.Point(623, 106);
            this.TxDebtPayment.Name = "TxDebtPayment";
            this.TxDebtPayment.Size = new System.Drawing.Size(100, 20);
            this.TxDebtPayment.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "TL";
            // 
            // DebtPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxDebtPayment);
            this.Controls.Add(this.BTN_DebtPayment);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DG_Customers);
            this.Name = "DebtPayment";
            this.Text = "<7";
            this.Load += new System.EventHandler(this.DebtPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Customers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductStock;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Sale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button BTN_DebtPayment;
        private System.Windows.Forms.TextBox TxDebtPayment;
        private System.Windows.Forms.Label label1;
    }
}