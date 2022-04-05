
namespace OQC
{
    partial class FormConfirmData
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgrvListConfirm = new System.Windows.Forms.DataGridView();
            this.btnConfirmAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvListConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DỮ LIỆU CHỜ CONFIRM";
            // 
            // dgrvListConfirm
            // 
            this.dgrvListConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvListConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrvListConfirm.Location = new System.Drawing.Point(0, 96);
            this.dgrvListConfirm.Name = "dgrvListConfirm";
            this.dgrvListConfirm.Size = new System.Drawing.Size(800, 354);
            this.dgrvListConfirm.TabIndex = 1;
            // 
            // btnConfirmAll
            // 
            this.btnConfirmAll.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmAll.Location = new System.Drawing.Point(13, 53);
            this.btnConfirmAll.Name = "btnConfirmAll";
            this.btnConfirmAll.Size = new System.Drawing.Size(125, 37);
            this.btnConfirmAll.TabIndex = 2;
            this.btnConfirmAll.Text = "Confirm All";
            this.btnConfirmAll.UseVisualStyleBackColor = false;
            // 
            // FormConfirmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmAll);
            this.Controls.Add(this.dgrvListConfirm);
            this.Controls.Add(this.label1);
            this.Name = "FormConfirmData";
            this.Text = "FormConfirmData";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvListConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrvListConfirm;
        private System.Windows.Forms.Button btnConfirmAll;
    }
}