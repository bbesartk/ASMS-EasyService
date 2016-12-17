namespace EasyService.UI
{
    partial class NewAppointmen
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSlot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMajor = new System.Windows.Forms.RadioButton();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.txbSubject);
            this.panel6.Location = new System.Drawing.Point(0, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 65);
            this.panel6.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyService.UI.Properties.Resources.octicons_4_3_0_triangle_left_256_0_ffffff_none;
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txbSubject
            // 
            this.txbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSubject.Font = new System.Drawing.Font("Metropolis Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSubject.Location = new System.Drawing.Point(56, 18);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(335, 24);
            this.txbSubject.TabIndex = 17;
            this.txbSubject.TabStop = false;
            this.txbSubject.Text = " Appointment subject here";
            this.txbSubject.MouseLeave += new System.EventHandler(this.txbSubject_MouseLeave);
            this.txbSubject.MouseHover += new System.EventHandler(this.txbSubject_MouseHover);
            // 
            // cmbHour
            // 
            this.cmbHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHour.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.cmbHour.ForeColor = System.Drawing.Color.White;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(312, 183);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(83, 27);
            this.cmbHour.TabIndex = 17;
            this.cmbHour.SelectedIndexChanged += new System.EventHandler(this.cmbHour_SelectedIndexChanged);
            this.cmbHour.SelectedValueChanged += new System.EventHandler(this.cmbHour_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metropolis Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "END:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Metropolis Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "START:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel7.Controls.Add(this.mcDate);
            this.panel7.Location = new System.Drawing.Point(4, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 141);
            this.panel7.TabIndex = 19;
            // 
            // mcDate
            // 
            this.mcDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.mcDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mcDate.Font = new System.Drawing.Font("Metropolis Thin", 18F);
            this.mcDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mcDate.Location = new System.Drawing.Point(5, -16);
            this.mcDate.MinDate = new System.DateTime(2016, 12, 13, 0, 0, 0, 0);
            this.mcDate.Name = "mcDate";
            this.mcDate.ShowToday = false;
            this.mcDate.TabIndex = 17;
            this.mcDate.TabStop = false;
            this.mcDate.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cmbSlot);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 51);
            this.panel2.TabIndex = 18;
            // 
            // cmbSlot
            // 
            this.cmbSlot.AllowDrop = true;
            this.cmbSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlot.Enabled = false;
            this.cmbSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSlot.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.cmbSlot.ForeColor = System.Drawing.Color.White;
            this.cmbSlot.FormattingEnabled = true;
            this.cmbSlot.Location = new System.Drawing.Point(163, 12);
            this.cmbSlot.Name = "cmbSlot";
            this.cmbSlot.Size = new System.Drawing.Size(73, 27);
            this.cmbSlot.TabIndex = 17;
            this.cmbSlot.SelectedValueChanged += new System.EventHandler(this.cmbSlot_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Metropolis Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "AVAILABLE SLOTS:";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Bold);
            this.rbSmall.ForeColor = System.Drawing.Color.White;
            this.rbSmall.Location = new System.Drawing.Point(6, 9);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(130, 20);
            this.rbSmall.TabIndex = 22;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small Service";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.chb_Checked);
            // 
            // rbMajor
            // 
            this.rbMajor.AutoSize = true;
            this.rbMajor.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Bold);
            this.rbMajor.ForeColor = System.Drawing.Color.White;
            this.rbMajor.Location = new System.Drawing.Point(6, 44);
            this.rbMajor.Name = "rbMajor";
            this.rbMajor.Size = new System.Drawing.Size(132, 20);
            this.rbMajor.TabIndex = 22;
            this.rbMajor.TabStop = true;
            this.rbMajor.Text = "Major Service";
            this.rbMajor.UseVisualStyleBackColor = true;
            this.rbMajor.CheckedChanged += new System.EventHandler(this.chb_Checked);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Metropolis Thin", 18F);
            this.btnAddAppointment.Location = new System.Drawing.Point(0, 266);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(398, 68);
            this.btnAddAppointment.TabIndex = 23;
            this.btnAddAppointment.Text = "ADD THIS APPOINTMEN";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.rbMajor);
            this.panel1.Controls.Add(this.rbSmall);
            this.panel1.Location = new System.Drawing.Point(248, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 73);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Metropolis", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(244, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "SERVICE TYPE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(245, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "HOUR:";
            // 
            // NewAppointmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 369);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 369);
            this.Name = "NewAppointmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.NewAppointmen_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.ComboBox cmbSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMajor;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}