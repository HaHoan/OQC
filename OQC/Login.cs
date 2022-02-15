using OQC.Business;
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
                    pass = pass.MD5Hash();
                    var user = db.Users.Where(m => m.Id == username && m.Password == pass).FirstOrDefault();
                    if (user == null)
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
                        return;
                    }
                    else
                    {
                        Properties.Settings.Default.Account = user.RoleId.ToString();
                        this.Hide();
                        FormMain main = new FormMain();
                        main.ShowDialog();
                        this.Close();

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
            if(e.KeyCode == Keys.Enter)
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
