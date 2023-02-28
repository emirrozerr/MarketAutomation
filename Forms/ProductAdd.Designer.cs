namespace MarketAutomation.Forms
{
    partial class ProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.DG_Product = new System.Windows.Forms.DataGridView();
            this.BtnStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxStock = new System.Windows.Forms.TextBox();
            this.TxPrice = new System.Windows.Forms.TextBox();
            this.TxBarcodeNo = new System.Windows.Forms.TextBox();
            this.TxName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_Product
            // 
            this.DG_Product.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DG_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Product.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DG_Product.Location = new System.Drawing.Point(122, 0);
            this.DG_Product.Name = "DG_Product";
            this.DG_Product.Size = new System.Drawing.Size(612, 227);
            this.DG_Product.TabIndex = 0;
            this.DG_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Product_CellContentClick);
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.Location = new System.Drawing.Point(125, 252);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(178, 31);
            this.BtnStock.TabIndex = 1;
            this.BtnStock.Text = "Ürün / Stok Ekle";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxStock);
            this.groupBox1.Controls.Add(this.TxPrice);
            this.groupBox1.Controls.Add(this.TxBarcodeNo);
            this.groupBox1.Controls.Add(this.TxName);
            this.groupBox1.Location = new System.Drawing.Point(324, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barkod No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // TxStock
            // 
            this.TxStock.Location = new System.Drawing.Point(206, 181);
            this.TxStock.Name = "TxStock";
            this.TxStock.Size = new System.Drawing.Size(151, 20);
            this.TxStock.TabIndex = 3;
            // 
            // TxPrice
            // 
            this.TxPrice.Location = new System.Drawing.Point(206, 134);
            this.TxPrice.Name = "TxPrice";
            this.TxPrice.Size = new System.Drawing.Size(151, 20);
            this.TxPrice.TabIndex = 2;
            // 
            // TxBarcodeNo
            // 
            this.TxBarcodeNo.Location = new System.Drawing.Point(206, 87);
            this.TxBarcodeNo.Name = "TxBarcodeNo";
            this.TxBarcodeNo.Size = new System.Drawing.Size(151, 20);
            this.TxBarcodeNo.TabIndex = 1;
            // 
            // TxName
            // 
            this.TxName.Location = new System.Drawing.Point(206, 40);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(151, 20);
            this.TxName.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(125, 322);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(178, 31);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Ürün Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(125, 392);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(178, 31);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Ürün Ara";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(737, 504);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.DG_Product);
            this.Name = "ProductAdd";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Product;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxStock;
        private System.Windows.Forms.TextBox TxPrice;
        private System.Windows.Forms.TextBox TxBarcodeNo;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductStock;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem DebtPayment;
        private System.Windows.Forms.ToolStripMenuItem Sale;
        private System.Windows.Forms.ToolStripMenuItem Report;
    }
}