namespace ProjectCLB
{
    partial class UpdateCLB
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
            this.btnMinize = new System.Windows.Forms.Button();
            this.UcbxTypeOption = new System.Windows.Forms.ComboBox();
            this.UtbxID = new System.Windows.Forms.TextBox();
            this.UtbxName = new System.Windows.Forms.TextBox();
            this.Ulb1 = new System.Windows.Forms.Label();
            this.Ulb2 = new System.Windows.Forms.Label();
            this.Ulb3 = new System.Windows.Forms.Label();
            this.Ulb4 = new System.Windows.Forms.Label();
            this.UbtnClose = new System.Windows.Forms.Button();
            this.UbtnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.UtbxQL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinize.Location = new System.Drawing.Point(325, 0);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(33, 23);
            this.btnMinize.TabIndex = 9;
            this.btnMinize.Text = "_";
            this.btnMinize.UseVisualStyleBackColor = true;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // UcbxTypeOption
            // 
            this.UcbxTypeOption.FormattingEnabled = true;
            this.UcbxTypeOption.Location = new System.Drawing.Point(145, 75);
            this.UcbxTypeOption.Name = "UcbxTypeOption";
            this.UcbxTypeOption.Size = new System.Drawing.Size(227, 21);
            this.UcbxTypeOption.TabIndex = 10;
            // 
            // UtbxID
            // 
            this.UtbxID.Location = new System.Drawing.Point(145, 125);
            this.UtbxID.Name = "UtbxID";
            this.UtbxID.Size = new System.Drawing.Size(227, 20);
            this.UtbxID.TabIndex = 12;
            // 
            // UtbxName
            // 
            this.UtbxName.Location = new System.Drawing.Point(145, 168);
            this.UtbxName.Name = "UtbxName";
            this.UtbxName.Size = new System.Drawing.Size(227, 20);
            this.UtbxName.TabIndex = 13;
            // 
            // Ulb1
            // 
            this.Ulb1.AutoSize = true;
            this.Ulb1.Location = new System.Drawing.Point(19, 75);
            this.Ulb1.Name = "Ulb1";
            this.Ulb1.Size = new System.Drawing.Size(52, 13);
            this.Ulb1.TabIndex = 14;
            this.Ulb1.Text = "Tùy chọn";
            // 
            // Ulb2
            // 
            this.Ulb2.AutoSize = true;
            this.Ulb2.Location = new System.Drawing.Point(19, 125);
            this.Ulb2.Name = "Ulb2";
            this.Ulb2.Size = new System.Drawing.Size(45, 13);
            this.Ulb2.TabIndex = 15;
            this.Ulb2.Text = "Mã CLB";
            // 
            // Ulb3
            // 
            this.Ulb3.AutoSize = true;
            this.Ulb3.Location = new System.Drawing.Point(19, 168);
            this.Ulb3.Name = "Ulb3";
            this.Ulb3.Size = new System.Drawing.Size(49, 13);
            this.Ulb3.TabIndex = 16;
            this.Ulb3.Text = "Tên CLB";
            // 
            // Ulb4
            // 
            this.Ulb4.AutoSize = true;
            this.Ulb4.Location = new System.Drawing.Point(19, 221);
            this.Ulb4.Name = "Ulb4";
            this.Ulb4.Size = new System.Drawing.Size(75, 13);
            this.Ulb4.TabIndex = 17;
            this.Ulb4.Text = "Đơn vị quản lý";
            // 
            // UbtnClose
            // 
            this.UbtnClose.BackColor = System.Drawing.Color.Red;
            this.UbtnClose.FlatAppearance.BorderSize = 0;
            this.UbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbtnClose.ForeColor = System.Drawing.Color.White;
            this.UbtnClose.Image = global::ProjectCLB.Properties.Resources.logout;
            this.UbtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UbtnClose.Location = new System.Drawing.Point(235, 292);
            this.UbtnClose.Name = "UbtnClose";
            this.UbtnClose.Size = new System.Drawing.Size(98, 38);
            this.UbtnClose.TabIndex = 19;
            this.UbtnClose.Text = "Thoát";
            this.UbtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UbtnClose.UseVisualStyleBackColor = false;
            this.UbtnClose.Click += new System.EventHandler(this.UbtnClose_Click);
            // 
            // UbtnSave
            // 
            this.UbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.UbtnSave.FlatAppearance.BorderSize = 0;
            this.UbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbtnSave.ForeColor = System.Drawing.Color.White;
            this.UbtnSave.Image = global::ProjectCLB.Properties.Resources.saved;
            this.UbtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UbtnSave.Location = new System.Drawing.Point(75, 292);
            this.UbtnSave.Name = "UbtnSave";
            this.UbtnSave.Size = new System.Drawing.Size(98, 38);
            this.UbtnSave.TabIndex = 18;
            this.UbtnSave.Text = "Lưu";
            this.UbtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UbtnSave.UseVisualStyleBackColor = false;
            this.UbtnSave.Click += new System.EventHandler(this.UbtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ProjectCLB.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(364, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UtbxQL
            // 
            this.UtbxQL.Location = new System.Drawing.Point(145, 213);
            this.UtbxQL.Name = "UtbxQL";
            this.UtbxQL.Size = new System.Drawing.Size(227, 20);
            this.UtbxQL.TabIndex = 20;
            // 
            // UpdateCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 342);
            this.Controls.Add(this.UtbxQL);
            this.Controls.Add(this.UbtnClose);
            this.Controls.Add(this.UbtnSave);
            this.Controls.Add(this.Ulb4);
            this.Controls.Add(this.Ulb3);
            this.Controls.Add(this.Ulb2);
            this.Controls.Add(this.Ulb1);
            this.Controls.Add(this.UtbxName);
            this.Controls.Add(this.UtbxID);
            this.Controls.Add(this.UcbxTypeOption);
            this.Controls.Add(this.btnMinize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCLB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCLB";
            this.Load += new System.EventHandler(this.UpdateCLB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox UcbxTypeOption;
        private System.Windows.Forms.TextBox UtbxID;
        private System.Windows.Forms.TextBox UtbxName;
        private System.Windows.Forms.Label Ulb1;
        private System.Windows.Forms.Label Ulb2;
        private System.Windows.Forms.Label Ulb3;
        private System.Windows.Forms.Label Ulb4;
        private System.Windows.Forms.Button UbtnClose;
        private System.Windows.Forms.Button UbtnSave;
        private System.Windows.Forms.TextBox UtbxQL;
    }
}