namespace EasyService.UI
{
    partial class AddAppointments
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
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExistingClient = new System.Windows.Forms.RadioButton();
            this.rbNewClient = new System.Windows.Forms.RadioButton();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKoha = new System.Windows.Forms.Label();
            this.cmbKoha = new System.Windows.Forms.ComboBox();
            this.cmbAvailableSlot = new System.Windows.Forms.ComboBox();
            this.lblSlot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.AllowDrop = true;
            this.dtpAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAppointment.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.CalendarForeColor = System.Drawing.Color.Coral;
            this.dtpAppointment.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dtpAppointment.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtpAppointment.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpAppointment.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dtpAppointment.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpAppointment.Font = new System.Drawing.Font("Glacial Indifference", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointment.Location = new System.Drawing.Point(7, 82);
            this.dtpAppointment.MinDate = new System.DateTime(2016, 12, 23, 0, 0, 0, 0);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(472, 40);
            this.dtpAppointment.TabIndex = 0;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel1.Location = new System.Drawing.Point(408, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 46);
            this.panel1.TabIndex = 1;
            // 
            // rbExistingClient
            // 
            this.rbExistingClient.AutoSize = true;
            this.rbExistingClient.Checked = true;
            this.rbExistingClient.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExistingClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbExistingClient.Location = new System.Drawing.Point(9, 49);
            this.rbExistingClient.Name = "rbExistingClient";
            this.rbExistingClient.Size = new System.Drawing.Size(152, 27);
            this.rbExistingClient.TabIndex = 21;
            this.rbExistingClient.TabStop = true;
            this.rbExistingClient.Text = "Existing Client";
            this.rbExistingClient.UseVisualStyleBackColor = true;
            this.rbExistingClient.Visible = false;
            // 
            // rbNewClient
            // 
            this.rbNewClient.AutoSize = true;
            this.rbNewClient.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbNewClient.Location = new System.Drawing.Point(9, 49);
            this.rbNewClient.Name = "rbNewClient";
            this.rbNewClient.Size = new System.Drawing.Size(123, 27);
            this.rbNewClient.TabIndex = 21;
            this.rbNewClient.Text = "New Client";
            this.rbNewClient.UseVisualStyleBackColor = true;
            this.rbNewClient.Visible = false;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbServiceType.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.ForeColor = System.Drawing.Color.White;
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Small Service",
            "Major Service"});
            this.cmbServiceType.Location = new System.Drawing.Point(8, 37);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(121, 27);
            this.cmbServiceType.TabIndex = 22;
            this.cmbServiceType.SelectedIndexChanged += new System.EventHandler(this.cmbServiceType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Service type:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblKoha);
            this.panel3.Controls.Add(this.cmbKoha);
            this.panel3.Controls.Add(this.cmbAvailableSlot);
            this.panel3.Controls.Add(this.lblSlot);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbServiceType);
            this.panel3.Location = new System.Drawing.Point(-1, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 97);
            this.panel3.TabIndex = 20;
            // 
            // lblKoha
            // 
            this.lblKoha.AutoSize = true;
            this.lblKoha.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.lblKoha.Location = new System.Drawing.Point(348, 11);
            this.lblKoha.Name = "lblKoha";
            this.lblKoha.Size = new System.Drawing.Size(106, 19);
            this.lblKoha.TabIndex = 26;
            this.lblKoha.Text = "Prefered time:";
            // 
            // cmbKoha
            // 
            this.cmbKoha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbKoha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKoha.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.cmbKoha.ForeColor = System.Drawing.Color.White;
            this.cmbKoha.FormattingEnabled = true;
            this.cmbKoha.Location = new System.Drawing.Point(352, 39);
            this.cmbKoha.Name = "cmbKoha";
            this.cmbKoha.Size = new System.Drawing.Size(121, 27);
            this.cmbKoha.TabIndex = 25;
            this.cmbKoha.SelectedIndexChanged += new System.EventHandler(this.cmbKoha_SelectedIndexChanged);
            // 
            // cmbAvailableSlot
            // 
            this.cmbAvailableSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbAvailableSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAvailableSlot.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.cmbAvailableSlot.ForeColor = System.Drawing.Color.White;
            this.cmbAvailableSlot.FormattingEnabled = true;
            this.cmbAvailableSlot.Location = new System.Drawing.Point(179, 37);
            this.cmbAvailableSlot.Name = "cmbAvailableSlot";
            this.cmbAvailableSlot.Size = new System.Drawing.Size(122, 27);
            this.cmbAvailableSlot.TabIndex = 23;
            this.cmbAvailableSlot.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableSlot_SelectedIndexChanged);
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.lblSlot.Location = new System.Drawing.Point(175, 11);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(109, 19);
            this.lblSlot.TabIndex = 7;
            this.lblSlot.Text = "Available Slot:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Glacial Indifference", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.button1.Location = new System.Drawing.Point(784, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.txtSubject.Font = new System.Drawing.Font("Glacial Indifference", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(-1, 0);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(489, 40);
            this.txtSubject.TabIndex = 22;
            this.txtSubject.Text = "  Appointment Subject here...";
            this.txtSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSubject_MouseClick);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnAddAppointment.Enabled = false;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Glacial Indifference", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(-13, 217);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(501, 92);
            this.btnAddAppointment.TabIndex = 24;
            this.btnAddAppointment.Text = "ADD THIS APPOINTMENT";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // AddAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(485, 305);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.rbNewClient);
            this.Controls.Add(this.rbExistingClient);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.panel1);
            this.Name = "AddAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER NEW APPOINTMENT";
            this.Load += new System.EventHandler(this.AddAppointments_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbExistingClient;
        private System.Windows.Forms.RadioButton rbNewClient;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.ComboBox cmbAvailableSlot;
        private System.Windows.Forms.ComboBox cmbKoha;
        private System.Windows.Forms.Label lblKoha;
    }
}