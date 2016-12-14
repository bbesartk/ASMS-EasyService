namespace EasyService.UI
{
    partial class UC_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgNotifications = new System.Windows.Forms.DataGridView();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cubicCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbLicensePlate = new System.Windows.Forms.RadioButton();
            this.lblNotificiations = new System.Windows.Forms.Label();
            this.rbVIN = new System.Windows.Forms.RadioButton();
            this.btnKerko = new System.Windows.Forms.Button();
            this.txbKerko = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNotifications
            // 
            this.dgNotifications.AllowUserToAddRows = false;
            this.dgNotifications.AllowUserToDeleteRows = false;
            this.dgNotifications.AllowUserToResizeColumns = false;
            this.dgNotifications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNotifications.AutoGenerateColumns = false;
            this.dgNotifications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.dgNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgNotifications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNotifications.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNotifications.ColumnHeadersHeight = 30;
            this.dgNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateDataGridViewTextBoxColumn,
            this.vinDataGridViewTextBoxColumn,
            this.productionYearDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.cubicCDataGridViewTextBoxColumn});
            this.dgNotifications.DataSource = this.vehicleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNotifications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNotifications.EnableHeadersVisualStyles = false;
            this.dgNotifications.Location = new System.Drawing.Point(15, 209);
            this.dgNotifications.MultiSelect = false;
            this.dgNotifications.Name = "dgNotifications";
            this.dgNotifications.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNotifications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgNotifications.RowHeadersWidth = 45;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNotifications.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgNotifications.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNotifications.Size = new System.Drawing.Size(645, 309);
            this.dgNotifications.TabIndex = 12;
            this.dgNotifications.TabStop = false;
            this.dgNotifications.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNotifications_CellContentDoubleClick);
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
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(ES.EntityLayer.Vehicle.Vehicle);
            // 
            // rbLicensePlate
            // 
            this.rbLicensePlate.AutoSize = true;
            this.rbLicensePlate.Checked = true;
            this.rbLicensePlate.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.rbLicensePlate.Location = new System.Drawing.Point(69, 108);
            this.rbLicensePlate.Name = "rbLicensePlate";
            this.rbLicensePlate.Size = new System.Drawing.Size(131, 23);
            this.rbLicensePlate.TabIndex = 14;
            this.rbLicensePlate.TabStop = true;
            this.rbLicensePlate.Text = "LICENSE PLATE";
            this.rbLicensePlate.UseVisualStyleBackColor = true;
            // 
            // lblNotificiations
            // 
            this.lblNotificiations.AutoSize = true;
            this.lblNotificiations.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificiations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.lblNotificiations.Location = new System.Drawing.Point(11, 183);
            this.lblNotificiations.Name = "lblNotificiations";
            this.lblNotificiations.Size = new System.Drawing.Size(133, 23);
            this.lblNotificiations.TabIndex = 11;
            this.lblNotificiations.Text = "NOTIFICATIONS";
            // 
            // rbVIN
            // 
            this.rbVIN.AutoSize = true;
            this.rbVIN.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.rbVIN.Location = new System.Drawing.Point(241, 108);
            this.rbVIN.Name = "rbVIN";
            this.rbVIN.Size = new System.Drawing.Size(51, 23);
            this.rbVIN.TabIndex = 13;
            this.rbVIN.Text = "VIN";
            this.rbVIN.UseVisualStyleBackColor = true;
            // 
            // btnKerko
            // 
            this.btnKerko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnKerko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKerko.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnKerko.Location = new System.Drawing.Point(486, 43);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(103, 42);
            this.btnKerko.TabIndex = 10;
            this.btnKerko.Text = "SEARCH";
            this.btnKerko.UseVisualStyleBackColor = false;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // txbKerko
            // 
            this.txbKerko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKerko.Font = new System.Drawing.Font("Glacial Indifference", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKerko.ForeColor = System.Drawing.Color.Silver;
            this.txbKerko.Location = new System.Drawing.Point(69, 43);
            this.txbKerko.Name = "txbKerko";
            this.txbKerko.Size = new System.Drawing.Size(380, 42);
            this.txbKerko.TabIndex = 9;
            this.txbKerko.TabStop = false;
            this.txbKerko.Text = "search for a car...";
            this.txbKerko.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbKerko_MouseClick);
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.dgNotifications);
            this.Controls.Add(this.rbLicensePlate);
            this.Controls.Add(this.lblNotificiations);
            this.Controls.Add(this.rbVIN);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.txbKerko);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNotifications;
        private System.Windows.Forms.RadioButton rbLicensePlate;
        private System.Windows.Forms.Label lblNotificiations;
        private System.Windows.Forms.RadioButton rbVIN;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.TextBox txbKerko;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cubicCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
    }
}
