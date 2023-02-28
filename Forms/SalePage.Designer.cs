namespace MarketAutomation.Forms
{
    partial class SalePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DG_Basket = new System.Windows.Forms.DataGridView();
            this.DG_Customers = new System.Windows.Forms.DataGridView();
            this.SaleType = new System.Windows.Forms.ComboBox();
            this.Basket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarcodeNo = new System.Windows.Forms.TextBox();
            this.BTN_AddToBasket = new System.Windows.Forms.Button();
            this.BTN_Remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ConfirmSale = new System.Windows.Forms.Button();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductStock,
            this.Customer,
            this.DebtPayment,
            this.Sale,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 508);
            this.menuStrip1.TabIndex = 15;
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
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 100);
            this.toolStripMenuItem1.Text = "Rapor";
            // 
            // DG_Basket
            // 
            this.DG_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Basket.Location = new System.Drawing.Point(264, 49);
            this.DG_Basket.Name = "DG_Basket";
            this.DG_Basket.Size = new System.Drawing.Size(430, 151);
            this.DG_Basket.TabIndex = 16;
            // 
            // DG_Customers
            // 
            this.DG_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Customers.Location = new System.Drawing.Point(262, 300);
            this.DG_Customers.Name = "DG_Customers";
            this.DG_Customers.Size = new System.Drawing.Size(432, 155);
            this.DG_Customers.TabIndex = 17;
            // 
            // SaleType
            // 
            this.SaleType.AllowDrop = true;
            this.SaleType.FormattingEnabled = true;
            this.SaleType.Items.AddRange(new object[] {
            "Peşin",
            "Veresiye"});
            this.SaleType.Location = new System.Drawing.Point(122, 330);
            this.SaleType.Name = "SaleType";
            this.SaleType.Size = new System.Drawing.Size(136, 21);
            this.SaleType.TabIndex = 18;
            this.SaleType.TextChanged += new System.EventHandler(this.SaleType_TextChanged);
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basket.Location = new System.Drawing.Point(431, 21);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(86, 25);
            this.Basket.TabIndex = 19;
            this.Basket.Text = "SEPET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Barkod No";
            // 
            // BarcodeNo
            // 
            this.BarcodeNo.Location = new System.Drawing.Point(140, 76);
            this.BarcodeNo.Name = "BarcodeNo";
            this.BarcodeNo.Size = new System.Drawing.Size(100, 20);
            this.BarcodeNo.TabIndex = 21;
            // 
            // BTN_AddToBasket
            // 
            this.BTN_AddToBasket.BackColor = System.Drawing.Color.GreenYellow;
            this.BTN_AddToBasket.Location = new System.Drawing.Point(122, 114);
            this.BTN_AddToBasket.Name = "BTN_AddToBasket";
            this.BTN_AddToBasket.Size = new System.Drawing.Size(136, 23);
            this.BTN_AddToBasket.TabIndex = 22;
            this.BTN_AddToBasket.Text = "Sepete Ekle";
            this.BTN_AddToBasket.UseVisualStyleBackColor = false;
            this.BTN_AddToBasket.Click += new System.EventHandler(this.BTN_AddToBasket_Click);
            // 
            // BTN_Remove
            // 
            this.BTN_Remove.BackColor = System.Drawing.Color.IndianRed;
            this.BTN_Remove.Location = new System.Drawing.Point(122, 155);
            this.BTN_Remove.Name = "BTN_Remove";
            this.BTN_Remove.Size = new System.Drawing.Size(136, 23);
            this.BTN_Remove.TabIndex = 23;
            this.BTN_Remove.Text = "Sepetten Çıkar";
            this.BTN_Remove.UseVisualStyleBackColor = false;
            this.BTN_Remove.Click += new System.EventHandler(this.BTN_Remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Toplam Tutar: ";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(258, 276);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(0, 20);
            this.totalAmount.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ödeme Yöntemi";
            // 
            // BTN_ConfirmSale
            // 
            this.BTN_ConfirmSale.BackColor = System.Drawing.Color.GreenYellow;
            this.BTN_ConfirmSale.Location = new System.Drawing.Point(120, 369);
            this.BTN_ConfirmSale.Name = "BTN_ConfirmSale";
            this.BTN_ConfirmSale.Size = new System.Drawing.Size(136, 23);
            this.BTN_ConfirmSale.TabIndex = 27;
            this.BTN_ConfirmSale.Text = "Satışı Onayla";
            this.BTN_ConfirmSale.UseVisualStyleBackColor = false;
            this.BTN_ConfirmSale.Click += new System.EventHandler(this.BTN_ConfirmSale_Click);
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.Location = new System.Drawing.Point(396, 271);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(157, 25);
            this.labelCustomers.TabIndex = 28;
            this.labelCustomers.Text = "MÜŞTERİLER";
            // 
            // SalePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(695, 508);
            this.Controls.Add(this.labelCustomers);
            this.Controls.Add(this.BTN_ConfirmSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Remove);
            this.Controls.Add(this.BTN_AddToBasket);
            this.Controls.Add(this.BarcodeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.SaleType);
            this.Controls.Add(this.DG_Customers);
            this.Controls.Add(this.DG_Basket);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SalePage";
            this.Text = "SalePage";
            this.Load += new System.EventHandler(this.SalePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductStock;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem DebtPayment;
        private System.Windows.Forms.ToolStripMenuItem Sale;
        private System.Windows.Forms.DataGridView DG_Basket;
        private System.Windows.Forms.DataGridView DG_Customers;
        private System.Windows.Forms.Label Basket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarcodeNo;
        private System.Windows.Forms.Button BTN_AddToBasket;
        private System.Windows.Forms.Button BTN_Remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_ConfirmSale;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.ComboBox SaleType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}