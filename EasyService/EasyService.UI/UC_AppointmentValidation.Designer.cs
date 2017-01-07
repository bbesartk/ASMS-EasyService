namespace EasyService.UI
{
    partial class UC_AppointmentValidation
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
            this.ckbSaturday = new System.Windows.Forms.CheckBox();
            this.ckbSunday = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEndWork = new System.Windows.Forms.ComboBox();
            this.cmbStartWork = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbSaturday
            // 
            this.ckbSaturday.AutoSize = true;
            this.ckbSaturday.Font = new System.Drawing.Font("Glacial Indifference", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSaturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.ckbSaturday.Location = new System.Drawing.Point(82, 56);
            this.ckbSaturday.Name = "ckbSaturday";
            this.ckbSaturday.Size = new System.Drawing.Size(95, 24);
            this.ckbSaturday.TabIndex = 5;
            this.ckbSaturday.Text = "Saturday";
            this.ckbSaturday.UseVisualStyleBackColor = true;
            this.ckbSaturday.CheckedChanged += new System.EventHandler(this.ckbSaturday_CheckedChanged);
            // 
            // ckbSunday
            // 
            this.ckbSunday.AutoSize = true;
            this.ckbSunday.Font = new System.Drawing.Font("Glacial Indifference", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.ckbSunday.Location = new System.Drawing.Point(206, 56);
            this.ckbSunday.Name = "ckbSunday";
            this.ckbSunday.Size = new System.Drawing.Size(83, 24);
            this.ckbSunday.TabIndex = 6;
            this.ckbSunday.Text = "Sunday";
            this.ckbSunday.UseVisualStyleBackColor = true;
            this.ckbSunday.CheckedChanged += new System.EventHandler(this.ckbSunday_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ckbSunday);
            this.panel1.Controls.Add(this.ckbSaturday);
            this.panel1.Location = new System.Drawing.Point(21, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 113);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ACTIVATE WEEKENDS:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSlot);
            this.panel3.Location = new System.Drawing.Point(21, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 59);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ACTIVE SLOTS:";
            // 
            // txtSlot
            // 
            this.txtSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.txtSlot.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.txtSlot.Location = new System.Drawing.Point(176, 12);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(84, 33);
            this.txtSlot.TabIndex = 4;
            this.txtSlot.TextChanged += new System.EventHandler(this.txtSlot_TextChanged);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btnUpdateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAll.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnUpdateAll.Location = new System.Drawing.Point(498, 513);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(148, 51);
            this.btnUpdateAll.TabIndex = 10;
            this.btnUpdateAll.Text = "UPDATE ALL";
            this.btnUpdateAll.UseVisualStyleBackColor = false;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbEndWork);
            this.panel4.Controls.Add(this.cmbStartWork);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.panel4.Location = new System.Drawing.Point(21, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 119);
            this.panel4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "WORKING HOURS: ";
            // 
            // cmbEndWork
            // 
            this.cmbEndWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.cmbEndWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEndWork.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbEndWork.Items.AddRange(new object[] {
            "16:00",
            "17:00",
            "18:00"});
            this.cmbEndWork.Location = new System.Drawing.Point(377, 53);
            this.cmbEndWork.Name = "cmbEndWork";
            this.cmbEndWork.Size = new System.Drawing.Size(178, 33);
            this.cmbEndWork.TabIndex = 4;
            this.cmbEndWork.SelectedIndexChanged += new System.EventHandler(this.cmbEndWork_SelectedIndexChanged);
            // 
            // cmbStartWork
            // 
            this.cmbStartWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.cmbStartWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartWork.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbStartWork.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00"});
            this.cmbStartWork.Location = new System.Drawing.Point(82, 54);
            this.cmbStartWork.Name = "cmbStartWork";
            this.cmbStartWork.Size = new System.Drawing.Size(178, 33);
            this.cmbStartWork.TabIndex = 4;
            this.cmbStartWork.SelectedIndexChanged += new System.EventHandler(this.cmbStartWork_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(322, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "End:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label8.Location = new System.Drawing.Point(17, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Start:";
            // 
            // UC_AppointmentValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.panel1);
            this.Name = "UC_AppointmentValidation";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_AppointmentValidation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbSaturday;
        private System.Windows.Forms.CheckBox ckbSunday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEndWork;
        private System.Windows.Forms.ComboBox cmbStartWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
