namespace ProjectCLB
{
    partial class UpdateJoinActivity
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseJoin = new System.Windows.Forms.Button();
            this.btnSaveJoin = new System.Windows.Forms.Button();
            this.lbJoin2 = new System.Windows.Forms.Label();
            this.lbJoin3 = new System.Windows.Forms.Label();
            this.lbJoin4 = new System.Windows.Forms.Label();
            this.tbxIDActivity = new System.Windows.Forms.TextBox();
            this.tbxIDActivityJoin = new System.Windows.Forms.TextBox();
            this.dateJoin = new System.Windows.Forms.DateTimePicker();
            this.lbJoin1 = new System.Windows.Forms.Label();
            this.cbxOptionJoinActivity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinize.Location = new System.Drawing.Point(261, 2);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(33, 23);
            this.btnMinize.TabIndex = 11;
            this.btnMinize.Text = "_";
            this.btnMinize.UseVisualStyleBackColor = true;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ProjectCLB.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(300, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseJoin
            // 
            this.btnCloseJoin.BackColor = System.Drawing.Color.Red;
            this.btnCloseJoin.FlatAppearance.BorderSize = 0;
            this.btnCloseJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseJoin.ForeColor = System.Drawing.Color.White;
            this.btnCloseJoin.Image = global::ProjectCLB.Properties.Resources.logout;
            this.btnCloseJoin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseJoin.Location = new System.Drawing.Point(183, 328);
            this.btnCloseJoin.Name = "btnCloseJoin";
            this.btnCloseJoin.Size = new System.Drawing.Size(98, 38);
            this.btnCloseJoin.TabIndex = 21;
            this.btnCloseJoin.Text = "Thoát";
            this.btnCloseJoin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseJoin.UseVisualStyleBackColor = false;
            this.btnCloseJoin.Click += new System.EventHandler(this.btnCloseJoin_Click);
            // 
            // btnSaveJoin
            // 
            this.btnSaveJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.btnSaveJoin.FlatAppearance.BorderSize = 0;
            this.btnSaveJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveJoin.ForeColor = System.Drawing.Color.White;
            this.btnSaveJoin.Image = global::ProjectCLB.Properties.Resources.saved;
            this.btnSaveJoin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveJoin.Location = new System.Drawing.Point(23, 328);
            this.btnSaveJoin.Name = "btnSaveJoin";
            this.btnSaveJoin.Size = new System.Drawing.Size(98, 38);
            this.btnSaveJoin.TabIndex = 20;
            this.btnSaveJoin.Text = "Lưu";
            this.btnSaveJoin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveJoin.UseVisualStyleBackColor = false;
            this.btnSaveJoin.Click += new System.EventHandler(this.btnSaveJoin_Click);
            // 
            // lbJoin2
            // 
            this.lbJoin2.AutoSize = true;
            this.lbJoin2.Location = new System.Drawing.Point(19, 140);
            this.lbJoin2.Name = "lbJoin2";
            this.lbJoin2.Size = new System.Drawing.Size(74, 13);
            this.lbJoin2.TabIndex = 22;
            this.lbJoin2.Text = "Mã hoạt động";
            // 
            // lbJoin3
            // 
            this.lbJoin3.AutoSize = true;
            this.lbJoin3.Location = new System.Drawing.Point(19, 192);
            this.lbJoin3.Name = "lbJoin3";
            this.lbJoin3.Size = new System.Drawing.Size(67, 13);
            this.lbJoin3.TabIndex = 23;
            this.lbJoin3.Text = "Mã sinh viên";
            // 
            // lbJoin4
            // 
            this.lbJoin4.AutoSize = true;
            this.lbJoin4.Location = new System.Drawing.Point(19, 249);
            this.lbJoin4.Name = "lbJoin4";
            this.lbJoin4.Size = new System.Drawing.Size(75, 13);
            this.lbJoin4.TabIndex = 24;
            this.lbJoin4.Text = "Ngày tham gia";
            // 
            // tbxIDActivity
            // 
            this.tbxIDActivity.Location = new System.Drawing.Point(119, 137);
            this.tbxIDActivity.Name = "tbxIDActivity";
            this.tbxIDActivity.Size = new System.Drawing.Size(200, 20);
            this.tbxIDActivity.TabIndex = 25;
            // 
            // tbxIDActivityJoin
            // 
            this.tbxIDActivityJoin.Location = new System.Drawing.Point(119, 185);
            this.tbxIDActivityJoin.Name = "tbxIDActivityJoin";
            this.tbxIDActivityJoin.Size = new System.Drawing.Size(200, 20);
            this.tbxIDActivityJoin.TabIndex = 26;
            // 
            // dateJoin
            // 
            this.dateJoin.Location = new System.Drawing.Point(119, 241);
            this.dateJoin.Name = "dateJoin";
            this.dateJoin.Size = new System.Drawing.Size(200, 20);
            this.dateJoin.TabIndex = 27;
            // 
            // lbJoin1
            // 
            this.lbJoin1.AutoSize = true;
            this.lbJoin1.Location = new System.Drawing.Point(19, 88);
            this.lbJoin1.Name = "lbJoin1";
            this.lbJoin1.Size = new System.Drawing.Size(52, 13);
            this.lbJoin1.TabIndex = 28;
            this.lbJoin1.Text = "Tùy chọn";
            this.lbJoin1.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxOptionJoinActivity
            // 
            this.cbxOptionJoinActivity.FormattingEnabled = true;
            this.cbxOptionJoinActivity.Location = new System.Drawing.Point(117, 85);
            this.cbxOptionJoinActivity.Name = "cbxOptionJoinActivity";
            this.cbxOptionJoinActivity.Size = new System.Drawing.Size(200, 21);
            this.cbxOptionJoinActivity.TabIndex = 29;
            // 
            // UpdateJoinActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 378);
            this.Controls.Add(this.cbxOptionJoinActivity);
            this.Controls.Add(this.lbJoin1);
            this.Controls.Add(this.dateJoin);
            this.Controls.Add(this.tbxIDActivityJoin);
            this.Controls.Add(this.tbxIDActivity);
            this.Controls.Add(this.lbJoin4);
            this.Controls.Add(this.lbJoin3);
            this.Controls.Add(this.lbJoin2);
            this.Controls.Add(this.btnCloseJoin);
            this.Controls.Add(this.btnSaveJoin);
            this.Controls.Add(this.btnMinize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateJoinActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateJoinActivity";
            this.Load += new System.EventHandler(this.UpdateJoinActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseJoin;
        private System.Windows.Forms.Button btnSaveJoin;
        private System.Windows.Forms.Label lbJoin2;
        private System.Windows.Forms.Label lbJoin3;
        private System.Windows.Forms.Label lbJoin4;
        private System.Windows.Forms.TextBox tbxIDActivity;
        private System.Windows.Forms.TextBox tbxIDActivityJoin;
        private System.Windows.Forms.DateTimePicker dateJoin;
        private System.Windows.Forms.Label lbJoin1;
        private System.Windows.Forms.ComboBox cbxOptionJoinActivity;
    }
}