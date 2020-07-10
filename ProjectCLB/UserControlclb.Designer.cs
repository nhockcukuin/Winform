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
            this.btnListJoinCLB = new System.Windows.Forms.Button();
            this.btnListCLB = new System.Windows.Forms.Button();
            this.btnFindClb = new System.Windows.Forms.Button();
            this.btnUpdateCLB = new System.Windows.Forms.Button();
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
            this.tbxFindClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFindClb.Location = new System.Drawing.Point(410, 46);
            this.tbxFindClb.Multiline = true;
            this.tbxFindClb.Name = "tbxFindClb";
            this.tbxFindClb.Size = new System.Drawing.Size(320, 36);
            this.tbxFindClb.TabIndex = 4;
            // 
            // btnListJoinCLB
            // 
            this.btnListJoinCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnListJoinCLB.FlatAppearance.BorderSize = 0;
            this.btnListJoinCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListJoinCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListJoinCLB.ForeColor = System.Drawing.Color.White;
            this.btnListJoinCLB.Image = global::ProjectCLB.Properties.Resources.list;
            this.btnListJoinCLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListJoinCLB.Location = new System.Drawing.Point(604, 146);
            this.btnListJoinCLB.Name = "btnListJoinCLB";
            this.btnListJoinCLB.Size = new System.Drawing.Size(126, 34);
            this.btnListJoinCLB.TabIndex = 7;
            this.btnListJoinCLB.Text = "Thành viên";
            this.btnListJoinCLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListJoinCLB.UseVisualStyleBackColor = false;
            this.btnListJoinCLB.Click += new System.EventHandler(this.btnListJoinCLB_Click);
            // 
            // btnListCLB
            // 
            this.btnListCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnListCLB.FlatAppearance.BorderSize = 0;
            this.btnListCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCLB.ForeColor = System.Drawing.Color.White;
            this.btnListCLB.Image = global::ProjectCLB.Properties.Resources.list__1_;
            this.btnListCLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCLB.Location = new System.Drawing.Point(472, 146);
            this.btnListCLB.Name = "btnListCLB";
            this.btnListCLB.Size = new System.Drawing.Size(126, 34);
            this.btnListCLB.TabIndex = 6;
            this.btnListCLB.Text = "Câu lạc bộ";
            this.btnListCLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListCLB.UseVisualStyleBackColor = false;
            this.btnListCLB.Click += new System.EventHandler(this.btnRefreshClb_Click);
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
            this.btnFindClb.Click += new System.EventHandler(this.btnFindClb_Click);
            // 
            // btnUpdateCLB
            // 
            this.btnUpdateCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnUpdateCLB.FlatAppearance.BorderSize = 0;
            this.btnUpdateCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCLB.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCLB.Image = global::ProjectCLB.Properties.Resources.update__1_;
            this.btnUpdateCLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCLB.Location = new System.Drawing.Point(3, 146);
            this.btnUpdateCLB.Name = "btnUpdateCLB";
            this.btnUpdateCLB.Size = new System.Drawing.Size(114, 34);
            this.btnUpdateCLB.TabIndex = 1;
            this.btnUpdateCLB.Text = "Cập nhật";
            this.btnUpdateCLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCLB.UseVisualStyleBackColor = false;
            this.btnUpdateCLB.Click += new System.EventHandler(this.btnAddClb_Click);
            // 
            // UserControlCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnListJoinCLB);
            this.Controls.Add(this.btnListCLB);
            this.Controls.Add(this.btnFindClb);
            this.Controls.Add(this.tbxFindClb);
            this.Controls.Add(this.btnUpdateCLB);
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
        private System.Windows.Forms.Button btnListCLB;
        private System.Windows.Forms.Button btnUpdateCLB;
        private System.Windows.Forms.Button btnListJoinCLB;
    }
}
