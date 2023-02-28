using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAutomation.Forms
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }
        MarketAutomationEntities db = new MarketAutomationEntities();
        private void Product_Load(object sender, EventArgs e)
        {
            DG_Product.DataSource = db.Products.ToList();
            DG_Product.Columns[1].HeaderText = "Ürün Adı";
            DG_Product.Columns[2].HeaderText = "Birim Fiyatı";
            DG_Product.Columns[3].HeaderText = "Barkod No.";
            DG_Product.Columns[4].HeaderText = "Stok Miktarı";
            DG_Product.Columns[5].Visible= false; DG_Product.Columns[6].Visible = false;
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt dosyaları|*.txt";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string file = openFileDialog.FileName;

                try
                {
                    string[] text = File.ReadAllLines(file);

                    //Read txt line by line
                    string productName = text[0];   
                    int barcodeNo = Convert.ToInt32(text[1]);
                    int unitPrice = Convert.ToInt32(text[2]);
                    int stock = Convert.ToInt32(text[3]);
                    int supplierId = Convert.ToInt32(text[4]);

                    string _salePrice = Interaction.InputBox("Ürünün satış fiyatını giriniz.", "Satış Fiyatı", "100");
                    int salePrice = Convert.ToInt32(_salePrice);

                    //Product add
                    Product product= new Product();
                    product.name=productName;
                    product.barcodeNo=barcodeNo;
                    product.unitPrice=salePrice;                
                    product.stock=stock;    
                    db.Products.Add(product);
                    db.SaveChanges();


                    //Transaction
                    StockTransaction transaction = new StockTransaction();
                    transaction.productId = db.Products.Where(p => p.name == productName).FirstOrDefault().Id;  //TODO: Product Id 1 setleniyor 
                    transaction.productUnitPrice= unitPrice;
                    transaction.productQuantity = stock;
                    transaction.supplierId = supplierId;
                    transaction.date= DateTime.Now;
                    db.StockTransactions.Add(transaction);

                    //Set supplier debt
                    Supplier supplier;
                    supplier = db.Suppliers.First(s => s.Id == supplierId);
                    supplier.debt = stock * unitPrice;

                    db.SaveChanges();
                    MessageBox.Show("Ürün ekleme başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DG_Product.DataSource = db.Products.ToList();  

                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya istenilen formatta değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Product product;

            var productNameToUpdate = DG_Product.SelectedRows[0].Cells["name"].Value;
            var productBarcodeNoToUpdate = DG_Product.SelectedRows[0].Cells["barcodeNo"].Value;

            if (productNameToUpdate != null)
            {
                product = db.Products.First(p => p.name == productNameToUpdate.ToString());

                product.name = TxName.Text == "" ? product.name : TxName.Text;
                product.barcodeNo = TxBarcodeNo.Text == "" ? product.barcodeNo : Convert.ToInt32(TxBarcodeNo.Text);
                product.unitPrice = TxPrice.Text == "" ? product.unitPrice : Convert.ToInt32(TxPrice.Text);
                product.stock = TxStock.Text == "" ? product.stock : Convert.ToInt32(TxStock.Text);
                
                db.SaveChanges();
                MessageBox.Show("Ürün güncelleme başarılı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DG_Product.Refresh();   
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxName.Text != null && TxName.Text != "")
            {
                DG_Product.DataSource = db.Products.Where(p => p.name.StartsWith(TxName.Text)).ToList();
            }
            else
            {
                DG_Product.DataSource = db.Products.ToList();   
            }
        }

        private void DG_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var row = e.RowIndex;    
        }
        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customerPage = new Customers();
            customerPage.Show();
        }


        private void Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalePage salePage= new SalePage();  
            salePage.Show();
        }

        private void DebtPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            DebtPayment debtPage = new DebtPayment();
            debtPage.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {

        }
    }
}
