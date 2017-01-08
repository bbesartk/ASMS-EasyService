namespace EasyService.UI
{
    partial class NewClient
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
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlate
            // 
            this.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.ForeColor = System.Drawing.Color.Silver;
            this.txtPlate.Location = new System.Drawing.Point(256, 64);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(228, 33);
            this.txtPlate.TabIndex = 36;
            this.txtPlate.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Silver;
            this.txtType.Location = new System.Drawing.Point(256, 149);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(228, 33);
            this.txtType.TabIndex = 38;
            this.txtType.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glacial Indifference", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(130, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Vehicle plate:";
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnSaveDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetails.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.btnSaveDetails.Location = new System.Drawing.Point(379, 434);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(228, 58);
            this.btnSaveDetails.TabIndex = 49;
            this.btnSaveDetails.Text = "SAVE DETAILS";
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // txtOwner
            // 
            this.txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOwner.Font = new System.Drawing.Font("Glacial Indifference", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.ForeColor = System.Drawing.Color.Silver;
            this.txtOwner.Location = new System.Drawing.Point(256, 230);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(228, 33);
            this.txtOwner.TabIndex = 38;
            this.txtOwner.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Glacial Indifference", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(130, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Vehicle Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Glacial Indifference", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(130, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Owner Name:";
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(659, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPlate);
            this.Name = "NewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.NewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}