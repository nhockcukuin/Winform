namespace ProjectCLB
{
    partial class OptionActivity
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
            this.btnOptionJoin = new System.Windows.Forms.Button();
            this.btnOptionActivity = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOptionJoin
            // 
            this.btnOptionJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnOptionJoin.FlatAppearance.BorderSize = 0;
            this.btnOptionJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionJoin.ForeColor = System.Drawing.Color.White;
            this.btnOptionJoin.Location = new System.Drawing.Point(203, 76);
            this.btnOptionJoin.Name = "btnOptionJoin";
            this.btnOptionJoin.Size = new System.Drawing.Size(126, 34);
            this.btnOptionJoin.TabIndex = 14;
            this.btnOptionJoin.Text = "Tham gia";
            this.btnOptionJoin.UseVisualStyleBackColor = false;
            // 
            // btnOptionActivity
            // 
            this.btnOptionActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnOptionActivity.FlatAppearance.BorderSize = 0;
            this.btnOptionActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionActivity.ForeColor = System.Drawing.Color.White;
            this.btnOptionActivity.Location = new System.Drawing.Point(8, 77);
            this.btnOptionActivity.Name = "btnOptionActivity";
            this.btnOptionActivity.Size = new System.Drawing.Size(126, 34);
            this.btnOptionActivity.TabIndex = 13;
            this.btnOptionActivity.Text = "Hoạt động ";
            this.btnOptionActivity.UseVisualStyleBackColor = false;
            this.btnOptionActivity.Click += new System.EventHandler(this.btnOptionActivity_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ProjectCLB.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(314, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbOption
            // 
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.Location = new System.Drawing.Point(51, 29);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(241, 20);
            this.lbOption.TabIndex = 11;
            this.lbOption.Text = "Bạn muốn cập nhật thông tin";
            // 
            // OptionActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 133);
            this.Controls.Add(this.btnOptionJoin);
            this.Controls.Add(this.btnOptionActivity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOptionJoin;
        private System.Windows.Forms.Button btnOptionActivity;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbOption;
    }
}