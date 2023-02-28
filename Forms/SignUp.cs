using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAutomation.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        MarketAutomationEntities db = new MarketAutomationEntities();
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (db.Users.Where(u => u.username == TxUsername.Text).Count() > 0)
            {
                MessageBox.Show("Kullanıcı mevcut!");
            }
            else
            {
                if (TxUsername.Text != null && TxPassword.Text != null && TxUsername.Text != "" && TxPassword.Text != "")
                {
                    User newUser = new User();
                    newUser.username = TxUsername.Text;
                    newUser.password = TxPassword.Text;
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
            }
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }
    }
}
