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
    public partial class Main : Form
    {
        public string[] customers = new string[]
        {
            Customers.CANON,
            Customers.HLDS,
            Customers.FUJIXEROX,
            Customers.SCHNEIDER,
            Customers.KYOCERA,
            Customers.FORMLABS,
            Customers.DIGITAL,
            Customers.TOYODENSO,
            Customers.YOKOWO,
            Customers.NIHON,
            Customers.HONDALOCK,
            Customers.STANDLEY,
            Customers.VALEO,
            Customers.ICHIKOH,
            Customers.BROTHER,
            Customers.NICHICON
        };
        public Main()
        {
            InitializeComponent();
            lblStatus.Text = "";
            foreach (var cus in customers)
            {
                cbbCustomer.Items.Add(cus);
            }
            GetListODIs();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                using (var db = new ClaimFormEntities())
                {
                    string station = "";
                    if (rbStationOQC1.Checked)
                    {
                        station = OQC.Station.OQC1;
                    }
                    else if (rbStationOQC2.Checked)
                    {
                        station = OQC.Station.OQC2;
                    }
                    else if (rbStationCSL.Checked)
                    {
                        station = OQC.Station.CSL;
                    }
                    var ODI = new ODI()
                    {
                        DateOccur = dtpDateOccur.Value.Date,
                        Customer = cbbCustomer.Text,
                        Shift = rbShiftDay.Checked ? OQC.Shift.DAY : OQC.Shift.NIGHT,
                        Station = station,
                        Inspector = txbInspector.Text,
                        GroupModel = txbGroupModel.Text,
                        ModelName = txbModelName.Text,
                        WO = txbWO.Text,
                        WOQty = txbWOQty.Text,
                        CheckNumber = int.Parse(txbNumerCheck.Text),
                        NumberNG = int.Parse(txbNumberNG.Text),
                        Note = txbNote.Text
                    };
                    db.ODIs.Add(ODI);
                    db.SaveChanges();
                    GetListODIs();
                }
            }
        }
        private bool ValidateEntry()
        {
            if (string.IsNullOrEmpty(cbbCustomer.Text))
            {
                cbbCustomer.Focus();
                lblStatus.Text = "Chưa chọn customer";
                return false;
            }
            if (!rbShiftDay.Checked && !rbShiftNight.Checked)
            {
                lblStatus.Text = "Chưa chọn shift";
                return false;
            }
            if (!rbStationOQC1.Checked && !rbStationOQC2.Checked && !rbStationCSL.Checked)
            {
                lblStatus.Text = "Chưa chọn station";
                return false;
            }
            if (string.IsNullOrEmpty(txbInspector.Text))
            {
                lblStatus.Text = "Chưa chọn Inspector";
                txbInspector.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbGroupModel.Text))
            {
                lblStatus.Text = "Chưa chọn Group Model";
                txbGroupModel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbModelName.Text))
            {
                lblStatus.Text = "Chưa chọn Model Name";
                txbModelName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbWO.Text))
            {
                lblStatus.Text = "Chưa chọn WO";
                txbWO.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbWOQty.Text))
            {
                lblStatus.Text = "Chưa chọn số lượng WO";
                txbWOQty.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbNumerCheck.Text))
            {
                lblStatus.Text = "Chưa chọn số lượng kiểm";
                txbNumerCheck.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbNumberNG.Text))
            {
                lblStatus.Text = "Chưa chọn số lượng lỗi";
                txbNumberNG.Focus();
                return false;
            }

            return true;
        }

        private void cbbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void txbInspector_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void txbModelName_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void txbWO_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void txbWOQty_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void txbNumerCheck_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void txbNumberNG_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void dtpDateOccur_ValueChanged(object sender, EventArgs e)
        {
            GetListODIs();
        }
        private void GetListODIs()
        {
            using (var db = new ClaimFormEntities())
            {
                dtgvListODI.DataSource = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date).ToList();
                dtgvListODI.Refresh();
            }
        }

        private void OnlyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
