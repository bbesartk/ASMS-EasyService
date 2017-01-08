namespace EasyService.UI
{
    partial class UC_Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgAppointment = new System.Windows.Forms.DataGridView();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNotificiations = new System.Windows.Forms.Label();
            this.immediateMediate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAppointment
            // 
            this.dgAppointment.AllowUserToAddRows = false;
            this.dgAppointment.AllowUserToDeleteRows = false;
            this.dgAppointment.AllowUserToResizeColumns = false;
            this.dgAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgAppointment.AutoGenerateColumns = false;
            this.dgAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.dgAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAppointment.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgAppointment.ColumnHeadersHeight = 30;
            this.dgAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn});
            this.dgAppointment.DataSource = this.appointmentBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAppointment.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgAppointment.EnableHeadersVisualStyles = false;
            this.dgAppointment.Location = new System.Drawing.Point(14, 134);
            this.dgAppointment.MultiSelect = false;
            this.dgAppointment.Name = "dgAppointment";
            this.dgAppointment.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgAppointment.RowHeadersWidth = 45;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppointment.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgAppointment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAppointment.Size = new System.Drawing.Size(645, 426);
            this.dgAppointment.TabIndex = 18;
            this.dgAppointment.TabStop = false;
            this.dgAppointment.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAppointment_CellContentDoubleClick);
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            this.vehicleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(ES.EntityLayer.Appointments.Appointment);
            // 
            // lblNotificiations
            // 
            this.lblNotificiations.AutoSize = true;
            this.lblNotificiations.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificiations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.lblNotificiations.Location = new System.Drawing.Point(10, 99);
            this.lblNotificiations.Name = "lblNotificiations";
            this.lblNotificiations.Size = new System.Drawing.Size(330, 23);
            this.lblNotificiations.TabIndex = 17;
            this.lblNotificiations.Text = "LIST OF APPOINTMENTS TO BE TREATED";
            // 
            // immediateMediate
            // 
            this.immediateMediate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.immediateMediate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.immediateMediate.Font = new System.Drawing.Font("Glacial Indifference", 15.75F);
            this.immediateMediate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.immediateMediate.Location = new System.Drawing.Point(395, 77);
            this.immediateMediate.Name = "immediateMediate";
            this.immediateMediate.Size = new System.Drawing.Size(264, 45);
            this.immediateMediate.TabIndex = 19;
            this.immediateMediate.Text = "IMMEDIATE APPOINTMENT";
            this.immediateMediate.UseVisualStyleBackColor = false;
            this.immediateMediate.Click += new System.EventHandler(this.immediateMediate_Click);
            // 
            // UC_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.immediateMediate);
            this.Controls.Add(this.dgAppointment);
            this.Controls.Add(this.lblNotificiations);
            this.Name = "UC_Appointments";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAppointment;
        private System.Windows.Forms.Label lblNotificiations;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfMeetingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotRowNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Button immediateMediate;
    }
}
