using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketAutomation.Forms
{
    public partial class SalePage : Form
    {
        public SalePage()
        {
            InitializeComponent();
        }
        MarketAutomationEntities db = new MarketAutomationEntities();
        DataTable dt = new DataTable();
        Int32? totalAmountCounter = 0;
        List<Product> products = new List<Product>();
        int productCounter = 0;



        private void SalePage_Load(object sender, EventArgs e)
        {
            //Sepet
            dt.Columns.Clear();
            dt.Columns.Add("Ürün Adı");
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Birim Fiyat");
            dt.Columns.Add("Stok");

            DG_Basket.DataSource = dt;
            totalAmount.Text = "0TL";

            DG_Customers.Visible = false;
            labelCustomers.Visible = false;

            SaleType.Text = "Ödeme yöntemi seçiniz.";
        }




        private void SaleType_TextChanged(object sender, EventArgs e)
        {
            if (SaleType.SelectedIndex < 0)
            {
                SaleType.Text = "Lütfen, bir değer seçin";
            }
            else
            {
                if (SaleType.SelectedIndex == 1)
                {
                    DG_Customers.Visible = true;
                    labelCustomers.Visible = true;
                    DG_Customers.DataSource = db.Customers.ToList();

                }
                else
                {
                    DG_Customers.Visible = false;
                    labelCustomers.Visible = false;
                }

                SaleType.Text = SaleType.SelectedText;


            }

        }

        private void BTN_AddToBasket_Click(object sender, EventArgs e)
        {

            try
            {
                Product product;
                Int32 TXbarcodeNo = Convert.ToInt32(BarcodeNo.Text);
                product = db.Products.First(p => p.barcodeNo == TXbarcodeNo);
                DataRow row = dt.NewRow();
                row["Ürün Adı"] = product.name;
                row["Barkod No"] = product.barcodeNo;
                row["Birim Fiyat"] = product.unitPrice;
                row["Stok"] = product.stock;

                dt.Rows.Add(row);
                DG_Basket.DataSource = dt;

                products.Add(product);  
                totalAmountCounter += product.unitPrice;
                totalAmount.Text = totalAmountCounter.ToString() + "TL";
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz barkod numarasına ait bir ürün bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {

            try
            {
                var selectedRowIndex = DG_Basket.SelectedRows[0].Index;
                DataRow rowToDelete = dt.Rows[selectedRowIndex];

                totalAmountCounter -= Convert.ToInt32(rowToDelete.Field<String>("Birim Fiyat"));  //Seçili satırın birim fiyatını getirir
                totalAmount.Text = totalAmountCounter.ToString() + "TL";

                String pName = rowToDelete.Field<String>("Ürün Adı");

                Product productToRemove = products.Find(p => p.name == pName);
                if (productToRemove != null) { products.Remove(productToRemove); }

                dt.Rows.Remove(rowToDelete);
            }
            catch (Exception)
            {
                MessageBox.Show("Sepetten ürün çıkarmak için tüm satırı seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTN_ConfirmSale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            Product product;
            foreach (Product _product in products)


            {
                product = db.Products.First(p => p.name == _product.name);
                sale.productId = product.Id;
                sale.salePrice = product.unitPrice;
                if (product != null)
                {
                    product.stock -= 1;
                }
            }


            if (SaleType.SelectedIndex == 1)
            {

                Customer customer;
                var customerToSelect = DG_Customers.SelectedRows[0].Cells["name"].Value;

                if (customerToSelect != null)
                {
                    customer = db.Customers.First(c => c.name == customerToSelect.ToString());
                    customer.debt = totalAmountCounter;

                    
                    sale.customerId = customer.Id;
                    sale.quantity = 1;
                    sale.saleType = "Veresiye";
                    
                    sale.date = DateTime.Now;
                    db.Sales.Add(sale);

                    db.SaveChanges();

                    DG_Customers.DataSource = db.Customers.ToList();
                    MessageBox.Show("Veresiye satışı başarıyla tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                db.SaveChanges();
                MessageBox.Show("Peşin satış başarıyla tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }

        //Menü buttons
        private void ProductStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductAdd productPage = new ProductAdd();
            productPage.Show();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customerPage= new Customers();
            customerPage.Show();
        }

        private void DebtPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            DebtPayment debtPage = new DebtPayment();   
            debtPage.Show();    
        }
    }
}
