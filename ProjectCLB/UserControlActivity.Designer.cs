namespace ProjectCLB
{
    partial class UserControlActivity
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
            this.btnRefreshActivity = new System.Windows.Forms.Button();
            this.btnFindActivity = new System.Windows.Forms.Button();
            this.tbxFindActivity = new System.Windows.Forms.TextBox();
            this.dgrActivity = new System.Windows.Forms.DataGridView();
            this.btnUpdateActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshActivity
            // 
            this.btnRefreshActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnRefreshActivity.FlatAppearance.BorderSize = 0;
            this.btnRefreshActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshActivity.ForeColor = System.Drawing.Color.White;
            this.btnRefreshActivity.Image = global::ProjectCLB.Properties.Resources.update;
            this.btnRefreshActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshActivity.Location = new System.Drawing.Point(604, 146);
            this.btnRefreshActivity.Name = "btnRefreshActivity";
            this.btnRefreshActivity.Size = new System.Drawing.Size(126, 34);
            this.btnRefreshActivity.TabIndex = 13;
            this.btnRefreshActivity.Text = "Tải dữ liệu";
            this.btnRefreshActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshActivity.UseVisualStyleBackColor = false;
            this.btnRefreshActivity.Click += new System.EventHandler(this.btnRefreshActivity_Click);
            // 
            // btnFindActivity
            // 
            this.btnFindActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnFindActivity.FlatAppearance.BorderSize = 0;
            this.btnFindActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindActivity.ForeColor = System.Drawing.Color.White;
            this.btnFindActivity.Image = global::ProjectCLB.Properties.Resources.magnifying_glass;
            this.btnFindActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindActivity.Location = new System.Drawing.Point(291, 46);
            this.btnFindActivity.Name = "btnFindActivity";
            this.btnFindActivity.Size = new System.Drawing.Size(113, 36);
            this.btnFindActivity.TabIndex = 12;
            this.btnFindActivity.Text = "Tìm kiếm";
            this.btnFindActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindActivity.UseVisualStyleBackColor = false;
            // 
            // tbxFindActivity
            // 
            this.tbxFindActivity.Location = new System.Drawing.Point(410, 46);
            this.tbxFindActivity.Multiline = true;
            this.tbxFindActivity.Name = "tbxFindActivity";
            this.tbxFindActivity.Size = new System.Drawing.Size(320, 36);
            this.tbxFindActivity.TabIndex = 11;
            // 
            // dgrActivity
            // 
            this.dgrActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrActivity.Location = new System.Drawing.Point(3, 186);
            this.dgrActivity.Name = "dgrActivity";
            this.dgrActivity.Size = new System.Drawing.Size(727, 319);
            this.dgrActivity.TabIndex = 7;
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnUpdateActivity.FlatAppearance.BorderSize = 0;
            this.btnUpdateActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateActivity.ForeColor = System.Drawing.Color.White;
            this.btnUpdateActivity.Image = global::ProjectCLB.Properties.Resources.update__1_;
            this.btnUpdateActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateActivity.Location = new System.Drawing.Point(3, 146);
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.Size = new System.Drawing.Size(114, 34);
            this.btnUpdateActivity.TabIndex = 14;
            this.btnUpdateActivity.Text = "Cập nhật";
            this.btnUpdateActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateActivity.UseVisualStyleBackColor = false;
            this.btnUpdateActivity.Click += new System.EventHandler(this.btnUpdateActivity_Click);
            // 
            // UserControlActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateActivity);
            this.Controls.Add(this.btnRefreshActivity);
            this.Controls.Add(this.btnFindActivity);
            this.Controls.Add(this.tbxFindActivity);
            this.Controls.Add(this.dgrActivity);
            this.Name = "UserControlActivity";
            this.Size = new System.Drawing.Size(733, 508);
            ((System.ComponentModel.ISupportInitialize)(this.dgrActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshActivity;
        private System.Windows.Forms.Button btnFindActivity;
        private System.Windows.Forms.TextBox tbxFindActivity;
        private System.Windows.Forms.DataGridView dgrActivity;
        private System.Windows.Forms.Button btnUpdateActivity;
    }
}
