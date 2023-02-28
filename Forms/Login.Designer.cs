namespace MarketAutomation
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxUsername = new System.Windows.Forms.TextBox();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxUsername
            // 
            this.TxUsername.Location = new System.Drawing.Point(103, 76);
            this.TxUsername.Name = "TxUsername";
            this.TxUsername.Size = new System.Drawing.Size(100, 20);
            this.TxUsername.TabIndex = 0;
            // 
            // TxPassword
            // 
            this.TxPassword.Location = new System.Drawing.Point(103, 134);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.Size = new System.Drawing.Size(100, 20);
            this.TxPassword.TabIndex = 1;
            this.TxPassword.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Location = new System.Drawing.Point(120, 176);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(66, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesabın yok mu? Hemen";
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignUp.Location = new System.Drawing.Point(175, 217);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(43, 13);
            this.SignUp.TabIndex = 7;
            this.SignUp.Text = "kayıt ol!";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(298, 267);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.TxUsername);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxUsername;
        private System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SignUp;
    }
}

