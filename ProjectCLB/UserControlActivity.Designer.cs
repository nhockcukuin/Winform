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
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnUpdateActivity = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.dgrActivity = new System.Windows.Forms.DataGridView();
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
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnDeleteActivity.FlatAppearance.BorderSize = 0;
            this.btnDeleteActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteActivity.ForeColor = System.Drawing.Color.White;
            this.btnDeleteActivity.Image = global::ProjectCLB.Properties.Resources.criss_cross;
            this.btnDeleteActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteActivity.Location = new System.Drawing.Point(247, 146);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(104, 34);
            this.btnDeleteActivity.TabIndex = 10;
            this.btnDeleteActivity.Text = "Xóa";
            this.btnDeleteActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteActivity.UseVisualStyleBackColor = false;
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnUpdateActivity.FlatAppearance.BorderSize = 0;
            this.btnUpdateActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateActivity.ForeColor = System.Drawing.Color.White;
            this.btnUpdateActivity.Image = global::ProjectCLB.Properties.Resources.pencil;
            this.btnUpdateActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateActivity.Location = new System.Drawing.Point(123, 146);
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.Size = new System.Drawing.Size(117, 34);
            this.btnUpdateActivity.TabIndex = 9;
            this.btnUpdateActivity.Text = "Chỉnh sửa";
            this.btnUpdateActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateActivity.UseVisualStyleBackColor = false;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnAddActivity.FlatAppearance.BorderSize = 0;
            this.btnAddActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActivity.ForeColor = System.Drawing.Color.White;
            this.btnAddActivity.Image = global::ProjectCLB.Properties.Resources.add;
            this.btnAddActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddActivity.Location = new System.Drawing.Point(3, 146);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(114, 34);
            this.btnAddActivity.TabIndex = 8;
            this.btnAddActivity.Text = "Thêm mới";
            this.btnAddActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddActivity.UseVisualStyleBackColor = false;
            // 
            // dgrActivity
            // 
            this.dgrActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrActivity.Location = new System.Drawing.Point(3, 186);
            this.dgrActivity.Name = "dgrActivity";
            this.dgrActivity.Size = new System.Drawing.Size(727, 319);
            this.dgrActivity.TabIndex = 7;
            // 
            // UserControlActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshActivity);
            this.Controls.Add(this.btnFindActivity);
            this.Controls.Add(this.tbxFindActivity);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnUpdateActivity);
            this.Controls.Add(this.btnAddActivity);
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
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button btnUpdateActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.DataGridView dgrActivity;
    }
}
