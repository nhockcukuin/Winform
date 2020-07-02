namespace ProjectCLB
{
    partial class UserControlCLB
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
            this.dgrCLB = new System.Windows.Forms.DataGridView();
            this.tbxFindClb = new System.Windows.Forms.TextBox();
            this.btnRefreshClb = new System.Windows.Forms.Button();
            this.btnFindClb = new System.Windows.Forms.Button();
            this.btnAddClb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCLB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrCLB
            // 
            this.dgrCLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCLB.Location = new System.Drawing.Point(3, 186);
            this.dgrCLB.Name = "dgrCLB";
            this.dgrCLB.Size = new System.Drawing.Size(727, 319);
            this.dgrCLB.TabIndex = 0;
            this.dgrCLB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrCLB_CellContentClick);
            // 
            // tbxFindClb
            // 
            this.tbxFindClb.Location = new System.Drawing.Point(410, 46);
            this.tbxFindClb.Multiline = true;
            this.tbxFindClb.Name = "tbxFindClb";
            this.tbxFindClb.Size = new System.Drawing.Size(320, 36);
            this.tbxFindClb.TabIndex = 4;
            // 
            // btnRefreshClb
            // 
            this.btnRefreshClb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnRefreshClb.FlatAppearance.BorderSize = 0;
            this.btnRefreshClb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshClb.ForeColor = System.Drawing.Color.White;
            this.btnRefreshClb.Image = global::ProjectCLB.Properties.Resources.update;
            this.btnRefreshClb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshClb.Location = new System.Drawing.Point(604, 146);
            this.btnRefreshClb.Name = "btnRefreshClb";
            this.btnRefreshClb.Size = new System.Drawing.Size(126, 34);
            this.btnRefreshClb.TabIndex = 6;
            this.btnRefreshClb.Text = "Tải dữ liệu";
            this.btnRefreshClb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshClb.UseVisualStyleBackColor = false;
            this.btnRefreshClb.Click += new System.EventHandler(this.btnRefreshClb_Click);
            // 
            // btnFindClb
            // 
            this.btnFindClb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnFindClb.FlatAppearance.BorderSize = 0;
            this.btnFindClb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClb.ForeColor = System.Drawing.Color.White;
            this.btnFindClb.Image = global::ProjectCLB.Properties.Resources.magnifying_glass;
            this.btnFindClb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClb.Location = new System.Drawing.Point(291, 46);
            this.btnFindClb.Name = "btnFindClb";
            this.btnFindClb.Size = new System.Drawing.Size(113, 36);
            this.btnFindClb.TabIndex = 5;
            this.btnFindClb.Text = "Tìm kiếm";
            this.btnFindClb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindClb.UseVisualStyleBackColor = false;
            // 
            // btnAddClb
            // 
            this.btnAddClb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnAddClb.FlatAppearance.BorderSize = 0;
            this.btnAddClb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClb.ForeColor = System.Drawing.Color.White;
            this.btnAddClb.Image = global::ProjectCLB.Properties.Resources.update__1_;
            this.btnAddClb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClb.Location = new System.Drawing.Point(3, 146);
            this.btnAddClb.Name = "btnAddClb";
            this.btnAddClb.Size = new System.Drawing.Size(114, 34);
            this.btnAddClb.TabIndex = 1;
            this.btnAddClb.Text = "Cập nhật";
            this.btnAddClb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClb.UseVisualStyleBackColor = false;
            this.btnAddClb.Click += new System.EventHandler(this.btnAddClb_Click);
            // 
            // UserControlCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefreshClb);
            this.Controls.Add(this.btnFindClb);
            this.Controls.Add(this.tbxFindClb);
            this.Controls.Add(this.btnAddClb);
            this.Controls.Add(this.dgrCLB);
            this.Name = "UserControlCLB";
            this.Size = new System.Drawing.Size(733, 508);
            ((System.ComponentModel.ISupportInitialize)(this.dgrCLB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrCLB;
        private System.Windows.Forms.TextBox tbxFindClb;
        private System.Windows.Forms.Button btnFindClb;
        private System.Windows.Forms.Button btnRefreshClb;
        private System.Windows.Forms.Button btnAddClb;
    }
}
