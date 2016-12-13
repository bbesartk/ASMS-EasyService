namespace EasyService.UI
{
    partial class UC_Vehicle
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.RadioButton rbLicensePlate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbVehicle = new System.Windows.Forms.TextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.dgVehicles = new System.Windows.Forms.DataGridView();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cubicCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSubscribedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rbVIN = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            rbLicensePlate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbVehicle
            // 
            this.txbVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVehicle.ForeColor = System.Drawing.Color.Silver;
            this.txbVehicle.Location = new System.Drawing.Point(69, 23);
            this.txbVehicle.Name = "txbVehicle";
            this.txbVehicle.Size = new System.Drawing.Size(380, 40);
            this.txbVehicle.TabIndex = 0;
            this.txbVehicle.Text = "search for a vehicle...";
            this.txbVehicle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbVehicle_MouseClick);
            // 
            // btnKerko
            // 
            this.btnKerko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKerko.Font = new System.Drawing.Font("Glacial Indifference", 15.75F);
            this.btnKerko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnKerko.Location = new System.Drawing.Point(489, 21);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(110, 42);
            this.btnKerko.TabIndex = 1;
            this.btnKerko.Text = "SEARCH";
            this.btnKerko.UseVisualStyleBackColor = false;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // rbLicensePlate
            // 
            rbLicensePlate.AutoSize = true;
            rbLicensePlate.Checked = true;
            rbLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rbLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            rbLicensePlate.Location = new System.Drawing.Point(69, 88);
            rbLicensePlate.Name = "rbLicensePlate";
            rbLicensePlate.Size = new System.Drawing.Size(122, 24);
            rbLicensePlate.TabIndex = 2;
            rbLicensePlate.TabStop = true;
            rbLicensePlate.Text = "License Plate";
            rbLicensePlate.UseVisualStyleBackColor = true;
            // 
            // dgVehicles
            // 
            this.dgVehicles.AllowUserToAddRows = false;
            this.dgVehicles.AllowUserToDeleteRows = false;
            this.dgVehicles.AllowUserToResizeColumns = false;
            this.dgVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVehicles.AutoGenerateColumns = false;
            this.dgVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.dgVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVehicles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVehicles.ColumnHeadersHeight = 30;
            this.dgVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateDataGridViewTextBoxColumn,
            this.vinDataGridViewTextBoxColumn,
            this.productionYearDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.cubicCDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.isSubscribedDataGridViewCheckBoxColumn});
            this.dgVehicles.DataSource = this.vehicleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgVehicles.EnableHeadersVisualStyles = false;
            this.dgVehicles.Location = new System.Drawing.Point(28, 138);
            this.dgVehicles.MultiSelect = false;
            this.dgVehicles.Name = "dgVehicles";
            this.dgVehicles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVehicles.RowHeadersWidth = 45;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVehicles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgVehicles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVehicles.Size = new System.Drawing.Size(421, 309);
            this.dgVehicles.TabIndex = 18;
            this.dgVehicles.TabStop = false;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(ES.EntityLayer.Vehicle.Vehicle);
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "Vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "Vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            this.vinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionYearDataGridViewTextBoxColumn
            // 
            this.productionYearDataGridViewTextBoxColumn.DataPropertyName = "ProductionYear";
            this.productionYearDataGridViewTextBoxColumn.HeaderText = "ProductionYear";
            this.productionYearDataGridViewTextBoxColumn.Name = "productionYearDataGridViewTextBoxColumn";
            this.productionYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cubicCDataGridViewTextBoxColumn
            // 
            this.cubicCDataGridViewTextBoxColumn.DataPropertyName = "CubicC";
            this.cubicCDataGridViewTextBoxColumn.HeaderText = "CubicC";
            this.cubicCDataGridViewTextBoxColumn.Name = "cubicCDataGridViewTextBoxColumn";
            this.cubicCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isSubscribedDataGridViewCheckBoxColumn
            // 
            this.isSubscribedDataGridViewCheckBoxColumn.DataPropertyName = "IsSubscribed";
            this.isSubscribedDataGridViewCheckBoxColumn.HeaderText = "IsSubscribed";
            this.isSubscribedDataGridViewCheckBoxColumn.Name = "isSubscribedDataGridViewCheckBoxColumn";
            this.isSubscribedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rbVIN
            // 
            this.rbVIN.AutoSize = true;
            this.rbVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.rbVIN.Location = new System.Drawing.Point(270, 88);
            this.rbVIN.Name = "rbVIN";
            this.rbVIN.Size = new System.Drawing.Size(54, 24);
            this.rbVIN.TabIndex = 19;
            this.rbVIN.TabStop = true;
            this.rbVIN.Text = "VIN";
            this.rbVIN.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnBack.Location = new System.Drawing.Point(28, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 42);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UC_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbVIN);
            this.Controls.Add(this.dgVehicles);
            this.Controls.Add(rbLicensePlate);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.txbVehicle);
            this.Name = "UC_Vehicle";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbVehicle;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.DataGridView dgVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cubicCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSubscribedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.RadioButton rbVIN;
        private System.Windows.Forms.Button btnBack;
    }
}
