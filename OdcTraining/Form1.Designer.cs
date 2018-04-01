namespace OdcTraining
{
    partial class Form1
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
            this.btn_gonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_alıcı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.Ayarlar = new System.Windows.Forms.GroupBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_smtp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chck_ssl = new System.Windows.Forms.CheckBox();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ayarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(369, 57);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder.TabIndex = 5;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alıcı:";
            // 
            // txt_alıcı
            // 
            this.txt_alıcı.Location = new System.Drawing.Point(88, 19);
            this.txt_alıcı.Name = "txt_alıcı";
            this.txt_alıcı.Size = new System.Drawing.Size(578, 20);
            this.txt_alıcı.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(88, 135);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_mail.Size = new System.Drawing.Size(578, 186);
            this.txt_mail.TabIndex = 3;
            // 
            // Ayarlar
            // 
            this.Ayarlar.Controls.Add(this.chck_ssl);
            this.Ayarlar.Controls.Add(this.txt_smtp);
            this.Ayarlar.Controls.Add(this.label7);
            this.Ayarlar.Controls.Add(this.txt_port);
            this.Ayarlar.Controls.Add(this.label6);
            this.Ayarlar.Controls.Add(this.txt_parola);
            this.Ayarlar.Controls.Add(this.label2);
            this.Ayarlar.Controls.Add(this.btn_gonder);
            this.Ayarlar.Controls.Add(this.label5);
            this.Ayarlar.Controls.Add(this.txt_kullAd);
            this.Ayarlar.Location = new System.Drawing.Point(88, 327);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(578, 145);
            this.Ayarlar.TabIndex = 4;
            this.Ayarlar.TabStop = false;
            this.Ayarlar.Text = "groupBox1";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(89, 60);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '*';
            this.txt_parola.Size = new System.Drawing.Size(247, 20);
            this.txt_parola.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parola:";
            // 
            // txt_kullAd
            // 
            this.txt_kullAd.Location = new System.Drawing.Point(89, 21);
            this.txt_kullAd.Name = "txt_kullAd";
            this.txt_kullAd.Size = new System.Drawing.Size(247, 20);
            this.txt_kullAd.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(89, 97);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(49, 20);
            this.txt_port.TabIndex = 2;
            this.txt_port.Text = "587";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Port:";
            // 
            // txt_smtp
            // 
            this.txt_smtp.Location = new System.Drawing.Point(217, 100);
            this.txt_smtp.Name = "txt_smtp";
            this.txt_smtp.Size = new System.Drawing.Size(227, 20);
            this.txt_smtp.TabIndex = 4;
            this.txt_smtp.Text = "smtp.gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Smtp:";
            // 
            // chck_ssl
            // 
            this.chck_ssl.AutoSize = true;
            this.chck_ssl.Location = new System.Drawing.Point(369, 24);
            this.chck_ssl.Name = "chck_ssl";
            this.chck_ssl.Size = new System.Drawing.Size(46, 17);
            this.chck_ssl.TabIndex = 3;
            this.chck_ssl.Text = "SSL";
            this.chck_ssl.UseVisualStyleBackColor = true;
            // 
            // txt_konu
            // 
            this.txt_konu.Location = new System.Drawing.Point(88, 91);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(578, 20);
            this.txt_konu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Konu:";
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(88, 55);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(578, 20);
            this.txt_cc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cc:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 506);
            this.Controls.Add(this.txt_konu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ayarlar);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_alıcı);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderimi";
            this.Ayarlar.ResumeLayout(false);
            this.Ayarlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_alıcı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.GroupBox Ayarlar;
        private System.Windows.Forms.CheckBox chck_ssl;
        private System.Windows.Forms.TextBox txt_smtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kullAd;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Label label4;
    }
}

