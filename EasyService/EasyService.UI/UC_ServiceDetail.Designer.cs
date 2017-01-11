namespace EasyService.UI
{
    partial class UC_ServiceDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxServices = new System.Windows.Forms.CheckedListBox();
            this.rbSmallService = new System.Windows.Forms.RadioButton();
            this.rbMajorService = new System.Windows.Forms.RadioButton();
            this.btnBillAndSave = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbCurrentKm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.technicalWork = new System.Windows.Forms.Label();
            this.lblDateOfService = new System.Windows.Forms.Label();
            this.txbWork = new System.Windows.Forms.TextBox();
            this.txbVAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxServices
            // 
            this.listBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.listBoxServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxServices.CheckOnClick = true;
            this.listBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.IntegralHeight = false;
            this.listBoxServices.Location = new System.Drawing.Point(51, 166);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxServices.Size = new System.Drawing.Size(575, 310);
            this.listBoxServices.TabIndex = 0;
            this.listBoxServices.ThreeDCheckBoxes = true;
            this.listBoxServices.UseCompatibleTextRendering = true;
            this.listBoxServices.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rbSmallService
            // 
            this.rbSmallService.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbSmallService.AutoSize = true;
            this.rbSmallService.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.rbSmallService.Location = new System.Drawing.Point(352, 3);
            this.rbSmallService.Name = "rbSmallService";
            this.rbSmallService.Size = new System.Drawing.Size(217, 33);
            this.rbSmallService.TabIndex = 19;
            this.rbSmallService.Text = "SMALL SERVICE";
            this.rbSmallService.UseVisualStyleBackColor = true;
            this.rbSmallService.CheckedChanged += new System.EventHandler(this.rbMajorService_CheckedChanged);
            // 
            // rbMajorService
            // 
            this.rbMajorService.AutoSize = true;
            this.rbMajorService.Checked = true;
            this.rbMajorService.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMajorService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.rbMajorService.Location = new System.Drawing.Point(9, 3);
            this.rbMajorService.Name = "rbMajorService";
            this.rbMajorService.Size = new System.Drawing.Size(223, 33);
            this.rbMajorService.TabIndex = 19;
            this.rbMajorService.TabStop = true;
            this.rbMajorService.Text = "MAJOR SERVICE";
            this.rbMajorService.UseVisualStyleBackColor = true;
            this.rbMajorService.CheckedChanged += new System.EventHandler(this.rbMajorService_CheckedChanged);
            // 
            // btnBillAndSave
            // 
            this.btnBillAndSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnBillAndSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBillAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAndSave.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillAndSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnBillAndSave.Location = new System.Drawing.Point(378, 502);
            this.btnBillAndSave.Name = "btnBillAndSave";
            this.btnBillAndSave.Size = new System.Drawing.Size(248, 58);
            this.btnBillAndSave.TabIndex = 32;
            this.btnBillAndSave.Text = "BILL AND SAVE SERVICE";
            this.btnBillAndSave.UseVisualStyleBackColor = false;
            this.btnBillAndSave.Click += new System.EventHandler(this.btnBillAndSave_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.lblPrice.Location = new System.Drawing.Point(47, 502);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(102, 19);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "TOTAL PRICE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.rbSmallService);
            this.panel1.Controls.Add(this.rbMajorService);
            this.panel1.Location = new System.Drawing.Point(51, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 46);
            this.panel1.TabIndex = 35;
            // 
            // txbCurrentKm
            // 
            this.txbCurrentKm.Font = new System.Drawing.Font("Glacial Indifference", 15.75F);
            this.txbCurrentKm.ForeColor = System.Drawing.Color.Silver;
            this.txbCurrentKm.Location = new System.Drawing.Point(55, 115);
            this.txbCurrentKm.Name = "txbCurrentKm";
            this.txbCurrentKm.Size = new System.Drawing.Size(228, 33);
            this.txbCurrentKm.TabIndex = 36;
            this.txbCurrentKm.Text = "write...";
            this.txbCurrentKm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbCurrentKm_MouseClick);
            this.txbCurrentKm.TextChanged += new System.EventHandler(this.txbCurrentKm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Current KM";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.cmbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmployee.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbEmployee.Location = new System.Drawing.Point(445, 115);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(178, 33);
            this.cmbEmployee.TabIndex = 37;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(441, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Serviced By:";
            // 
            // technicalWork
            // 
            this.technicalWork.AutoSize = true;
            this.technicalWork.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicalWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.technicalWork.Location = new System.Drawing.Point(50, 529);
            this.technicalWork.Name = "technicalWork";
            this.technicalWork.Size = new System.Drawing.Size(99, 19);
            this.technicalWork.TabIndex = 41;
            this.technicalWork.Text = "INSPECTION:";
            // 
            // lblDateOfService
            // 
            this.lblDateOfService.AutoSize = true;
            this.lblDateOfService.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.lblDateOfService.Location = new System.Drawing.Point(374, 563);
            this.lblDateOfService.Name = "lblDateOfService";
            this.lblDateOfService.Size = new System.Drawing.Size(46, 19);
            this.lblDateOfService.TabIndex = 41;
            this.lblDateOfService.Text = "Date:";
            // 
            // txbWork
            // 
            this.txbWork.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.txbWork.ForeColor = System.Drawing.Color.Silver;
            this.txbWork.Location = new System.Drawing.Point(155, 525);
            this.txbWork.Name = "txbWork";
            this.txbWork.Size = new System.Drawing.Size(68, 27);
            this.txbWork.TabIndex = 36;
            this.txbWork.Text = "15";
            this.txbWork.TextChanged += new System.EventHandler(this.txbWork_TextChanged);
            // 
            // txbVAT
            // 
            this.txbVAT.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.txbVAT.ForeColor = System.Drawing.Color.Silver;
            this.txbVAT.Location = new System.Drawing.Point(155, 558);
            this.txbVAT.Name = "txbVAT";
            this.txbVAT.Size = new System.Drawing.Size(44, 27);
            this.txbVAT.TabIndex = 36;
            this.txbVAT.Text = "15";
            this.txbVAT.TextChanged += new System.EventHandler(this.txbVAT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(51, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "VAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(205, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(229, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "€";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(156, 502);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 19);
            this.lblTotalPrice.TabIndex = 34;
            // 
            // UC_ServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.lblDateOfService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.technicalWork);
            this.Controls.Add(this.txbVAT);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.txbWork);
            this.Controls.Add(this.txbCurrentKm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnBillAndSave);
            this.Controls.Add(this.listBoxServices);
            this.Name = "UC_ServiceDetail";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_ServiceDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox listBoxServices;
        private System.Windows.Forms.RadioButton rbSmallService;
        private System.Windows.Forms.RadioButton rbMajorService;
        private System.Windows.Forms.Button btnBillAndSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbCurrentKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label technicalWork;
        private System.Windows.Forms.Label lblDateOfService;
        private System.Windows.Forms.TextBox txbWork;
        private System.Windows.Forms.TextBox txbVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}
