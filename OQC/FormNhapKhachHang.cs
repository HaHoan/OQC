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
    public partial class FormNhapKhachHang : Form
    {
        public FormNhapKhachHang()
        {
            InitializeComponent();
            initCustomer();
        }

        public void initCustomer()
        {
            using (var db = new ClaimFormEntities())
            {
                var customers = db.Areas.ToList();
                foreach (var cus in customers)
                {
                    cbbCustomer.Items.Add(cus.Customer);
                }

            }
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var db = new ClaimFormEntities())
            {
                var user = db.Users.Where(m => m.Id == Properties.Settings.Default.Code).FirstOrDefault();
                user.Customer = cbbCustomer.Text;
                Properties.Settings.Default.Customer = cbbCustomer.Text;
                db.SaveChanges();
                Close();
            }
        }
    }
}
