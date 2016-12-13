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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.cmbHour);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txbSubject);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(0, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 109);
            this.panel6.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8:00   ",
            "9:00   ",
            "10:00 ",
            "11:00 ",
            "12:00 ",
            "13:00 ",
            "14:00",
            "15:00",
            "16:00"});
            this.comboBox1.Location = new System.Drawing.Point(267, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 27);
            this.comboBox1.TabIndex = 18;
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
            // cmbHour
            // 
            this.cmbHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHour.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.cmbHour.ForeColor = System.Drawing.Color.White;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "8:00   ",
            "9:00   ",
            "10:00 ",
            "11:00 ",
            "12:00 ",
            "13:00 ",
            "14:00",
            "15:00",
            "16:00"});
            this.cmbHour.Location = new System.Drawing.Point(105, 63);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(88, 27);
            this.cmbHour.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metropolis Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "END:";
            // 
            // txbSubject
            // 
            this.txbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.txbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSubject.Font = new System.Drawing.Font("Metropolis Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSubject.Location = new System.Drawing.Point(56, 18);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(335, 24);
            this.txbSubject.TabIndex = 17;
            this.txbSubject.TabStop = false;
            this.txbSubject.Text = " Appointment subject here";
            this.txbSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbSubject_MouseClick);
            this.txbSubject.MouseEnter += new System.EventHandler(this.txbSubject_MouseEnter);
            this.txbSubject.MouseLeave += new System.EventHandler(this.txbSubject_MouseLeave);
            this.txbSubject.MouseHover += new System.EventHandler(this.txbSubject_MouseHover);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel7.Controls.Add(this.monthCalendar1);
            this.panel7.Location = new System.Drawing.Point(4, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 141);
            this.panel7.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(247, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 51);
            this.panel2.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Metropolis Thin", 18F);
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(5, -16);
            this.monthCalendar1.MinDate = new System.DateTime(2016, 12, 13, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Metropolis Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "SLOT:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Glacial Indifference", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SLOT 1",
            "SLOT 2",
            "SLOT 3",
            "SLOT 4"});
            this.comboBox2.Location = new System.Drawing.Point(63, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 27);
            this.comboBox2.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.Gray;
            this.radioButton1.Location = new System.Drawing.Point(254, 187);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 20);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small Service";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.Gray;
            this.radioButton2.Location = new System.Drawing.Point(254, 222);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 20);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Major Service";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Metropolis Thin", 18F);
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 56);
            this.button1.TabIndex = 23;
            this.button1.Text = "ADD THIS APPOINTMEN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Metropolis Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "START:";
            // 
            // NewAppointmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(412, 365);
            this.MinimumSize = new System.Drawing.Size(412, 365);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}