using MarketAutomation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAutomation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MarketAutomationEntities db = new MarketAutomationEntities();   
        private void button1_Click(object sender, EventArgs e)
        {
            if (db.Users.Where(u => u.username == TxUsername.Text && u.password == TxPassword.Text).Count() > 0)
            {
                MessageBox.Show("Giriş başarılı");
                this.Hide();
                SalePage salePage = new SalePage(); 
                salePage.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
