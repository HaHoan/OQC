using OQC.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OQC
{
    public partial class FormMain : Form
    {

        List<TypeNG> listNG = new List<TypeNG>();
        public string[] areas = new string[]
        {
            Areas.AUTO,
            Areas.ID,
            Areas.PICKUP,
            Areas.OA
        };
        private string sql = "select [ID],[Customer] ,[Station],[Inspector],[GroupModel],[ModelName] ,[WO] ,[WOQty],[CheckNumber],[Area],[Shift],[NumberNG] , [DateOccur],[Occur_Time] ,[Occur_Line] ,[Serial_Number] ,[Position],[Defection],[Sample_Form],[IsConfirm] from ODI";
        private BindingSource odiDataSource = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private List<Area> customers;
        public FormMain()
        {
            InitializeComponent();
            lblcode.Text = Properties.Settings.Default.Code.ToUpper();
            lblName.Text = Properties.Settings.Default.Name;
            //lblRole.Text = Properties.Settings.Default.Role.ToUpper();
            txbInspector.Text = Properties.Settings.Default.Code;
            lblVersion.Text = Utils.GetRunningVersion();
            getCustomer();
            if (Properties.Settings.Default.Account == RoleName.ADMIN)
            {
                btnEditTargetPPM.Visible = true;
            }
            else
            {
                btnEditTargetPPM.Visible = false;

            }
            if (Properties.Settings.Default.Account <= RoleName.LEADER && Properties.Settings.Default.Account > 0)
            {
                btnConfirmData.Visible = true;
            }
            else
            {
                btnConfirmData.Visible = false;
            }
            lblStatus.Text = "";

            using (var db = new ClaimFormEntities())
            {
                listNG = db.TypeNGs.ToList();
                foreach (var ng in listNG)
                {
                    cbbTypeNG.Items.Add(ng.TypeNG1);
                }
               
            }
            updateLabelConfirm();
            odiDataSource.ListChanged += OdiDataSource_ListChanged;
            GetTotal();
            this.ActiveControl = txbDateOccur;
        }

        private void getCustomer()
        {
            using (var db = new ClaimFormEntities())
            {
                customers = db.Areas.ToList();
                foreach (var cus in customers)
                {
                    cbbCustomer.Items.Add(cus.Customer);
                }

            }
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
            if (!rb100Per.Checked && !rbAQL.Checked && !rb50Per.Checked)
            {
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
            if (string.IsNullOrEmpty(txbWO.Text) || txbWO.Text.Length < 6)
            {
                lblStatus.Text = "WO chưa nhập hoặc nhập thiếu";
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
            if (int.Parse(txbNumberNG.Text.Trim()) == 0 && !string.IsNullOrEmpty(NG_Photo))
            {
                DialogResult dialogResult = MessageBox.Show("Số lượng lỗi bằng 0 mà vẫn có ảnh NG!", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    lblStatus.Text = "";
                    txbNumberNG.Focus();
                }

                return false;
            }
            if (int.Parse(txbNumberNG.Text.Trim()) == 0)
            {
                return true;
            }
            if (string.IsNullOrEmpty(dtpTimeOccur.Text))
            {
                lblStatus.Text = "Chưa chọn thời gian phát sinh lỗi";
                dtpTimeOccur.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbLine.Text))
            {
                lblStatus.Text = "Chưa nhập line phát sinh lỗi";
                txbLine.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txbPosition.Text))
            {
                lblStatus.Text = "Chưa nhập vị trí lỗi";
                txbPosition.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbTypeNG.Text))
            {
                lblStatus.Text = "Chưa chọn loại lỗi";
                cbbTypeNG.Focus();
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
                    int totalCheck = 0;
                    int totalNG = 0;
                    if (string.IsNullOrEmpty(cbbCustomer.Text))
                    {
                        totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.IsConfirm == true).Sum(m => m.CheckNumber);
                        totalNG = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.IsConfirm == true).Sum(m => m.NumberNG);
                    }
                    else
                    {
                        totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Customer == cbbCustomer.Text.Trim() && m.IsConfirm == true).Sum(m => m.CheckNumber);
                        totalNG = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Customer == cbbCustomer.Text.Trim() && m.IsConfirm == true).Sum(m => m.NumberNG);
                    }

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
        private void updateLabelConfirm()
        {
            using (var db = new ClaimFormEntities())
            {
                var countNotConfirm = db.ODIs.Where(m => m.IsConfirm == false).Count();
                if (countNotConfirm == 0)
                {
                    lblNotice.Text = "";
                }
                else
                    lblNotice.Text = countNotConfirm + " rows not confirm!";
            }
        }
        private void updateAll()
        {
            updateLabelConfirm();
            GetTotal();
            GetTotalByOP();
            GetTotalByGroup();
            GetTotalByModel();
            GetTotalByShift(Shift.DAY);
            GetTotalByShift(Shift.NIGHT);
        }
        private void OnlyNumberPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //  (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }

        string NG_Photo = "";
        string OK_Photo = "";
        private void btnAddNG_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.FilterIndex = 1;
                choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    NG_Photo = Guid.NewGuid().ToString() + Path.GetFileName(choofdlog.FileName);
                    pbNG.Image = new Bitmap(choofdlog.FileName);
                    Utils.UploadFile("172.28.10.17", @"VN\U34811", "hoan200794", choofdlog.FileName, @"\OQC\" + NG_Photo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnAddOK_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.FilterIndex = 1;
                choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    OK_Photo = Guid.NewGuid().ToString() + Path.GetFileName(choofdlog.FileName);
                    pbOK.Image = new Bitmap(choofdlog.FileName);
                    Utils.UploadFile("172.28.10.17", @"VN\U34811", "hoan200794", choofdlog.FileName, @"\OQC\" + OK_Photo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnSaveODI_Click(object sender, EventArgs e)
        {
            submit(sender);
            if (this.odiDataSource.List.Count > 1)
                adgrvODi.FirstDisplayedScrollingRowIndex = this.odiDataSource.List.Count - 1;
        }
        private void submit(object sender)
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
                    }
                    else if (rb50Per.Checked)
                    {
                        sampleForm = SampleForm.SF50PER;
                    }
                    else if (rbAQL.Checked)
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
                        ODI.Area = txbArea.Text;
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
                        if (ODI.NumberNG != 0)
                        {
                            ODI.Occur_Time = dtpTimeOccur.Value.ToShortTimeString();
                            ODI.Occur_Line = txbLine.Text;
                            ODI.Serial_Number = txbSerial.Text;
                            ODI.Position = txbPosition.Text;
                            ODI.Defection = cbbTypeNG.Text;
                            ODI.Detail = txbNGDetail.Text;
                            ODI.NG_Photo = NG_Photo;
                            ODI.OK_Photo = OK_Photo;
                        }

                        ODI.Sample_Form = sampleForm;
                    }
                    else
                    {

                        ODI = new ODI()
                        {
                            DateOccur = dtpDateOccur.Value.Date,
                            Area = txbArea.Text,
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
                            Sample_Form = sampleForm,
                            IsConfirm = false
                        };
                        if (Properties.Settings.Default.Account < 2 && Properties.Settings.Default.Account > 0)
                        {
                            ODI.IsConfirm = true;
                        }
                        if (ODI.NumberNG == 0)
                        {
                            ODI.NG_Photo = "";
                            ODI.OK_Photo = "";
                            ODI.Occur_Time = DateTime.Now.ToShortTimeString();
                            ODI.Occur_Line = "";
                            ODI.Serial_Number = "";
                            ODI.Position = "";
                            ODI.Defection = "";
                            ODI.Detail = "";
                            ODI.NG_Photo = NG_Photo;
                            ODI.OK_Photo = OK_Photo;
                        }
                        db.ODIs.Add(ODI);
                    }

                    db.SaveChanges();
                    GetListODIs();
                    if (((Button)sender).Name == "btnSaveODI" || ((Button)sender).Name == "btnCreate")
                    {
                        ResetDataKeepInspector();
                    }
                    else
                    {
                        ResetData();
                    }
                    btnCreate.Visible = false;

                    updateAll();
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
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Inspector == txbInspector.Text.Trim() && m.IsConfirm == true).Sum(m => m.CheckNumber);
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
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.GroupModel == txbGroupModel.Text.Trim() && m.IsConfirm == true).Sum(m => m.CheckNumber);

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
                    var totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.ModelName == txbModelName.Text.Trim() && m.IsConfirm == true).Sum(m => m.CheckNumber);
                    lblModel.Text = totalCheck.ToString();
                    lblModel.Text = totalCheck.ToString();
                    lblModel.Text = totalCheck.ToString();
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
                    List<ODI> totalCheck = new List<ODI>();
                    if (string.IsNullOrEmpty(cbbCustomer.Text))
                    {
                        totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Shift == shift && m.IsConfirm == true).ToList();
                    }
                    else
                    {
                        totalCheck = db.ODIs.Where(m => m.DateOccur == dtpDateOccur.Value.Date && m.Shift == shift && m.Customer == cbbCustomer.Text.Trim() && m.IsConfirm == true).ToList();
                    }

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
                    else
                    {
                        lblDay.Text = "0";
                        lblNight.Text = "0";
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
                    updateAll();
                    ResetDataKeepInspector();
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
                btnCreate.Visible = true;
                if (IDODI == 0) return;
                using (var db = new ClaimFormEntities())
                {
                    var odi = db.ODIs.Where(m => m.ID == IDODI).FirstOrDefault();
                    txbDateOccur.Text = odi.DateOccur.ToString("dd/MM/yyy");
                    txbArea.Text = odi.Area;
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
                    if (odi.Sample_Form == SampleForm.SFAQL)
                    {
                        rbAQL.Checked = true;
                    }
                    else if (odi.Sample_Form == SampleForm.SF100PER)
                    {
                        rb100Per.Checked = true;
                    }
                    else if (odi.Sample_Form == SampleForm.SF50PER)
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
                        pbNG.Image = new Bitmap(Utils.DownloadFile("172.28.10.17", @"VN\U34811", "hoan200794", Application.StartupPath + "/" + odi.NG_Photo, "/OQC/" + odi.NG_Photo));
                    }
                    else
                    {
                        NG_Photo = "";
                        pbNG.Image = null;
                    }
                    if (!string.IsNullOrEmpty(odi.OK_Photo))
                    {
                        OK_Photo = odi.OK_Photo;
                        pbOK.Image = new Bitmap(Utils.DownloadFile("172.28.10.17", @"VN\U34811", "hoan200794", Application.StartupPath + "/" + odi.OK_Photo, "/OQC/" + odi.OK_Photo));

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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var choofdlog = new FolderBrowserDialog();

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var number = lblNumberRow.Text.Split(' ');
                    var countRow = int.Parse(number[0]);
                    string fileName = Utils.GetFileName(choofdlog, Constants.EXCEL_STAFF);
                    if (countRow < 65536)
                    {
                        lblExport.Text = "Waiting...";
                        bgWorker.RunWorkerAsync(argument: fileName);
                    }
                    else
                    {
                        // Don't save if no data is returned
                        var dgv = adgrvODi;
                        if (dgv.Rows.Count == 0)
                        {
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        // Column headers
                        string columnsHeader = "";
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            columnsHeader += dgv.Columns[i].Name + ",";
                        }
                        sb.Append(columnsHeader + Environment.NewLine);
                        // Go through each cell in the datagridview
                        foreach (DataGridViewRow dgvRow in dgv.Rows)
                        {
                            // Make sure it's not an empty row.
                            if (!dgvRow.IsNewRow)
                            {
                                for (int c = 0; c < dgvRow.Cells.Count; c++)
                                {
                                    // Append the cells data followed by a comma to delimit.

                                    sb.Append(dgvRow.Cells[c].Value + ",");
                                }
                                // Add a new line in the text file.
                                sb.Append(Environment.NewLine);
                            }
                        }
                        // Load up the save file dialog with the default option as saving as a .csv file.
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "CSV files (*.csv)|*.csv";
                        sfd.FileName = fileName;
                        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            // If they've selected a save location...
                            using (StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
                            {
                                // Write the stringbuilder text to the the file.
                                sw.WriteLine(sb.ToString());
                            }
                            MessageBox.Show("Đã xuất file csv thành công!");

                        }

                        //lblPathRoot.Text = @"C:\DATA_BIVN_PACKING_CSV_FILE";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }


            }
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var fileName = (string)e.Argument;
            using (var db = new ClaimFormEntities())
            {
                var dateFrom = dpFrom.Value.Date;
                var dateTo = dpTo.Value.Date;
                var odis = db.ODIs.Where(m => m.DateOccur >= dateFrom && m.DateOccur <= dateTo).ToList();
                var result = Utils.ExportStaff(odis, fileName);
                e.Result = result;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var result = (Tuple<int, string>)e.Result;
            MessageBox.Show(result.Item2);
            lblExport.Text = "";
        }

        private void txbDateOccur_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            cbbCustomer.Focus();
        }

        private void cbbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txbArea.Text = customers.Where(m => m.Customer == cbbCustomer.Text).FirstOrDefault().Area1;
            if (txbArea.Text == "AUTO")
            {
                rb100Per.Checked = true;
            }
            GetTotal();

        }

        private void rbShiftDay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rbShiftNight.Focus();
        }

        private void rbShiftNight_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rbStationOQC1.Focus();
        }

        private void rbStationOQC1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rbStationOQC2.Focus();
        }

        private void rbStationOQC2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rbStationCSL.Focus();
        }

        private void rbStationCSL_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rb100Per.Focus();
        }

        private void rb100Per_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rbAQL.Focus();
        }

        private void rbAQL_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            rb50Per.Focus();
        }

        private void rb50Per_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            txbInspector.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            IDODI = 0;
            submit(sender);
            adgrvODi.FirstDisplayedScrollingRowIndex = this.odiDataSource.List.Count - 1;

        }

        private void btnEditTargetPPM_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnEditTargetPPM_Click(object sender, EventArgs e)
        {
            new FormEditPPM().ShowDialog();
        }

        private void btnConfirmData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xác nhận dữ liệu đã nhập không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                using (var db = new ClaimFormEntities())
                {
                    using (DbContextTransaction transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            int count = 0;
                            foreach (DataGridViewRow r in adgrvODi.SelectedRows)
                            {
                                if (r.Cells["ID"].Value != null)
                                {
                                    int IDODI = int.Parse(r.Cells["ID"].Value.ToString());
                                    var odi = db.ODIs.Where(m => m.ID == IDODI).FirstOrDefault();
                                    if (odi != null)
                                    {
                                        if (odi.IsConfirm == null || (odi.IsConfirm is bool isconfirm && !isconfirm))
                                        {
                                            odi.IsConfirm = true;
                                            db.SaveChanges();
                                            count++;
                                        }
                                    }
                                }


                            }
                            transaction.Commit();
                            GetListODIs();
                            updateAll();
                            MessageBox.Show("Confirm thành công " + count.ToString() + " rows!");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }

                }
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Properties.Settings.Default.Account = 0;
            new Login().ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Hide();
            var changePass = new FormChangePassword();
            changePass.ShowDialog();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var sumDialog = new FormCaculator();
            sumDialog.result = (sum) =>
            {
                if (!string.IsNullOrEmpty(txbNumerCheck.Text))
                {
                    sum += int.Parse(txbNumerCheck.Text.Trim());
                }
                txbNumerCheck.Text = sum.ToString();
            };
            sumDialog.ShowDialog();

        }
    }
}

