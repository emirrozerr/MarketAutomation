namespace MarketAutomation.Forms
{
    partial class SignUp
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
            this.LoginLink = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.TxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginLink.Location = new System.Drawing.Point(183, 207);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(48, 13);
            this.LoginLink.TabIndex = 15;
            this.LoginLink.Text = "giriş yap.";
            this.LoginLink.Click += new System.EventHandler(this.LoginLink_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zaten hesabın var mı? Hemen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kayıt Ol";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSignUp.Location = new System.Drawing.Point(128, 166);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(66, 23);
            this.BtnSignUp.TabIndex = 10;
            this.BtnSignUp.Text = "Kayıt Ol";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // TxPassword
            // 
            this.TxPassword.Location = new System.Drawing.Point(111, 124);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.Size = new System.Drawing.Size(100, 20);
            this.TxPassword.TabIndex = 9;
            this.TxPassword.TabStop = false;
            // 
            // TxUsername
            // 
            this.TxUsername.Location = new System.Drawing.Point(111, 66);
            this.TxUsername.Name = "TxUsername";
            this.TxUsername.Size = new System.Drawing.Size(100, 20);
            this.TxUsername.TabIndex = 8;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(301, 262);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.TxUsername);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.TextBox TxUsername;
    }
}