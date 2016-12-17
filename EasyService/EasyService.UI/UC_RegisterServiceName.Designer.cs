namespace EasyService.UI
{
    partial class UC_RegisterServiceName
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbSeviceName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSmallService = new System.Windows.Forms.CheckBox();
            this.cbxMajorService = new System.Windows.Forms.CheckBox();
            this.cbxNeedsReplacement = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Glacial Indifference", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "VALIDATIONS";
            // 
            // txbSeviceName
            // 
            this.txbSeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.txbSeviceName.Font = new System.Drawing.Font("Glacial Indifference", 14.25F);
            this.txbSeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.txbSeviceName.Location = new System.Drawing.Point(32, 50);
            this.txbSeviceName.Name = "txbSeviceName";
            this.txbSeviceName.Size = new System.Drawing.Size(509, 30);
            this.txbSeviceName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbSeviceName);
            this.panel1.Location = new System.Drawing.Point(44, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 113);
            this.panel1.TabIndex = 3;
            // 
            // cbxSmallService
            // 
            this.cbxSmallService.AutoSize = true;
            this.cbxSmallService.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSmallService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cbxSmallService.Location = new System.Drawing.Point(9, 61);
            this.cbxSmallService.Name = "cbxSmallService";
            this.cbxSmallService.Size = new System.Drawing.Size(137, 27);
            this.cbxSmallService.TabIndex = 4;
            this.cbxSmallService.Text = "Small Service";
            this.cbxSmallService.UseVisualStyleBackColor = true;
            // 
            // cbxMajorService
            // 
            this.cbxMajorService.AutoSize = true;
            this.cbxMajorService.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMajorService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cbxMajorService.Location = new System.Drawing.Point(193, 61);
            this.cbxMajorService.Name = "cbxMajorService";
            this.cbxMajorService.Size = new System.Drawing.Size(139, 27);
            this.cbxMajorService.TabIndex = 5;
            this.cbxMajorService.Text = "Major Service";
            this.cbxMajorService.UseVisualStyleBackColor = true;
            // 
            // cbxNeedsReplacement
            // 
            this.cbxNeedsReplacement.AutoSize = true;
            this.cbxNeedsReplacement.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNeedsReplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cbxNeedsReplacement.Location = new System.Drawing.Point(374, 61);
            this.cbxNeedsReplacement.Name = "cbxNeedsReplacement";
            this.cbxNeedsReplacement.Size = new System.Drawing.Size(190, 27);
            this.cbxNeedsReplacement.TabIndex = 6;
            this.cbxNeedsReplacement.Text = "Needs Replacement";
            this.cbxNeedsReplacement.UseVisualStyleBackColor = true;
            this.cbxNeedsReplacement.CheckedChanged += new System.EventHandler(this.cbxNeedsReplacement_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxSmallService);
            this.panel2.Controls.Add(this.cbxNeedsReplacement);
            this.panel2.Controls.Add(this.cbxMajorService);
            this.panel2.Location = new System.Drawing.Point(44, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 114);
            this.panel2.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(343, 490);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(286, 69);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.cmbItemCategory.Font = new System.Drawing.Font("Glacial Indifference", 14.25F);
            this.cmbItemCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(83, 53);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(308, 31);
            this.cmbItemCategory.TabIndex = 2;
            // 
            // pnlReplace
            // 
            this.pnlReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlReplace.Controls.Add(this.label4);
            this.pnlReplace.Controls.Add(this.cmbItemCategory);
            this.pnlReplace.Location = new System.Drawing.Point(44, 332);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(585, 107);
            this.pnlReplace.TabIndex = 10;
            this.pnlReplace.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Glacial Indifference", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "REPLACEMENT CATEGORY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "SERVICE NAME";
            // 
            // UC_RegisterServiceName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.pnlReplace);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.Name = "UC_RegisterServiceName";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_RegisterServiceName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlReplace.ResumeLayout(false);
            this.pnlReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSeviceName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxSmallService;
        private System.Windows.Forms.CheckBox cbxMajorService;
        private System.Windows.Forms.CheckBox cbxNeedsReplacement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.Panel pnlReplace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
