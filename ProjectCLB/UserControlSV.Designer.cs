namespace ProjectCLB
{
    partial class UserControlSV
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
            this.btnRefreshSV = new System.Windows.Forms.Button();
            this.btnFindSV = new System.Windows.Forms.Button();
            this.tbxFindClb = new System.Windows.Forms.TextBox();
            this.btnDeleteSV = new System.Windows.Forms.Button();
            this.btnUpdateSV = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.dgrSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshSV
            // 
            this.btnRefreshSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnRefreshSV.FlatAppearance.BorderSize = 0;
            this.btnRefreshSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSV.ForeColor = System.Drawing.Color.White;
            this.btnRefreshSV.Image = global::ProjectCLB.Properties.Resources.update;
            this.btnRefreshSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshSV.Location = new System.Drawing.Point(601, 149);
            this.btnRefreshSV.Name = "btnRefreshSV";
            this.btnRefreshSV.Size = new System.Drawing.Size(126, 34);
            this.btnRefreshSV.TabIndex = 13;
            this.btnRefreshSV.Text = "Tải dữ liệu";
            this.btnRefreshSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshSV.UseVisualStyleBackColor = false;
            this.btnRefreshSV.Click += new System.EventHandler(this.btnRefreshSV_Click);
            // 
            // btnFindSV
            // 
            this.btnFindSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnFindSV.FlatAppearance.BorderSize = 0;
            this.btnFindSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSV.ForeColor = System.Drawing.Color.White;
            this.btnFindSV.Image = global::ProjectCLB.Properties.Resources.magnifying_glass;
            this.btnFindSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindSV.Location = new System.Drawing.Point(291, 43);
            this.btnFindSV.Name = "btnFindSV";
            this.btnFindSV.Size = new System.Drawing.Size(113, 36);
            this.btnFindSV.TabIndex = 12;
            this.btnFindSV.Text = "Tìm kiếm";
            this.btnFindSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindSV.UseVisualStyleBackColor = false;
            // 
            // tbxFindClb
            // 
            this.tbxFindClb.Location = new System.Drawing.Point(410, 43);
            this.tbxFindClb.Multiline = true;
            this.tbxFindClb.Name = "tbxFindClb";
            this.tbxFindClb.Size = new System.Drawing.Size(320, 36);
            this.tbxFindClb.TabIndex = 11;
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnDeleteSV.FlatAppearance.BorderSize = 0;
            this.btnDeleteSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSV.Image = global::ProjectCLB.Properties.Resources.criss_cross;
            this.btnDeleteSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSV.Location = new System.Drawing.Point(244, 149);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Size = new System.Drawing.Size(104, 34);
            this.btnDeleteSV.TabIndex = 10;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSV.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSV
            // 
            this.btnUpdateSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnUpdateSV.FlatAppearance.BorderSize = 0;
            this.btnUpdateSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSV.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSV.Image = global::ProjectCLB.Properties.Resources.pencil;
            this.btnUpdateSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSV.Location = new System.Drawing.Point(120, 149);
            this.btnUpdateSV.Name = "btnUpdateSV";
            this.btnUpdateSV.Size = new System.Drawing.Size(117, 34);
            this.btnUpdateSV.TabIndex = 9;
            this.btnUpdateSV.Text = "Chỉnh sửa";
            this.btnUpdateSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSV.UseVisualStyleBackColor = false;
            // 
            // btnAddSV
            // 
            this.btnAddSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnAddSV.FlatAppearance.BorderSize = 0;
            this.btnAddSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.ForeColor = System.Drawing.Color.White;
            this.btnAddSV.Image = global::ProjectCLB.Properties.Resources.add;
            this.btnAddSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSV.Location = new System.Drawing.Point(0, 149);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(114, 34);
            this.btnAddSV.TabIndex = 8;
            this.btnAddSV.Text = "Thêm mới";
            this.btnAddSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSV.UseVisualStyleBackColor = false;
            // 
            // dgrSV
            // 
            this.dgrSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSV.Location = new System.Drawing.Point(0, 189);
            this.dgrSV.Name = "dgrSV";
            this.dgrSV.Size = new System.Drawing.Size(727, 319);
            this.dgrSV.TabIndex = 7;
            // 
            // UserControlSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshSV);
            this.Controls.Add(this.btnFindSV);
            this.Controls.Add(this.tbxFindClb);
            this.Controls.Add(this.btnDeleteSV);
            this.Controls.Add(this.btnUpdateSV);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.dgrSV);
            this.Name = "UserControlSV";
            this.Size = new System.Drawing.Size(733, 508);
            this.Load += new System.EventHandler(this.UserControlSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshSV;
        private System.Windows.Forms.Button btnFindSV;
        private System.Windows.Forms.TextBox tbxFindClb;
        private System.Windows.Forms.Button btnDeleteSV;
        private System.Windows.Forms.Button btnUpdateSV;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.DataGridView dgrSV;
    }
}
