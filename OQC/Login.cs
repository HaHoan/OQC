using OQC.Business;
using OQC.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OQC
{
    public partial class Login : Form
    {
        private PVSWebServiceSoapClient pvsWebService = new PVSWebServiceSoapClient();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new ClaimFormEntities())
            {
                string username = txbUser.Text.Trim();
                string pass = txbPass.Text.Trim();
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pass))
                {
                    var user = pvsWebService.CheckUserLogin(username, pass);
                    if (user != null)
                    {
                        var roleUser = db.Users.Where(m => m.Id == username).FirstOrDefault();
                        if (roleUser != null && roleUser.RoleId is int roleId)
                        {
                            Properties.Settings.Default.Account = roleId;
                            Properties.Settings.Default.Customer = roleUser.Customer;
                        }
                        else
                        {
                            Properties.Settings.Default.Account = RoleName.OPERATOR;
                        }
                        Properties.Settings.Default.Code = user.ID;
                        Properties.Settings.Default.Name = user.NAME;
                        this.Hide();
                        FormMain main = new FormMain();
                        main.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Liên hệ với IT để thêm tài khoản!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Cần nhập tài khoản khi login!");
                }
            }
        }

        private void txbUser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbPass.Focus();
            }
        }

        private void txbPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
    }
}
