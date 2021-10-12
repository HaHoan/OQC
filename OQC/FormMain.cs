using OQC.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace OQC
{
    public partial class FormMain : Form
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
        List<TypeNG> listNG = new List<TypeNG>();
        public string[] areas = new string[]
        {
            Areas.AUTO,
            Areas.ID,
            Areas.PICKUP,
            Areas.OA
        };
        private string sql = "select  [ID] ,[DateOccur]  ,[Customer] ,[Area],[Shift],[Station],[Inspector],[GroupModel],[ModelName] ,[WO] ,[WOQty],[CheckNumber],[NumberNG] ,[Occur_Time] ,[Occur_Line] ,[Serial_Number] ,[Position],[Defection],[Sample_Form] from ODI";
        private BindingSource odiDataSource = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public FormMain()
        {
            InitializeComponent();
            lblStatus.Text = "";
            foreach (var cus in customers)
            {
                cbbCustomer.Items.Add(cus);
            }
            foreach (var area in areas)
            {
                cbbAreas.Items.Add(area);
            }
            using (var db = new ClaimFormEntities())
            {
                listNG = db.TypeNGs.ToList();
                foreach (var ng in listNG)
                {
                    cbbTypeNG.Items.Add(ng.TypeNG1);
                }
            }
            odiDataSource.ListChanged += OdiDataSource_ListChanged;
            GetTotal();
            this.ActiveControl = txbDateOccur;
        }

        private void OdiDataSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            lblNumberRow.Text = string.Format("{0} Rows", this.odiDataSource.List.Count);
        }

        private bool ValidateEntry()
        {
            if (string.IsNullOrEmpty(txbDateOccur.Text))
            {
                btnDateOccur.Focus();
                lblStatus.Text = "Chưa Chọn Ngày Phát Sinh Lỗi";
                return false;
            }
            if (string.IsNullOrEmpty(cbbAreas.Text))
            {
                cbbAreas.Focus();
                lblStatus.Text = "Chưa chọn khu vực";
                return false;
            }
            if (string.IsNullOrEmpty(cbbCustomer.Text))
            {
                cbbCustomer.Focus();
                lblStatus.Text = "Chưa chọn khách hàng";
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
            if(!rb100Per.Checked && !rbAQL.Checked && !rb50Per.Checked){
                lblStatus.Text = "Chưa chọn hình thức lấy mẫu";
                return false;
            }
            if (string.IsNullOrEmpty(txbInspector.Text))
            {
                lblStatus.Text = "Chưa nhập Inspector";
                txbInspector.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbGroupModel.Text))
            {
                lblStatus.Text = "Chưa nhập Group Model";
                txbGroupModel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbModelName.Text))
            {
                lblStatus.Text = "Chưa nhập Model Name";
                txbModelName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbWO.Text))
            {
                lblStatus.Text = "Chưa nhập WO";
                txbWO.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbWOQty.Text))
            {
                lblStatus.Text = "Chưa nhập số lượng WO";
                txbWOQty.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbNumerCheck.Text))
            {
                lblStatus.Text = "Chưa nhập số lượng kiểm";
                txbNumerCheck.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbNumberNG.Text))
            {
                lblStatus.Text = "Chưa nhập số lượng lỗi";
                txbNumberNG.Focus();
                return false;
            }
            if (int.Parse(txbNumberNG.Text.Trim()) == 0)
            {
                return true;
            }
            if (string.IsNullOrEmpty(dtpDateOccur.Text))
            {
                lblStatus.Text = "Chưa chọn thời gian phát sinh lỗi";
                txbNumberNG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbLine.Text))
            {
                lblStatus.Text = "Chưa nhập line phát sinh lỗi";
                txbNumberNG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbSerial.Text))
            {
                lblStatus.Text = "Chưa nhập số serial lỗi";
                txbNumberNG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbPosition.Text))
            {
                lblStatus.Text = "Chưa nhập vị trí lỗi";
                txbNumberNG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbTypeNG.Text))
            {
                lblStatus.Text = "Chưa chọn loại lỗi";
                txbNumberNG.Focus();
                return false;
            }
            var ng = listNG.Where(m => m.TypeNG1 == cbbTypeNG.Text.Trim()).FirstOrDefault();
            if (string.IsNullOrEmpty(txbNGDetail.Text) && ng != null && ng.ID == 36)
            {
                lblStatus.Text = "Chưa nhập mô tả lỗi";
                txbNumberNG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NG_Photo))
            {

                lblStatus.Text = "Chưa chọn hình ảnh lỗi";
                btnAddNG.Focus();
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

            dpFrom.Value = dtpDateOccur.Value;
            dpTo.Value = dtpDateOccur.Value;
            txbDateOccur.Text = dtpDateOccur.Value.ToString("dd/MM/yyy");
            compareDate();
            GetTotal();
        }

        private void GetTotal()
        {
            try
            {
                using (var db = new ClaimFormEntities())
                {
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date).Sum(m => m.CheckNumber);
                    var totalNG = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date).Sum(m => m.NumberNG);
                    lblTotalCheck.Text = totalCheck.ToString();
                    lblNG.Text = totalNG.ToString();
                    if (totalCheck != 0)
                    {
                        var ppm1 = ((float)totalNG * 1000000 / totalCheck);
                        double ppm = Math.Round(ppm1, 1);
                        lblPPM.Text = ppm.ToString();
                    }
                }
            }
            catch (Exception)
            {
                lblTotalCheck.Text = "0";
                lblNG.Text = "0";
                lblPPM.Text = "0";

            }

        }
        private void GetListODIs()
        {
            GetData(dataAdapter.SelectCommand.CommandText);
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

        string NG_Photo = "";
        string OK_Photo = "";
        private void btnAddNG_Click(object sender, EventArgs e)
        {

            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.FilterIndex = 1;
            choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                NG_Photo = Guid.NewGuid().ToString() + Path.GetFileName(choofdlog.FileName);
                pbNG.Image = new Bitmap(choofdlog.FileName);
                Utils.UploadFile("172.28.10.17", @"VN\U34811", "umcvn", choofdlog.FileName, @"\OQC\" + NG_Photo);
            }
        }

        private void btnAddOK_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.FilterIndex = 1;
            choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                OK_Photo = Guid.NewGuid().ToString() + Path.GetFileName(choofdlog.FileName);
                pbOK.Image = new Bitmap(choofdlog.FileName);
                Utils.UploadFile("172.28.10.17", @"VN\U34811", "umcvn", choofdlog.FileName, @"\OQC\" + OK_Photo);
            }
        }

        private void btnSaveODI_Click(object sender, EventArgs e)
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
                    string sampleForm = "";
                    if (rb100Per.Checked)
                    {
                        sampleForm = OQC.SampleForm.SF100PER;
                    }else if (rb50Per.Checked)
                    {
                        sampleForm = SampleForm.SF50PER;
                    }else if (rbAQL.Checked)
                    {
                        sampleForm = SampleForm.SFAQL;
                    }
                    string shift = rbShiftDay.Checked ? OQC.Shift.DAY : OQC.Shift.NIGHT;
                    var ODI = db.ODIs.Where(m => m.ID == IDODI).FirstOrDefault();
                    DateTime dateOccur = DateTime.Now;
                    try
                    {
                        dateOccur = DateTime.ParseExact(txbDateOccur.Text.Trim(), "dd/MM/yyyy", null);
                    }
                    catch
                    {
                        MessageBox.Show("Xem lại định dạng ngày!");
                        txbDateOccur.Focus();
                        return;
                    }

                    if (ODI != null)
                    {
                        ODI.DateOccur = dateOccur;
                        ODI.Area = cbbAreas.Text;
                        ODI.Customer = cbbCustomer.Text;
                        ODI.Shift = shift;
                        ODI.Station = station;
                        ODI.Inspector = txbInspector.Text;
                        ODI.GroupModel = txbGroupModel.Text;
                        ODI.ModelName = txbModelName.Text;
                        ODI.WO = txbWO.Text;
                        ODI.WOQty = txbWOQty.Text;
                        ODI.CheckNumber = int.Parse(txbNumerCheck.Text);
                        ODI.NumberNG = int.Parse(txbNumberNG.Text);
                        ODI.Note = txbNote.Text;
                        ODI.Occur_Time = dtpTimeOccur.Value.ToShortTimeString();
                        ODI.Occur_Line = txbLine.Text;
                        ODI.Serial_Number = txbSerial.Text;
                        ODI.Position = txbPosition.Text;
                        ODI.Defection = cbbTypeNG.Text;
                        ODI.Detail = txbNGDetail.Text;
                        ODI.NG_Photo = NG_Photo;
                        ODI.OK_Photo = OK_Photo;
                        ODI.Sample_Form = sampleForm;
                    }
                    else
                    {
                        ODI = new ODI()
                        {
                            DateOccur = dtpDateOccur.Value.Date,
                            Area = cbbAreas.Text,
                            Customer = cbbCustomer.Text,
                            Shift = shift,
                            Station = station,
                            Inspector = txbInspector.Text,
                            GroupModel = txbGroupModel.Text,
                            ModelName = txbModelName.Text,
                            WO = txbWO.Text,
                            WOQty = txbWOQty.Text,
                            CheckNumber = int.Parse(txbNumerCheck.Text),
                            NumberNG = int.Parse(txbNumberNG.Text),
                            Note = txbNote.Text,
                            Occur_Time = dtpTimeOccur.Value.ToShortTimeString(),
                            Occur_Line = txbLine.Text,
                            Serial_Number = txbSerial.Text,
                            Position = txbPosition.Text,
                            Defection = cbbTypeNG.Text,
                            Detail = txbNGDetail.Text,
                            NG_Photo = NG_Photo,
                            OK_Photo = OK_Photo,
                            Sample_Form = sampleForm
                    };
                        db.ODIs.Add(ODI);
                    }

                    db.SaveChanges();
                    GetListODIs();
                    if (((Button)sender).Name == "btnSaveODI")
                    {
                        ResetDataKeepInspector();
                    }
                    else
                    {
                        ResetData();
                    }

                }
            }
        }

        private void ResetDataKeepInspector()
        {

            txbGroupModel.Text = "";
            txbModelName.Text = "";
            txbWO.Text = "";
            txbWOQty.Text = "";
            txbNumerCheck.Text = "";
            txbNumberNG.Text = "";
            txbNote.Text = "";
            dtpTimeOccur.Value = DateTime.Now;
            txbLine.Text = "";
            txbSerial.Text = "";
            txbPosition.Text = "";
            cbbTypeNG.Text = "";
            txbNGDetail.Text = "";
            NG_Photo = "";
            OK_Photo = "";
            pbNG.Image = null;
            pbOK.Image = null;
            txbGroupModel.Focus();
            btnSaveODI.Text = "SUBMIT";
            btnSubmitNext.Text = "SUBMIT/NEXT";
            IDODI = 0;
            lblStatus.Text = "";
        }

        int IDODI = 0;

        private void ResetData()
        {
            txbDateOccur.Text = "";
            cbbAreas.Text = "";
            cbbCustomer.Text = "";
            rbShiftDay.Checked = false;
            rbShiftNight.Checked = false;
            rbStationOQC1.Checked = false;
            rbStationOQC2.Checked = false;
            rbStationCSL.Checked = false;
            txbInspector.Text = "";
            txbGroupModel.Text = "";
            txbModelName.Text = "";
            txbWO.Text = "";
            txbWOQty.Text = "";
            txbNumerCheck.Text = "";
            txbNumberNG.Text = "";
            txbNote.Text = "";
            dtpTimeOccur.Value = DateTime.Now;
            txbLine.Text = "";
            txbSerial.Text = "";
            txbPosition.Text = "";
            cbbTypeNG.Text = "";
            txbNGDetail.Text = "";
            NG_Photo = "";
            OK_Photo = "";
            pbNG.Image = null;
            pbOK.Image = null;
            txbInspector.Focus();
            btnSaveODI.Text = "SUBMIT";
            btnSubmitNext.Text = "SUBMIT/NEXT";
            IDODI = 0;
            lblStatus.Text = "";
        }
        private void txbInspector_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbGroupModel.SelectAll();
                txbGroupModel.Focus();
                GetTotalByOP();
            }
        }
        private void GetTotalByOP()
        {
            try
            {
                using (var db = new ClaimFormEntities())
                {
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Inspector == txbInspector.Text.Trim()).Sum(m => m.CheckNumber);
                    lblOP.Text = totalCheck.ToString();
                }
            }
            catch (Exception)
            {
                lblOP.Text = "0";
            }
        }
        private void GetTotalByGroup()
        {
            try
            {
                using (var db = new ClaimFormEntities())
                {
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.GroupModel == txbGroupModel.Text.Trim()).Sum(m => m.CheckNumber);

                    lblGroup.Text = totalCheck.ToString();
                }
            }
            catch (Exception e)
            {
                lblGroup.Text = "0";
            }
        }
        private void GetTotalByModel()
        {
            try
            {
                using (var db = new ClaimFormEntities())
                {
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.ModelName == txbModelName.Text.Trim()).Sum(m => m.CheckNumber);
                    lblModel.Text = totalCheck.ToString();
                }
            }
            catch (Exception)
            {
                lblModel.Text = "0";
            }
        }
        private void GetTotalByShift(string shift)
        {
            try
            {
                using (var db = new ClaimFormEntities())
                {
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Shift == shift).ToList();
                    if (totalCheck != null && totalCheck.Count > 0)
                    {
                        if (shift == OQC.Shift.DAY)
                        {
                            lblDay.Text = totalCheck.Sum(m => m.CheckNumber).ToString();
                        }
                        else
                        {
                            lblNight.Text = totalCheck.Sum(m => m.CheckNumber).ToString();
                        }
                    }


                }
            }
            catch (Exception e)
            {
                lblDay.Text = "0";
                lblNight.Text = "0";
            }
        }
        private void txbGroupModel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbModelName.SelectAll();
                txbModelName.Focus();
                GetTotalByGroup();
            }
        }

        private void txbWO_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbWOQty.SelectAll();
                txbWOQty.Focus();
            }
        }

        private void txbNumerCheck_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbNumberNG.SelectAll();
                txbNumberNG.Focus();
            }
        }

        private void txbWOQty_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbNumerCheck.SelectAll();
                txbNumerCheck.Focus();
            }
        }

        private void txbNote_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txbNumberNG.Text == "0")
                {
                    btnSaveODI.Focus();
                }
                else
                    dtpTimeOccur.Focus();
            }
        }

        private void txbNumberNG_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txbNote.SelectAll();
                txbNote.Focus();
            }
        }

        private void dtpTimeOccur_ValueChanged(object sender, EventArgs e)
        {
            txbLine.SelectAll();
            txbLine.Focus();
        }

        private void txbLine_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSerial.SelectAll();
                txbSerial.Focus();
            }

        }

        private void txbPosition_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbTypeNG.SelectAll();
                cbbTypeNG.Focus();
            }
        }

        private void txbSerial_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbPosition.SelectAll();
                txbPosition.Focus();
            }
        }

        private void txbNGDetail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNG.Focus();
            }
        }

        private void txbModelName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbWO.SelectAll();
                txbWO.Focus();
                GetTotalByModel();
            }
        }


        private void dtpTimeOccur_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbLine.SelectAll();
                txbLine.Focus();
            }

        }

        private void cbbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var db = new ClaimFormEntities())
                {
                    if (IDODI == 0)
                    {
                        MessageBox.Show("Chọn một ODI để xóa!");
                        return;
                    }
                    var ODI = db.ODIs.Where(m => m.ID == IDODI).FirstOrDefault();
                    if (ODI == null)
                    {
                        MessageBox.Show("ODI không tồn tại!");
                        return;
                    }
                    db.ODIs.Remove(ODI);
                    db.SaveChanges();
                    GetListODIs();
                    ResetData();
                }
            }

        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                GetTotalByShift(rbShiftDay.Checked == true ? OQC.Shift.DAY : OQC.Shift.NIGHT);

            }
        }

        private void btnDateOccur_Click(object sender, EventArgs e)
        {
            dtpDateOccur.Open();
        }


        private void compareDate()
        {
            var dateFrom = dpFrom.Value.Date;
            var dateTo = dpTo.Value.Date;
            adgrvODi.DataSource = odiDataSource;
            GetData(sql + " where DateOccur  >='" + dateFrom + "' AND DateOccur <= '" + dateTo + "'");
        }


        private void adgrvODi_FilterStringChanged(object sender, EventArgs e)
        {
            odiDataSource.Filter = this.adgrvODi.FilterString;
        }

        private void adgrvODi_SortStringChanged(object sender, EventArgs e)
        {
            odiDataSource.Sort = this.adgrvODi.SortString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            adgrvODi.DataSource = odiDataSource;
            GetData(sql + " where DateOccur = '" + DateTime.Now.ToShortDateString() + "'");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            compareDate();
        }

        private void adgrvODi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void adgrvODi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adgrvODi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow r = adgrvODi.Rows[e.RowIndex];
                IDODI = int.Parse(r.Cells["ID"].Value.ToString());
                btnSaveODI.Text = "EDIT";
                btnSubmitNext.Text = "EDIT/NEXT";
                if (IDODI == 0) return;
                using (var db = new ClaimFormEntities())
                {
                    var odi = db.ODIs.Where(m => m.ID == IDODI).FirstOrDefault();
                    txbDateOccur.Text = odi.DateOccur.ToString("dd/MM/yyy");
                    cbbAreas.Text = odi.Area;
                    cbbCustomer.Text = odi.Customer;
                    rbShiftDay.Checked = odi.Shift == OQC.Shift.DAY;
                    if (odi.Station == OQC.Station.OQC1)
                    {
                        rbStationOQC1.Checked = true;
                    }
                    else if (odi.Station == OQC.Station.OQC2)
                    {
                        rbStationOQC2.Checked = true;
                    }
                    else if (odi.Station == OQC.Station.CSL)
                    {
                        rbStationCSL.Checked = true;
                    }
                    if (odi.Shift == OQC.Shift.DAY)
                    {
                        rbShiftDay.Checked = true;
                    }
                    else
                    {
                        rbShiftNight.Checked = true;
                    }
                    if(odi.Sample_Form == SampleForm.SFAQL)
                    {
                        rbAQL.Checked = true;
                    }else if(odi.Sample_Form == SampleForm.SF100PER)
                    {
                        rb100Per.Checked = true;
                    }else if(odi.Sample_Form == SampleForm.SF50PER)
                    {
                        rb50Per.Checked = true;
                    }
                    txbInspector.Text = odi.Inspector;
                    txbGroupModel.Text = odi.GroupModel;
                    txbModelName.Text = odi.ModelName;
                    txbWO.Text = odi.WO;
                    txbWOQty.Text = odi.WOQty;
                    txbNumerCheck.Text = odi.CheckNumber.ToString();
                    txbNumberNG.Text = odi.NumberNG.ToString();
                    txbNote.Text = odi.Note;
                    dtpTimeOccur.Value = DateTime.Parse(odi.Occur_Time);
                    txbLine.Text = odi.Occur_Line;
                    txbSerial.Text = odi.Serial_Number;
                    txbPosition.Text = odi.Position;
                    cbbTypeNG.Text = odi.Defection;
                    txbNGDetail.Text = odi.Detail;
                    if (!string.IsNullOrEmpty(odi.NG_Photo))
                    {
                        NG_Photo = odi.NG_Photo;
                        pbNG.Image = new Bitmap(Utils.DownloadFile("172.28.10.17", @"VN\U34811", "umcvn", Application.StartupPath + "/" + odi.NG_Photo, "/OQC/" + odi.NG_Photo));
                    }
                    else
                    {
                        NG_Photo = "";
                        pbNG.Image = null;
                    }
                    if (!string.IsNullOrEmpty(odi.OK_Photo))
                    {
                        OK_Photo = odi.OK_Photo;
                        pbOK.Image = new Bitmap(Utils.DownloadFile("172.28.10.17", @"VN\U34811", "umcvn", Application.StartupPath + "/" + odi.OK_Photo, "/OQC/" + odi.OK_Photo));

                    }
                    else
                    {
                        OK_Photo = "";
                        pbOK.Image = null;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());

            }
        }


        private void GetData(string selectCommand)
        {
            try
            {

                string connectionString = "Data Source=172.28.10.17;Initial Catalog=ClaimForm;Persist Security Info=True;User ID=sa;Password=umc@2019";

                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                odiDataSource.DataSource = table;

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

    }
}
