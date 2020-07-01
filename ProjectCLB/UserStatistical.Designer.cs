namespace ProjectCLB
{
    partial class UserStatistical
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
            this.btnRefreshStatistical = new System.Windows.Forms.Button();
            this.btnUpdateClb = new System.Windows.Forms.Button();
            this.btnAddClb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefreshStatistical
            // 
            this.btnRefreshStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnRefreshStatistical.FlatAppearance.BorderSize = 0;
            this.btnRefreshStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStatistical.ForeColor = System.Drawing.Color.White;
            this.btnRefreshStatistical.Image = global::ProjectCLB.Properties.Resources.update;
            this.btnRefreshStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshStatistical.Location = new System.Drawing.Point(604, 18);
            this.btnRefreshStatistical.Name = "btnRefreshStatistical";
            this.btnRefreshStatistical.Size = new System.Drawing.Size(126, 34);
            this.btnRefreshStatistical.TabIndex = 9;
            this.btnRefreshStatistical.Text = "Tải dữ liệu";
            this.btnRefreshStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshStatistical.UseVisualStyleBackColor = false;
            this.btnRefreshStatistical.Click += new System.EventHandler(this.btnRefreshStatistical_Click);
            // 
            // btnUpdateClb
            // 
            this.btnUpdateClb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnUpdateClb.FlatAppearance.BorderSize = 0;
            this.btnUpdateClb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClb.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClb.Image = global::ProjectCLB.Properties.Resources.pencil;
            this.btnUpdateClb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClb.Location = new System.Drawing.Point(123, 18);
            this.btnUpdateClb.Name = "btnUpdateClb";
            this.btnUpdateClb.Size = new System.Drawing.Size(117, 34);
            this.btnUpdateClb.TabIndex = 11;
            this.btnUpdateClb.Text = "Chỉnh sửa";
            this.btnUpdateClb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateClb.UseVisualStyleBackColor = false;
            // 
            // btnAddClb
            // 
            this.btnAddClb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnAddClb.FlatAppearance.BorderSize = 0;
            this.btnAddClb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClb.ForeColor = System.Drawing.Color.White;
            this.btnAddClb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClb.Location = new System.Drawing.Point(3, 18);
            this.btnAddClb.Name = "btnAddClb";
            this.btnAddClb.Size = new System.Drawing.Size(114, 34);
            this.btnAddClb.TabIndex = 10;
            this.btnAddClb.Text = "Thêm mới";
            this.btnAddClb.UseVisualStyleBackColor = false;
            // 
            // UserStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateClb);
            this.Controls.Add(this.btnAddClb);
            this.Controls.Add(this.btnRefreshStatistical);
            this.Name = "UserStatistical";
            this.Size = new System.Drawing.Size(733, 508);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefreshStatistical;
        private System.Windows.Forms.Button btnUpdateClb;
        private System.Windows.Forms.Button btnAddClb;
    }
}
