using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

/* maillerin çıkış yapacağı mail adresimizin içerisinden, https://myaccount.google.com/lesssecureapps 
// ayalar içerisine girip "daha düşük güvenlikli uygulamalara bir seferlik izin vermek gerekiyor" */


namespace OdcTraining
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txt_kullAd.Text, txt_parola.Text);
            client = new SmtpClient(txt_smtp.Text);
            client.Port = Convert.ToInt32(txt_port.Text);
            client.EnableSsl = chck_ssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txt_kullAd.Text + txt_smtp.Text.Replace("smtp.", "@"), " ", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txt_alıcı.Text));
            if (!string.IsNullOrEmpty(txt_cc.Text))
                msg.To.Add(new MailAddress(txt_cc.Text));
            msg.Subject = txt_konu.Text;
            msg.Body = txt_mail.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendComplatedCallback);
            string userstate = "Gönderiliyor....";
            client.SendAsync(msg, userstate);
        }
        private static void SendComplatedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} gönderim iptal edildi", e.UserState), "Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mail başarıyla gönderildi", "Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
