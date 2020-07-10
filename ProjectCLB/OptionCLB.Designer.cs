namespace ProjectCLB
{
    partial class OptionCLB
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
            this.lbOption = new System.Windows.Forms.Label();
            this.btnOptionCLB = new System.Windows.Forms.Button();
            this.btnOptionJoin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOption
            // 
            this.lbOption.AutoSize = true;
            this.lbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.Location = new System.Drawing.Point(59, 27);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(241, 20);
            this.lbOption.TabIndex = 0;
            this.lbOption.Text = "Bạn muốn cập nhật thông tin";
            // 
            // btnOptionCLB
            // 
            this.btnOptionCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnOptionCLB.FlatAppearance.BorderSize = 0;
            this.btnOptionCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionCLB.ForeColor = System.Drawing.Color.White;
            this.btnOptionCLB.Location = new System.Drawing.Point(16, 75);
            this.btnOptionCLB.Name = "btnOptionCLB";
            this.btnOptionCLB.Size = new System.Drawing.Size(126, 34);
            this.btnOptionCLB.TabIndex = 9;
            this.btnOptionCLB.Text = "Câu lạc bộ";
            this.btnOptionCLB.UseVisualStyleBackColor = false;
            this.btnOptionCLB.Click += new System.EventHandler(this.btnOptionCLB_Click);
            // 
            // btnOptionJoin
            // 
            this.btnOptionJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnOptionJoin.FlatAppearance.BorderSize = 0;
            this.btnOptionJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionJoin.ForeColor = System.Drawing.Color.White;
            this.btnOptionJoin.Location = new System.Drawing.Point(211, 74);
            this.btnOptionJoin.Name = "btnOptionJoin";
            this.btnOptionJoin.Size = new System.Drawing.Size(126, 34);
            this.btnOptionJoin.TabIndex = 10;
            this.btnOptionJoin.Text = "Thành viên";
            this.btnOptionJoin.UseVisualStyleBackColor = false;
            this.btnOptionJoin.Click += new System.EventHandler(this.btnOptionJoin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ProjectCLB.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(322, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OptionCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 137);
            this.Controls.Add(this.btnOptionJoin);
            this.Controls.Add(this.btnOptionCLB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionCLB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionCLB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOptionCLB;
        private System.Windows.Forms.Button btnOptionJoin;
    }
}