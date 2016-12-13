namespace EasyService.UI
{
    partial class UC_Mechanic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbKerko = new System.Windows.Forms.TextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.rbRegisterPlate = new System.Windows.Forms.RadioButton();
            this.dgMechanic = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgMechanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnBack.Location = new System.Drawing.Point(28, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 42);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txbKerko
            // 
            this.txbKerko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKerko.ForeColor = System.Drawing.Color.Silver;
            this.txbKerko.Location = new System.Drawing.Point(69, 23);
            this.txbKerko.Name = "txbKerko";
            this.txbKerko.Size = new System.Drawing.Size(380, 40);
            this.txbKerko.TabIndex = 22;
            this.txbKerko.TabStop = false;
            this.txbKerko.Text = "search for a mechanic...";
            this.txbKerko.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbKerko_MouseClick);
            // 
            // btnKerko
            // 
            this.btnKerko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnKerko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKerko.Font = new System.Drawing.Font("Glacial Indifference", 15.75F);
            this.btnKerko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnKerko.Location = new System.Drawing.Point(489, 21);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(110, 42);
            this.btnKerko.TabIndex = 23;
            this.btnKerko.Text = "SEARCH";
            this.btnKerko.UseVisualStyleBackColor = false;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // rbRegisterPlate
            // 
            this.rbRegisterPlate.AutoSize = true;
            this.rbRegisterPlate.Checked = true;
            this.rbRegisterPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegisterPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.rbRegisterPlate.Location = new System.Drawing.Point(69, 88);
            this.rbRegisterPlate.Name = "rbRegisterPlate";
            this.rbRegisterPlate.Size = new System.Drawing.Size(133, 24);
            this.rbRegisterPlate.TabIndex = 25;
            this.rbRegisterPlate.TabStop = true;
            this.rbRegisterPlate.Text = "MECHANIC ID";
            this.rbRegisterPlate.UseVisualStyleBackColor = true;
            // 
            // dgMechanic
            // 
            this.dgMechanic.AllowUserToAddRows = false;
            this.dgMechanic.AllowUserToDeleteRows = false;
            this.dgMechanic.AllowUserToResizeColumns = false;
            this.dgMechanic.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMechanic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgMechanic.AutoGenerateColumns = false;
            this.dgMechanic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.dgMechanic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMechanic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgMechanic.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgMechanic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMechanic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgMechanic.ColumnHeadersHeight = 30;
            this.dgMechanic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMechanic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dgMechanic.DataSource = this.mechanicBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMechanic.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgMechanic.EnableHeadersVisualStyles = false;
            this.dgMechanic.Location = new System.Drawing.Point(28, 138);
            this.dgMechanic.MultiSelect = false;
            this.dgMechanic.Name = "dgMechanic";
            this.dgMechanic.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMechanic.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgMechanic.RowHeadersWidth = 45;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMechanic.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgMechanic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgMechanic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMechanic.Size = new System.Drawing.Size(443, 309);
            this.dgMechanic.TabIndex = 24;
            this.dgMechanic.TabStop = false;
            this.dgMechanic.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrivateClients_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mechanicBindingSource
            // 
            this.mechanicBindingSource.DataSource = typeof(ES.EntityLayer.Employees.Mechanic);
            // 
            // UC_Mechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgMechanic);
            this.Controls.Add(this.rbRegisterPlate);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.txbKerko);
            this.Name = "UC_Mechanic";
            this.Size = new System.Drawing.Size(675, 595);
            this.Load += new System.EventHandler(this.UC_Mechanic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMechanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbKerko;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.RadioButton rbRegisterPlate;
        private System.Windows.Forms.DataGridView dgMechanic;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mechanicBindingSource;
    }
}
