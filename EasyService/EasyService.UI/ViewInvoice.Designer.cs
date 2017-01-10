namespace EasyService.UI
{
    partial class ViewInvoice
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblClientCity = new System.Windows.Forms.Label();
            this.lblClientPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.invoiceNr = new System.Windows.Forms.Label();
            this.invoiceDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.inspectionDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBillAndSave = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Client Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Glacial Indifference", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Service.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Glacial Indifference", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(14, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 58);
            this.label4.TabIndex = 9;
            this.label4.Text = "easy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Payment Details:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(59, 123);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(108, 19);
            this.lblClientName.TabIndex = 21;
            this.lblClientName.Text = "Client Name";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(59, 145);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(72, 19);
            this.lblClientAddress.TabIndex = 21;
            this.lblClientAddress.Text = "Address";
            // 
            // lblClientCity
            // 
            this.lblClientCity.AutoSize = true;
            this.lblClientCity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCity.Location = new System.Drawing.Point(59, 167);
            this.lblClientCity.Name = "lblClientCity";
            this.lblClientCity.Size = new System.Drawing.Size(54, 19);
            this.lblClientCity.TabIndex = 21;
            this.lblClientCity.Text = "City:";
            // 
            // lblClientPhoneNumber
            // 
            this.lblClientPhoneNumber.AutoSize = true;
            this.lblClientPhoneNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhoneNumber.Location = new System.Drawing.Point(59, 189);
            this.lblClientPhoneNumber.Name = "lblClientPhoneNumber";
            this.lblClientPhoneNumber.Size = new System.Drawing.Size(117, 19);
            this.lblClientPhoneNumber.TabIndex = 21;
            this.lblClientPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(59, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 19);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "EmailAddress";
            // 
            // invoiceNr
            // 
            this.invoiceNr.AutoSize = true;
            this.invoiceNr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNr.Location = new System.Drawing.Point(446, 123);
            this.invoiceNr.Name = "invoiceNr";
            this.invoiceNr.Size = new System.Drawing.Size(126, 19);
            this.invoiceNr.TabIndex = 21;
            this.invoiceNr.Text = "Invoice No: #";
            // 
            // invoiceDate
            // 
            this.invoiceDate.AutoSize = true;
            this.invoiceDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDate.Location = new System.Drawing.Point(446, 145);
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Size = new System.Drawing.Size(45, 19);
            this.invoiceDate.TabIndex = 21;
            this.invoiceDate.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(446, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "EmailAddress";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AutoGenerateColumns = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgItems.ColumnHeadersHeight = 30;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgItems.DataSource = this.inspectionDetailBindingSource;
            this.dgItems.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgItems.Location = new System.Drawing.Point(12, 274);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.Size = new System.Drawing.Size(635, 306);
            this.dgItems.TabIndex = 22;
            // 
            // inspectionDetailBindingSource
            // 
            this.inspectionDetailBindingSource.DataSource = typeof(ES.EntityLayer.Services.InspectionDetail);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 10);
            this.panel1.TabIndex = 23;
            // 
            // btnBillAndSave
            // 
            this.btnBillAndSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBillAndSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBillAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAndSave.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillAndSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnBillAndSave.Location = new System.Drawing.Point(399, 613);
            this.btnBillAndSave.Name = "btnBillAndSave";
            this.btnBillAndSave.Size = new System.Drawing.Size(248, 58);
            this.btnBillAndSave.TabIndex = 33;
            this.btnBillAndSave.Text = "BILL AND SAVE SERVICE";
            this.btnBillAndSave.UseVisualStyleBackColor = false;
            this.btnBillAndSave.Click += new System.EventHandler(this.btnBillAndSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 598);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 19);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total: ";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Location = new System.Drawing.Point(20, 652);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(117, 19);
            this.lblFinalTotal.TabIndex = 21;
            this.lblFinalTotal.Text = "Final Total:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(20, 625);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(54, 19);
            this.lblVAT.TabIndex = 21;
            this.lblVAT.Text = "VAT: ";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(659, 722);
            this.Controls.Add(this.btnBillAndSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblClientPhoneNumber);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblClientCity);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.invoiceDate);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.invoiceNr);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label3);
            this.Name = "ViewInvoice";
            this.Text = "ViewInvoice";
            this.Load += new System.EventHandler(this.ViewInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.Label lblClientCity;
        private System.Windows.Forms.Label lblClientPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label invoiceNr;
        private System.Windows.Forms.Label invoiceDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBillAndSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.BindingSource inspectionDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}