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

namespace MarketAutomation.Forms
{
    public partial class DebtPayment : Form
    {
        public DebtPayment()
        {
            InitializeComponent();
        }

        MarketAutomationEntities db = new MarketAutomationEntities();
        private void DebtPayment_Load(object sender, EventArgs e)
        {
            DG_Customers.DataSource = db.Customers.ToList();

            DG_Customers.Columns[1].HeaderText = "Müşteri Adı";
            DG_Customers.Columns[2].HeaderText = "Toplam Borç";
            DG_Customers.Columns[3].Visible = false;
        }

        private void TxSearch_TextChanged(object sender, EventArgs e)
        {
            DG_Customers.DataSource = db.Customers.Where(c => c.name.StartsWith(TxSearch.Text)).ToList();
        }

        private void BTN_DebtPayment_Click(object sender, EventArgs e)
        {

            Customer customer;
            var customerToUpdate = DG_Customers.SelectedRows[0].Cells["name"].Value;

            if (customerToUpdate != null)
            {
                customer = db.Customers.First(c => c.name == customerToUpdate.ToString());
                if (Convert.ToInt32(TxDebtPayment.Text) < customer.debt)
                {
                    customer.debt -= Convert.ToInt32(TxDebtPayment.Text);
                }
                else
                {
                    customer.debt = 0;
                }
                db.SaveChanges();
                MessageBox.Show("Müşteri borcu başarıyla ödendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductAdd productPage = new ProductAdd();
            productPage.Show();
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
            SalePage salePage = new SalePage();
            salePage.Show();
        }
    }
}
