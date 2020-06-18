namespace ProjectCLB
{
    partial class LoginFrm
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
            this.lgBtn = new System.Windows.Forms.Button();
            this.lgUsername = new System.Windows.Forms.Label();
            this.lgtbxUser = new System.Windows.Forms.TextBox();
            this.lgPassword = new System.Windows.Forms.Label();
            this.lgtbxPass = new System.Windows.Forms.TextBox();
            this.lgIntro = new System.Windows.Forms.Label();
            this.lgClose = new System.Windows.Forms.Button();
            this.lgPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lgBtn
            // 
            this.lgBtn.BackColor = System.Drawing.Color.White;
            this.lgBtn.FlatAppearance.BorderSize = 0;
            this.lgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgBtn.Location = new System.Drawing.Point(49, 370);
            this.lgBtn.Name = "lgBtn";
            this.lgBtn.Size = new System.Drawing.Size(260, 50);
            this.lgBtn.TabIndex = 3;
            this.lgBtn.Text = "Đăng nhập";
            this.lgBtn.UseVisualStyleBackColor = false;
            this.lgBtn.Click += new System.EventHandler(this.lgBtn_Click);
            // 
            // lgUsername
            // 
            this.lgUsername.AutoSize = true;
            this.lgUsername.BackColor = System.Drawing.Color.Transparent;
            this.lgUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgUsername.ForeColor = System.Drawing.Color.Black;
            this.lgUsername.Location = new System.Drawing.Point(45, 180);
            this.lgUsername.Name = "lgUsername";
            this.lgUsername.Size = new System.Drawing.Size(102, 24);
            this.lgUsername.TabIndex = 1;
            this.lgUsername.Text = "Tài khoản";
            this.lgUsername.Click += new System.EventHandler(this.lgUsername_Click);
            // 
            // lgtbxUser
            // 
            this.lgtbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgtbxUser.Location = new System.Drawing.Point(49, 207);
            this.lgtbxUser.Multiline = true;
            this.lgtbxUser.Name = "lgtbxUser";
            this.lgtbxUser.Size = new System.Drawing.Size(260, 32);
            this.lgtbxUser.TabIndex = 1;
            // 
            // lgPassword
            // 
            this.lgPassword.AutoSize = true;
            this.lgPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgPassword.ForeColor = System.Drawing.Color.Black;
            this.lgPassword.ImageKey = "(none)";
            this.lgPassword.Location = new System.Drawing.Point(45, 274);
            this.lgPassword.Name = "lgPassword";
            this.lgPassword.Size = new System.Drawing.Size(94, 24);
            this.lgPassword.TabIndex = 1;
            this.lgPassword.Text = "Mật khẩu";
            // 
            // lgtbxPass
            // 
            this.lgtbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgtbxPass.Location = new System.Drawing.Point(49, 301);
            this.lgtbxPass.Multiline = true;
            this.lgtbxPass.Name = "lgtbxPass";
            this.lgtbxPass.PasswordChar = '*';
            this.lgtbxPass.Size = new System.Drawing.Size(260, 32);
            this.lgtbxPass.TabIndex = 2;
            // 
            // lgIntro
            // 
            this.lgIntro.AutoSize = true;
            this.lgIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgIntro.Location = new System.Drawing.Point(31, 115);
            this.lgIntro.Name = "lgIntro";
            this.lgIntro.Size = new System.Drawing.Size(295, 25);
            this.lgIntro.TabIndex = 2;
            this.lgIntro.Text = "Phần mềm quản lý câu lạc bộ";
            this.lgIntro.Click += new System.EventHandler(this.lgIntro_Click);
            // 
            // lgClose
            // 
            this.lgClose.FlatAppearance.BorderSize = 0;
            this.lgClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgClose.Image = global::ProjectCLB.Properties.Resources.close;
            this.lgClose.Location = new System.Drawing.Point(326, -1);
            this.lgClose.Name = "lgClose";
            this.lgClose.Size = new System.Drawing.Size(29, 23);
            this.lgClose.TabIndex = 4;
            this.lgClose.UseVisualStyleBackColor = true;
            this.lgClose.Click += new System.EventHandler(this.lgClose_Click);
            // 
            // lgPic
            // 
            this.lgPic.Image = global::ProjectCLB.Properties.Resources.user__3_;
            this.lgPic.Location = new System.Drawing.Point(147, 35);
            this.lgPic.Name = "lgPic";
            this.lgPic.Size = new System.Drawing.Size(64, 64);
            this.lgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lgPic.TabIndex = 3;
            this.lgPic.TabStop = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.lgClose);
            this.Controls.Add(this.lgPic);
            this.Controls.Add(this.lgIntro);
            this.Controls.Add(this.lgtbxPass);
            this.Controls.Add(this.lgtbxUser);
            this.Controls.Add(this.lgPassword);
            this.Controls.Add(this.lgUsername);
            this.Controls.Add(this.lgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lgPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lgBtn;
        private System.Windows.Forms.Label lgUsername;
        private System.Windows.Forms.TextBox lgtbxUser;
        private System.Windows.Forms.Label lgPassword;
        private System.Windows.Forms.TextBox lgtbxPass;
        private System.Windows.Forms.Label lgIntro;
        private System.Windows.Forms.PictureBox lgPic;
        private System.Windows.Forms.Button lgClose;
    }
}

