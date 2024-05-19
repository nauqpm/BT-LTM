using System.Net;
using System.Net.Mail;

namespace Ex2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        SmtpClient smtpclient;
        string smtp_pass = "jhyncclcmqriubui";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            smtpclient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(txtUser.Text, txtPass.Text),
                EnableSsl = true
            };
            Ex2.Main ex2 = new Main(smtpclient, txtUser.Text);
            ex2.ShowDialog();
            this.Close();
        }
    }
}
