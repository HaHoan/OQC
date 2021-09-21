﻿using System;

namespace OQC
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dtpDateOccur = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbShiftNight = new System.Windows.Forms.RadioButton();
            this.rbShiftDay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbStationCSL = new System.Windows.Forms.RadioButton();
            this.rbStationOQC2 = new System.Windows.Forms.RadioButton();
            this.rbStationOQC1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNumberNG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumerCheck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbWOQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbWO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbModelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGroupModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbInspector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbbAreas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCheck = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNG = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPPM = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGroup = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblModel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOP = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblNight = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panelAddWork = new System.Windows.Forms.Panel();
            this.txbDateOccur = new System.Windows.Forms.TextBox();
            this.btnSubmitNext = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveODI = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnAddOK = new System.Windows.Forms.Button();
            this.btnAddNG = new System.Windows.Forms.Button();
            this.cbbTypeNG = new System.Windows.Forms.ComboBox();
            this.dtpTimeOccur = new System.Windows.Forms.DateTimePicker();
            this.txbNGDetail = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txbPosition = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txbSerial = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txbLine = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.adgrvODi = new ADGV.AdvancedDataGridView();
            this.claimFormDataSet = new OQC.ClaimFormDataSet();
            this.oDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oDITableAdapter = new OQC.ClaimFormDataSetTableAdapters.ODITableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDateOccur = new System.Windows.Forms.Button();
            this.pbOK = new System.Windows.Forms.PictureBox();
            this.pbNG = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOccurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wOQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occurTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occurLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelAddWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgrvODi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimFormDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNG)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateOccur
            // 
            this.dtpDateOccur.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpDateOccur.Location = new System.Drawing.Point(13, 14);
            this.dtpDateOccur.Name = "dtpDateOccur";
            this.dtpDateOccur.Size = new System.Drawing.Size(36, 20);
            this.dtpDateOccur.TabIndex = 0;
            this.dtpDateOccur.Visible = false;
            this.dtpDateOccur.ValueChanged += new System.EventHandler(this.dtpDateOccur_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(94, 49);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbbCustomer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbShiftNight);
            this.groupBox1.Controls.Add(this.rbShiftDay);
            this.groupBox1.Location = new System.Drawing.Point(14, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift";
            // 
            // rbShiftNight
            // 
            this.rbShiftNight.AutoSize = true;
            this.rbShiftNight.Location = new System.Drawing.Point(109, 26);
            this.rbShiftNight.Name = "rbShiftNight";
            this.rbShiftNight.Size = new System.Drawing.Size(50, 17);
            this.rbShiftNight.TabIndex = 1;
            this.rbShiftNight.TabStop = true;
            this.rbShiftNight.Text = "Night";
            this.rbShiftNight.UseVisualStyleBackColor = true;
            this.rbShiftNight.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbShiftDay
            // 
            this.rbShiftDay.AutoSize = true;
            this.rbShiftDay.Location = new System.Drawing.Point(24, 26);
            this.rbShiftDay.Name = "rbShiftDay";
            this.rbShiftDay.Size = new System.Drawing.Size(44, 17);
            this.rbShiftDay.TabIndex = 0;
            this.rbShiftDay.TabStop = true;
            this.rbShiftDay.Text = "Day";
            this.rbShiftDay.UseVisualStyleBackColor = true;
            this.rbShiftDay.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStationCSL);
            this.groupBox2.Controls.Add(this.rbStationOQC2);
            this.groupBox2.Controls.Add(this.rbStationOQC1);
            this.groupBox2.Location = new System.Drawing.Point(15, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Station";
            // 
            // rbStationCSL
            // 
            this.rbStationCSL.AutoSize = true;
            this.rbStationCSL.Location = new System.Drawing.Point(126, 26);
            this.rbStationCSL.Name = "rbStationCSL";
            this.rbStationCSL.Size = new System.Drawing.Size(45, 17);
            this.rbStationCSL.TabIndex = 3;
            this.rbStationCSL.TabStop = true;
            this.rbStationCSL.Text = "CSL";
            this.rbStationCSL.UseVisualStyleBackColor = true;
            // 
            // rbStationOQC2
            // 
            this.rbStationOQC2.AutoSize = true;
            this.rbStationOQC2.Location = new System.Drawing.Point(66, 26);
            this.rbStationOQC2.Name = "rbStationOQC2";
            this.rbStationOQC2.Size = new System.Drawing.Size(54, 17);
            this.rbStationOQC2.TabIndex = 2;
            this.rbStationOQC2.TabStop = true;
            this.rbStationOQC2.Text = "OQC2";
            this.rbStationOQC2.UseVisualStyleBackColor = true;
            // 
            // rbStationOQC1
            // 
            this.rbStationOQC1.AutoSize = true;
            this.rbStationOQC1.Location = new System.Drawing.Point(6, 26);
            this.rbStationOQC1.Name = "rbStationOQC1";
            this.rbStationOQC1.Size = new System.Drawing.Size(54, 17);
            this.rbStationOQC1.TabIndex = 1;
            this.rbStationOQC1.TabStop = true;
            this.rbStationOQC1.Text = "OQC1";
            this.rbStationOQC1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbNote);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbNumberNG);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txbNumerCheck);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txbWOQty);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbWO);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbModelName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txbGroupModel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txbInspector);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 313);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productivity";
            // 
            // txbNote
            // 
            this.txbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNote.Location = new System.Drawing.Point(76, 216);
            this.txbNote.Multiline = true;
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(125, 80);
            this.txbNote.TabIndex = 15;
            this.txbNote.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbNote_PreviewKeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(26, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ghi chú";
            // 
            // txbNumberNG
            // 
            this.txbNumberNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberNG.Location = new System.Drawing.Point(80, 190);
            this.txbNumberNG.Name = "txbNumberNG";
            this.txbNumberNG.Size = new System.Drawing.Size(163, 20);
            this.txbNumberNG.TabIndex = 13;
            this.txbNumberNG.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbNumberNG_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(31, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "SL Lỗi";
            // 
            // txbNumerCheck
            // 
            this.txbNumerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumerCheck.Location = new System.Drawing.Point(80, 164);
            this.txbNumerCheck.Name = "txbNumerCheck";
            this.txbNumerCheck.Size = new System.Drawing.Size(163, 20);
            this.txbNumerCheck.TabIndex = 11;
            this.txbNumerCheck.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbNumerCheck_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(22, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "SL Kiểm";
            // 
            // txbWOQty
            // 
            this.txbWOQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWOQty.Location = new System.Drawing.Point(80, 138);
            this.txbWOQty.Name = "txbWOQty";
            this.txbWOQty.Size = new System.Drawing.Size(163, 20);
            this.txbWOQty.TabIndex = 9;
            this.txbWOQty.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbWOQty_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "WO Qty";
            // 
            // txbWO
            // 
            this.txbWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWO.Location = new System.Drawing.Point(80, 111);
            this.txbWO.Name = "txbWO";
            this.txbWO.Size = new System.Drawing.Size(163, 20);
            this.txbWO.TabIndex = 7;
            this.txbWO.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbWO_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(35, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "WO#";
            // 
            // txbModelName
            // 
            this.txbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModelName.Location = new System.Drawing.Point(80, 83);
            this.txbModelName.Name = "txbModelName";
            this.txbModelName.Size = new System.Drawing.Size(163, 20);
            this.txbModelName.TabIndex = 5;
            this.txbModelName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbModelName_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Model";
            // 
            // txbGroupModel
            // 
            this.txbGroupModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGroupModel.Location = new System.Drawing.Point(80, 55);
            this.txbGroupModel.Name = "txbGroupModel";
            this.txbGroupModel.Size = new System.Drawing.Size(163, 20);
            this.txbGroupModel.TabIndex = 3;
            this.txbGroupModel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbGroupModel_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhóm Model";
            // 
            // txbInspector
            // 
            this.txbInspector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInspector.Location = new System.Drawing.Point(80, 27);
            this.txbInspector.Name = "txbInspector";
            this.txbInspector.Size = new System.Drawing.Size(163, 20);
            this.txbInspector.TabIndex = 1;
            this.txbInspector.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbInspector_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inspector";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(35, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "KHU VỰC";
            // 
            // cbbAreas
            // 
            this.cbbAreas.FormattingEnabled = true;
            this.cbbAreas.Location = new System.Drawing.Point(94, 76);
            this.cbbAreas.Name = "cbbAreas";
            this.cbbAreas.Size = new System.Drawing.Size(121, 21);
            this.cbbAreas.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalCheck);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(237, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 96);
            this.panel1.TabIndex = 9;
            // 
            // lblTotalCheck
            // 
            this.lblTotalCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCheck.Location = new System.Drawing.Point(0, 51);
            this.lblTotalCheck.Name = "lblTotalCheck";
            this.lblTotalCheck.Size = new System.Drawing.Size(129, 43);
            this.lblTotalCheck.TabIndex = 1;
            this.lblTotalCheck.Text = "0";
            this.lblTotalCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 37);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số lượng kiểm của dự án";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNG);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(373, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 96);
            this.panel2.TabIndex = 10;
            // 
            // lblNG
            // 
            this.lblNG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNG.Location = new System.Drawing.Point(0, 51);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(76, 43);
            this.lblNG.TabIndex = 1;
            this.lblNG.Text = "0";
            this.lblNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "NG";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPPM);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(456, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 95);
            this.panel3.TabIndex = 11;
            // 
            // lblPPM
            // 
            this.lblPPM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPPM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPM.Location = new System.Drawing.Point(0, 49);
            this.lblPPM.Name = "lblPPM";
            this.lblPPM.Size = new System.Drawing.Size(76, 44);
            this.lblPPM.TabIndex = 1;
            this.lblPPM.Text = "0";
            this.lblPPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "PPM";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblGroup);
            this.panel4.Controls.Add(this.label15);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(540, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 96);
            this.panel4.TabIndex = 12;
            // 
            // lblGroup
            // 
            this.lblGroup.BackColor = System.Drawing.Color.White;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(0, 49);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(128, 45);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "0";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 35);
            this.label15.TabIndex = 0;
            this.label15.Text = "SL Đã kiểm theo Group";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblModel);
            this.panel5.Controls.Add(this.label17);
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(676, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 96);
            this.panel5.TabIndex = 13;
            // 
            // lblModel
            // 
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(0, 49);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(126, 45);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "0";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 35);
            this.label17.TabIndex = 0;
            this.label17.Text = "SL Đã kiểm theo Model";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblOP);
            this.panel6.Controls.Add(this.label19);
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(810, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 96);
            this.panel6.TabIndex = 14;
            // 
            // lblOP
            // 
            this.lblOP.BackColor = System.Drawing.Color.White;
            this.lblOP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.Location = new System.Drawing.Point(0, 49);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(127, 45);
            this.lblOP.TabIndex = 1;
            this.lblOP.Text = "0";
            this.lblOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 35);
            this.label19.TabIndex = 0;
            this.label19.Text = "SL Đã kiểm của OP";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SpringGreen;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblDay);
            this.panel7.Controls.Add(this.label21);
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(945, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(126, 95);
            this.panel7.TabIndex = 15;
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.White;
            this.lblDay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(0, 48);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(124, 45);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "0";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(22, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 35);
            this.label21.TabIndex = 0;
            this.label21.Text = "SL Đã kiểm của Ca Ngày";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SpringGreen;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblNight);
            this.panel8.Controls.Add(this.label23);
            this.panel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(1080, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(122, 95);
            this.panel8.TabIndex = 16;
            // 
            // lblNight
            // 
            this.lblNight.BackColor = System.Drawing.Color.White;
            this.lblNight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNight.Location = new System.Drawing.Point(0, 48);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(120, 45);
            this.lblNight.TabIndex = 1;
            this.lblNight.Text = "0";
            this.lblNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 35);
            this.label23.TabIndex = 0;
            this.label23.Text = "SL Đã kiểm của Ca Đêm";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelAddWork
            // 
            this.panelAddWork.Controls.Add(this.button1);
            this.panelAddWork.Controls.Add(this.adgrvODi);
            this.panelAddWork.Controls.Add(this.label14);
            this.panelAddWork.Controls.Add(this.dpTo);
            this.panelAddWork.Controls.Add(this.label11);
            this.panelAddWork.Controls.Add(this.dpFrom);
            this.panelAddWork.Controls.Add(this.txbDateOccur);
            this.panelAddWork.Controls.Add(this.btnDateOccur);
            this.panelAddWork.Controls.Add(this.btnSubmitNext);
            this.panelAddWork.Controls.Add(this.lblStatus);
            this.panelAddWork.Controls.Add(this.btnDelete);
            this.panelAddWork.Controls.Add(this.btnSaveODI);
            this.panelAddWork.Controls.Add(this.label31);
            this.panelAddWork.Controls.Add(this.label32);
            this.panelAddWork.Controls.Add(this.btnAddOK);
            this.panelAddWork.Controls.Add(this.pbOK);
            this.panelAddWork.Controls.Add(this.btnAddNG);
            this.panelAddWork.Controls.Add(this.pbNG);
            this.panelAddWork.Controls.Add(this.cbbTypeNG);
            this.panelAddWork.Controls.Add(this.dtpTimeOccur);
            this.panelAddWork.Controls.Add(this.txbNGDetail);
            this.panelAddWork.Controls.Add(this.label25);
            this.panelAddWork.Controls.Add(this.label26);
            this.panelAddWork.Controls.Add(this.txbPosition);
            this.panelAddWork.Controls.Add(this.label27);
            this.panelAddWork.Controls.Add(this.txbSerial);
            this.panelAddWork.Controls.Add(this.label28);
            this.panelAddWork.Controls.Add(this.txbLine);
            this.panelAddWork.Controls.Add(this.label29);
            this.panelAddWork.Controls.Add(this.label30);
            this.panelAddWork.Controls.Add(this.panel8);
            this.panelAddWork.Controls.Add(this.panel7);
            this.panelAddWork.Controls.Add(this.panel6);
            this.panelAddWork.Controls.Add(this.panel5);
            this.panelAddWork.Controls.Add(this.panel4);
            this.panelAddWork.Controls.Add(this.panel3);
            this.panelAddWork.Controls.Add(this.panel2);
            this.panelAddWork.Controls.Add(this.panel1);
            this.panelAddWork.Controls.Add(this.cbbAreas);
            this.panelAddWork.Controls.Add(this.label24);
            this.panelAddWork.Controls.Add(this.groupBox3);
            this.panelAddWork.Controls.Add(this.groupBox2);
            this.panelAddWork.Controls.Add(this.groupBox1);
            this.panelAddWork.Controls.Add(this.cbbCustomer);
            this.panelAddWork.Controls.Add(this.label1);
            this.panelAddWork.Controls.Add(this.dtpDateOccur);
            this.panelAddWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddWork.Location = new System.Drawing.Point(0, 0);
            this.panelAddWork.Name = "panelAddWork";
            this.panelAddWork.Size = new System.Drawing.Size(1210, 793);
            this.panelAddWork.TabIndex = 2;
            // 
            // txbDateOccur
            // 
            this.txbDateOccur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDateOccur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDateOccur.Location = new System.Drawing.Point(91, 16);
            this.txbDateOccur.Name = "txbDateOccur";
            this.txbDateOccur.Size = new System.Drawing.Size(123, 20);
            this.txbDateOccur.TabIndex = 52;
            // 
            // btnSubmitNext
            // 
            this.btnSubmitNext.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSubmitNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNext.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmitNext.Location = new System.Drawing.Point(123, 627);
            this.btnSubmitNext.Name = "btnSubmitNext";
            this.btnSubmitNext.Size = new System.Drawing.Size(116, 49);
            this.btnSubmitNext.TabIndex = 50;
            this.btnSubmitNext.Text = "SUBMIT/NEXT";
            this.btnSubmitNext.UseVisualStyleBackColor = false;
            this.btnSubmitNext.Click += new System.EventHandler(this.btnSaveODI_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(21, 580);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 16);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "...";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(16, 692);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 56);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveODI
            // 
            this.btnSaveODI.BackColor = System.Drawing.Color.Green;
            this.btnSaveODI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveODI.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveODI.Location = new System.Drawing.Point(16, 628);
            this.btnSaveODI.Name = "btnSaveODI";
            this.btnSaveODI.Size = new System.Drawing.Size(103, 49);
            this.btnSaveODI.TabIndex = 47;
            this.btnSaveODI.Text = "SUBMIT";
            this.btnSaveODI.UseVisualStyleBackColor = false;
            this.btnSaveODI.Click += new System.EventHandler(this.btnSaveODI_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(869, 516);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 46;
            this.label31.Text = "Ảnh OK";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(540, 516);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 13);
            this.label32.TabIndex = 45;
            this.label32.Text = "Ảnh NG";
            // 
            // btnAddOK
            // 
            this.btnAddOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddOK.Location = new System.Drawing.Point(872, 763);
            this.btnAddOK.Name = "btnAddOK";
            this.btnAddOK.Size = new System.Drawing.Size(75, 23);
            this.btnAddOK.TabIndex = 44;
            this.btnAddOK.Text = "Chọn Ảnh";
            this.btnAddOK.UseVisualStyleBackColor = true;
            this.btnAddOK.Click += new System.EventHandler(this.btnAddOK_Click);
            // 
            // btnAddNG
            // 
            this.btnAddNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNG.Location = new System.Drawing.Point(538, 763);
            this.btnAddNG.Name = "btnAddNG";
            this.btnAddNG.Size = new System.Drawing.Size(75, 23);
            this.btnAddNG.TabIndex = 42;
            this.btnAddNG.Text = "Chọn Ảnh";
            this.btnAddNG.UseVisualStyleBackColor = true;
            this.btnAddNG.Click += new System.EventHandler(this.btnAddNG_Click);
            // 
            // cbbTypeNG
            // 
            this.cbbTypeNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeNG.FormattingEnabled = true;
            this.cbbTypeNG.Location = new System.Drawing.Point(386, 655);
            this.cbbTypeNG.Name = "cbbTypeNG";
            this.cbbTypeNG.Size = new System.Drawing.Size(130, 24);
            this.cbbTypeNG.TabIndex = 40;
            // 
            // dtpTimeOccur
            // 
            this.dtpTimeOccur.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOccur.CustomFormat = "HH:mm";
            this.dtpTimeOccur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOccur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeOccur.Location = new System.Drawing.Point(386, 544);
            this.dtpTimeOccur.Name = "dtpTimeOccur";
            this.dtpTimeOccur.ShowUpDown = true;
            this.dtpTimeOccur.Size = new System.Drawing.Size(130, 20);
            this.dtpTimeOccur.TabIndex = 39;
            this.dtpTimeOccur.ValueChanged += new System.EventHandler(this.dtpTimeOccur_ValueChanged);
            // 
            // txbNGDetail
            // 
            this.txbNGDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNGDetail.Location = new System.Drawing.Point(386, 683);
            this.txbNGDetail.Name = "txbNGDetail";
            this.txbNGDetail.Size = new System.Drawing.Size(130, 20);
            this.txbNGDetail.TabIndex = 38;
            this.txbNGDetail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbNGDetail_PreviewKeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(323, 692);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 13);
            this.label25.TabIndex = 37;
            this.label25.Text = "Mô tả lỗi";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(330, 664);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Loại lỗi";
            // 
            // txbPosition
            // 
            this.txbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPosition.Location = new System.Drawing.Point(386, 627);
            this.txbPosition.Name = "txbPosition";
            this.txbPosition.Size = new System.Drawing.Size(130, 20);
            this.txbPosition.TabIndex = 35;
            this.txbPosition.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbPosition_PreviewKeyDown);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(341, 636);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 34;
            this.label27.Text = "Vị trí";
            // 
            // txbSerial
            // 
            this.txbSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSerial.Location = new System.Drawing.Point(386, 599);
            this.txbSerial.Name = "txbSerial";
            this.txbSerial.Size = new System.Drawing.Size(130, 20);
            this.txbSerial.TabIndex = 33;
            this.txbSerial.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbSerial_PreviewKeyDown);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(316, 608);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 13);
            this.label28.TabIndex = 32;
            this.label28.Text = "Số serial";
            // 
            // txbLine
            // 
            this.txbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLine.Location = new System.Drawing.Point(386, 571);
            this.txbLine.Name = "txbLine";
            this.txbLine.Size = new System.Drawing.Size(130, 20);
            this.txbLine.TabIndex = 31;
            this.txbLine.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbLine_PreviewKeyDown);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(307, 580);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 13);
            this.label29.TabIndex = 30;
            this.label29.Text = "Line phát sinh";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(283, 552);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 13);
            this.label30.TabIndex = 29;
            this.label30.Text = "Thời điểm(hh:mm)";
            // 
            // dpFrom
            // 
            this.dpFrom.CustomFormat = "dd-MM-yyyy";
            this.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFrom.Location = new System.Drawing.Point(319, 140);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(77, 20);
            this.dpFrom.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Từ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Đến";
            // 
            // dpTo
            // 
            this.dpTo.CustomFormat = "dd-MM-yyyy";
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpTo.Location = new System.Drawing.Point(457, 140);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(77, 20);
            this.dpTo.TabIndex = 55;
            // 
            // adgrvODi
            // 
            this.adgrvODi.AutoGenerateColumns = false;
            this.adgrvODi.AutoGenerateContextFilters = true;
            this.adgrvODi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgrvODi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dateOccurDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.inspectorDataGridViewTextBoxColumn,
            this.groupModelDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.wODataGridViewTextBoxColumn,
            this.wOQtyDataGridViewTextBoxColumn,
            this.checkNumberDataGridViewTextBoxColumn,
            this.numberNGDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.occurTimeDataGridViewTextBoxColumn,
            this.occurLineDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.defectionDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.nGPhotoDataGridViewTextBoxColumn,
            this.oKPhotoDataGridViewTextBoxColumn});
            this.adgrvODi.DataSource = this.oDIBindingSource;
            this.adgrvODi.DateWithTime = false;
            this.adgrvODi.Location = new System.Drawing.Point(286, 169);
            this.adgrvODi.Name = "adgrvODi";
            this.adgrvODi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgrvODi.Size = new System.Drawing.Size(915, 331);
            this.adgrvODi.TabIndex = 59;
            this.adgrvODi.TimeFilter = false;
            this.adgrvODi.SortStringChanged += new System.EventHandler(this.adgrvODi_SortStringChanged);
            this.adgrvODi.FilterStringChanged += new System.EventHandler(this.adgrvODi_FilterStringChanged);
            this.adgrvODi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.adgrvODi_CellMouseClick);
            // 
            // claimFormDataSet
            // 
            this.claimFormDataSet.DataSetName = "ClaimFormDataSet";
            this.claimFormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oDIBindingSource
            // 
            this.oDIBindingSource.DataMember = "ODI";
            this.oDIBindingSource.DataSource = this.claimFormDataSet;
            // 
            // oDITableAdapter
            // 
            this.oDITableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::OQC.Properties.Resources.binoculars;
            this.button1.Location = new System.Drawing.Point(566, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 33);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDateOccur
            // 
            this.btnDateOccur.BackColor = System.Drawing.Color.Transparent;
            this.btnDateOccur.FlatAppearance.BorderSize = 0;
            this.btnDateOccur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateOccur.Image = global::OQC.Properties.Resources.calendar;
            this.btnDateOccur.Location = new System.Drawing.Point(45, 3);
            this.btnDateOccur.Name = "btnDateOccur";
            this.btnDateOccur.Size = new System.Drawing.Size(42, 42);
            this.btnDateOccur.TabIndex = 51;
            this.btnDateOccur.UseVisualStyleBackColor = false;
            this.btnDateOccur.Click += new System.EventHandler(this.btnDateOccur_Click);
            // 
            // pbOK
            // 
            this.pbOK.Location = new System.Drawing.Point(872, 544);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(309, 204);
            this.pbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOK.TabIndex = 43;
            this.pbOK.TabStop = false;
            // 
            // pbNG
            // 
            this.pbNG.Location = new System.Drawing.Point(538, 544);
            this.pbNG.Name = "pbNG";
            this.pbNG.Size = new System.Drawing.Size(309, 210);
            this.pbNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNG.TabIndex = 41;
            this.pbNG.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 22;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ID.Visible = false;
            // 
            // dateOccurDataGridViewTextBoxColumn
            // 
            this.dateOccurDataGridViewTextBoxColumn.DataPropertyName = "DateOccur";
            this.dateOccurDataGridViewTextBoxColumn.HeaderText = "DateOccur";
            this.dateOccurDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dateOccurDataGridViewTextBoxColumn.Name = "dateOccurDataGridViewTextBoxColumn";
            this.dateOccurDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "Station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Station";
            this.stationDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            this.stationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // inspectorDataGridViewTextBoxColumn
            // 
            this.inspectorDataGridViewTextBoxColumn.DataPropertyName = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.inspectorDataGridViewTextBoxColumn.Name = "inspectorDataGridViewTextBoxColumn";
            this.inspectorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // groupModelDataGridViewTextBoxColumn
            // 
            this.groupModelDataGridViewTextBoxColumn.DataPropertyName = "GroupModel";
            this.groupModelDataGridViewTextBoxColumn.HeaderText = "GroupModel";
            this.groupModelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.groupModelDataGridViewTextBoxColumn.Name = "groupModelDataGridViewTextBoxColumn";
            this.groupModelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            this.modelNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // wODataGridViewTextBoxColumn
            // 
            this.wODataGridViewTextBoxColumn.DataPropertyName = "WO";
            this.wODataGridViewTextBoxColumn.HeaderText = "WO";
            this.wODataGridViewTextBoxColumn.MinimumWidth = 22;
            this.wODataGridViewTextBoxColumn.Name = "wODataGridViewTextBoxColumn";
            this.wODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // wOQtyDataGridViewTextBoxColumn
            // 
            this.wOQtyDataGridViewTextBoxColumn.DataPropertyName = "WOQty";
            this.wOQtyDataGridViewTextBoxColumn.HeaderText = "WOQty";
            this.wOQtyDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.wOQtyDataGridViewTextBoxColumn.Name = "wOQtyDataGridViewTextBoxColumn";
            this.wOQtyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // checkNumberDataGridViewTextBoxColumn
            // 
            this.checkNumberDataGridViewTextBoxColumn.DataPropertyName = "CheckNumber";
            this.checkNumberDataGridViewTextBoxColumn.HeaderText = "CheckNumber";
            this.checkNumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.checkNumberDataGridViewTextBoxColumn.Name = "checkNumberDataGridViewTextBoxColumn";
            this.checkNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // numberNGDataGridViewTextBoxColumn
            // 
            this.numberNGDataGridViewTextBoxColumn.DataPropertyName = "NumberNG";
            this.numberNGDataGridViewTextBoxColumn.HeaderText = "NumberNG";
            this.numberNGDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.numberNGDataGridViewTextBoxColumn.Name = "numberNGDataGridViewTextBoxColumn";
            this.numberNGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.noteDataGridViewTextBoxColumn.Visible = false;
            // 
            // occurTimeDataGridViewTextBoxColumn
            // 
            this.occurTimeDataGridViewTextBoxColumn.DataPropertyName = "Occur_Time";
            this.occurTimeDataGridViewTextBoxColumn.HeaderText = "Occur_Time";
            this.occurTimeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.occurTimeDataGridViewTextBoxColumn.Name = "occurTimeDataGridViewTextBoxColumn";
            this.occurTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // occurLineDataGridViewTextBoxColumn
            // 
            this.occurLineDataGridViewTextBoxColumn.DataPropertyName = "Occur_Line";
            this.occurLineDataGridViewTextBoxColumn.HeaderText = "Occur_Line";
            this.occurLineDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.occurLineDataGridViewTextBoxColumn.Name = "occurLineDataGridViewTextBoxColumn";
            this.occurLineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial_Number";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "Serial_Number";
            this.serialNumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // defectionDataGridViewTextBoxColumn
            // 
            this.defectionDataGridViewTextBoxColumn.DataPropertyName = "Defection";
            this.defectionDataGridViewTextBoxColumn.HeaderText = "Defection";
            this.defectionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.defectionDataGridViewTextBoxColumn.Name = "defectionDataGridViewTextBoxColumn";
            this.defectionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.detailDataGridViewTextBoxColumn.Visible = false;
            // 
            // nGPhotoDataGridViewTextBoxColumn
            // 
            this.nGPhotoDataGridViewTextBoxColumn.DataPropertyName = "NG_Photo";
            this.nGPhotoDataGridViewTextBoxColumn.HeaderText = "NG_Photo";
            this.nGPhotoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nGPhotoDataGridViewTextBoxColumn.Name = "nGPhotoDataGridViewTextBoxColumn";
            this.nGPhotoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nGPhotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // oKPhotoDataGridViewTextBoxColumn
            // 
            this.oKPhotoDataGridViewTextBoxColumn.DataPropertyName = "OK_Photo";
            this.oKPhotoDataGridViewTextBoxColumn.HeaderText = "OK_Photo";
            this.oKPhotoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.oKPhotoDataGridViewTextBoxColumn.Name = "oKPhotoDataGridViewTextBoxColumn";
            this.oKPhotoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.oKPhotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 793);
            this.Controls.Add(this.panelAddWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form OQC";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelAddWork.ResumeLayout(false);
            this.panelAddWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgrvODi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimFormDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNG)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOccur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbShiftNight;
        private System.Windows.Forms.RadioButton rbShiftDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbStationCSL;
        private System.Windows.Forms.RadioButton rbStationOQC2;
        private System.Windows.Forms.RadioButton rbStationOQC1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNumberNG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNumerCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbWOQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbWO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbModelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGroupModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbInspector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbbAreas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPPM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panelAddWork;
        private System.Windows.Forms.ComboBox cbbTypeNG;
        private System.Windows.Forms.DateTimePicker dtpTimeOccur;
        private System.Windows.Forms.TextBox txbNGDetail;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txbPosition;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txbSerial;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txbLine;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnAddOK;
        private System.Windows.Forms.PictureBox pbOK;
        private System.Windows.Forms.Button btnAddNG;
        private System.Windows.Forms.PictureBox pbNG;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveODI;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSubmitNext;
        private System.Windows.Forms.Button btnDateOccur;
        private System.Windows.Forms.TextBox txbDateOccur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dpTo;
        private ADGV.AdvancedDataGridView adgrvODi;
        private ClaimFormDataSet claimFormDataSet;
        private System.Windows.Forms.BindingSource oDIBindingSource;
        private ClaimFormDataSetTableAdapters.ODITableAdapter oDITableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOccurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wOQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occurTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occurLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKPhotoDataGridViewTextBoxColumn;
    }
}