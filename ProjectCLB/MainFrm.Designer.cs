﻿namespace ProjectCLB
{
    partial class MainFrm
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
            this.mainPN1 = new System.Windows.Forms.Panel();
            this.pnColor = new System.Windows.Forms.Panel();
            this.pnContaint = new System.Windows.Forms.Panel();
            this.btnAboutUS = new System.Windows.Forms.Button();
            this.mainLB2 = new System.Windows.Forms.Label();
            this.mainLB1 = new System.Windows.Forms.Label();
            this.btnUserm = new System.Windows.Forms.Button();
            this.btnStatisticalm = new System.Windows.Forms.Button();
            this.btnActivitym = new System.Windows.Forms.Button();
            this.btnSVm = new System.Windows.Forms.Button();
            this.btnCLBm = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.userStatistical1 = new ProjectCLB.UserStatistical();
            this.userControlInformation1 = new ProjectCLB.UserControlInformation();
            this.userControlActivity1 = new ProjectCLB.UserControlActivity();
            this.userControlSV1 = new ProjectCLB.UserControlSV();
            this.userControlCLB1 = new ProjectCLB.UserControlCLB();
            this.mainPN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinize.Location = new System.Drawing.Point(821, 1);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(33, 23);
            this.btnMinize.TabIndex = 2;
            this.btnMinize.Text = "_";
            this.btnMinize.UseVisualStyleBackColor = true;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // mainPN1
            // 
            this.mainPN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.mainPN1.Controls.Add(this.pnColor);
            this.mainPN1.Controls.Add(this.pnContaint);
            this.mainPN1.Controls.Add(this.btnAboutUS);
            this.mainPN1.Controls.Add(this.mainLB2);
            this.mainPN1.Controls.Add(this.mainLB1);
            this.mainPN1.Controls.Add(this.btnUserm);
            this.mainPN1.Controls.Add(this.btnStatisticalm);
            this.mainPN1.Controls.Add(this.btnActivitym);
            this.mainPN1.Controls.Add(this.btnSVm);
            this.mainPN1.Controls.Add(this.btnCLBm);
            this.mainPN1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPN1.Location = new System.Drawing.Point(0, 0);
            this.mainPN1.Name = "mainPN1";
            this.mainPN1.Size = new System.Drawing.Size(180, 531);
            this.mainPN1.TabIndex = 3;
            // 
            // pnColor
            // 
            this.pnColor.BackColor = System.Drawing.Color.Brown;
            this.pnColor.Location = new System.Drawing.Point(0, 126);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(13, 62);
            this.pnColor.TabIndex = 5;
            // 
            // pnContaint
            // 
            this.pnContaint.Location = new System.Drawing.Point(180, 30);
            this.pnContaint.Name = "pnContaint";
            this.pnContaint.Size = new System.Drawing.Size(733, 508);
            this.pnContaint.TabIndex = 4;
            // 
            // btnAboutUS
            // 
            this.btnAboutUS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutUS.FlatAppearance.BorderSize = 0;
            this.btnAboutUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUS.Image = global::ProjectCLB.Properties.Resources.question;
            this.btnAboutUS.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAboutUS.Location = new System.Drawing.Point(0, 493);
            this.btnAboutUS.Name = "btnAboutUS";
            this.btnAboutUS.Size = new System.Drawing.Size(42, 38);
            this.btnAboutUS.TabIndex = 4;
            this.btnAboutUS.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAboutUS.UseVisualStyleBackColor = true;
            this.btnAboutUS.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainLB2
            // 
            this.mainLB2.AutoSize = true;
            this.mainLB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLB2.Location = new System.Drawing.Point(46, 59);
            this.mainLB2.Name = "mainLB2";
            this.mainLB2.Size = new System.Drawing.Size(59, 20);
            this.mainLB2.TabIndex = 2;
            this.mainLB2.Text = "_____";
            // 
            // mainLB1
            // 
            this.mainLB1.AutoSize = true;
            this.mainLB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLB1.Location = new System.Drawing.Point(24, 23);
            this.mainLB1.Name = "mainLB1";
            this.mainLB1.Size = new System.Drawing.Size(67, 16);
            this.mainLB1.TabIndex = 1;
            this.mainLB1.Text = "Xin chào";
            // 
            // btnUserm
            // 
            this.btnUserm.FlatAppearance.BorderSize = 0;
            this.btnUserm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserm.Image = global::ProjectCLB.Properties.Resources.user__3_1;
            this.btnUserm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserm.Location = new System.Drawing.Point(12, 398);
            this.btnUserm.Name = "btnUserm";
            this.btnUserm.Size = new System.Drawing.Size(162, 62);
            this.btnUserm.TabIndex = 0;
            this.btnUserm.Text = "Tài khoản";
            this.btnUserm.UseVisualStyleBackColor = true;
            this.btnUserm.Click += new System.EventHandler(this.btnUserm_Click);
            // 
            // btnStatisticalm
            // 
            this.btnStatisticalm.FlatAppearance.BorderSize = 0;
            this.btnStatisticalm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticalm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticalm.Image = global::ProjectCLB.Properties.Resources.paper;
            this.btnStatisticalm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisticalm.Location = new System.Drawing.Point(15, 330);
            this.btnStatisticalm.Name = "btnStatisticalm";
            this.btnStatisticalm.Size = new System.Drawing.Size(162, 62);
            this.btnStatisticalm.TabIndex = 0;
            this.btnStatisticalm.Text = "Thống kê";
            this.btnStatisticalm.UseVisualStyleBackColor = true;
            this.btnStatisticalm.Click += new System.EventHandler(this.btnStatisticalm_Click);
            // 
            // btnActivitym
            // 
            this.btnActivitym.FlatAppearance.BorderSize = 0;
            this.btnActivitym.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivitym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitym.Image = global::ProjectCLB.Properties.Resources.schedule;
            this.btnActivitym.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivitym.Location = new System.Drawing.Point(15, 262);
            this.btnActivitym.Name = "btnActivitym";
            this.btnActivitym.Size = new System.Drawing.Size(162, 62);
            this.btnActivitym.TabIndex = 0;
            this.btnActivitym.Text = "Hoạt động";
            this.btnActivitym.UseVisualStyleBackColor = true;
            this.btnActivitym.Click += new System.EventHandler(this.btnActivitym_Click);
            // 
            // btnSVm
            // 
            this.btnSVm.FlatAppearance.BorderSize = 0;
            this.btnSVm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVm.Image = global::ProjectCLB.Properties.Resources.team1;
            this.btnSVm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSVm.Location = new System.Drawing.Point(15, 194);
            this.btnSVm.Name = "btnSVm";
            this.btnSVm.Size = new System.Drawing.Size(162, 62);
            this.btnSVm.TabIndex = 0;
            this.btnSVm.Text = "Sinh viên";
            this.btnSVm.UseVisualStyleBackColor = true;
            this.btnSVm.Click += new System.EventHandler(this.btnSVm_Click);
            // 
            // btnCLBm
            // 
            this.btnCLBm.FlatAppearance.BorderSize = 0;
            this.btnCLBm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLBm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLBm.Image = global::ProjectCLB.Properties.Resources.trust;
            this.btnCLBm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLBm.Location = new System.Drawing.Point(15, 126);
            this.btnCLBm.Name = "btnCLBm";
            this.btnCLBm.Size = new System.Drawing.Size(162, 62);
            this.btnCLBm.TabIndex = 0;
            this.btnCLBm.Text = "Câu lạc bộ";
            this.btnCLBm.UseVisualStyleBackColor = true;
            this.btnCLBm.Click += new System.EventHandler(this.btnCLBm_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Image = global::ProjectCLB.Properties.Resources.restore;
            this.btnRestore.Location = new System.Drawing.Point(860, 1);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(28, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ProjectCLB.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(885, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userStatistical1
            // 
            this.userStatistical1.Location = new System.Drawing.Point(180, 27);
            this.userStatistical1.Name = "userStatistical1";
            this.userStatistical1.Size = new System.Drawing.Size(733, 501);
            this.userStatistical1.TabIndex = 8;
            // 
            // userControlInformation1
            // 
            this.userControlInformation1.Location = new System.Drawing.Point(180, 23);
            this.userControlInformation1.Name = "userControlInformation1";
            this.userControlInformation1.Size = new System.Drawing.Size(733, 508);
            this.userControlInformation1.TabIndex = 7;
            // 
            // userControlActivity1
            // 
            this.userControlActivity1.Location = new System.Drawing.Point(180, 23);
            this.userControlActivity1.Name = "userControlActivity1";
            this.userControlActivity1.Size = new System.Drawing.Size(733, 508);
            this.userControlActivity1.TabIndex = 6;
            // 
            // userControlSV1
            // 
            this.userControlSV1.Location = new System.Drawing.Point(180, 23);
            this.userControlSV1.Name = "userControlSV1";
            this.userControlSV1.Size = new System.Drawing.Size(733, 508);
            this.userControlSV1.TabIndex = 5;
            // 
            // userControlCLB1
            // 
            this.userControlCLB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(247)))));
            this.userControlCLB1.Location = new System.Drawing.Point(180, 23);
            this.userControlCLB1.Name = "userControlCLB1";
            this.userControlCLB1.Size = new System.Drawing.Size(733, 508);
            this.userControlCLB1.TabIndex = 4;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 531);
            this.Controls.Add(this.userStatistical1);
            this.Controls.Add(this.userControlInformation1);
            this.Controls.Add(this.userControlActivity1);
            this.Controls.Add(this.userControlSV1);
            this.Controls.Add(this.userControlCLB1);
            this.Controls.Add(this.mainPN1);
            this.Controls.Add(this.btnMinize);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.mainPN1.ResumeLayout(false);
            this.mainPN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinize;
        private System.Windows.Forms.Panel mainPN1;
        private System.Windows.Forms.Button btnStatisticalm;
        private System.Windows.Forms.Button btnActivitym;
        private System.Windows.Forms.Button btnSVm;
        private System.Windows.Forms.Button btnCLBm;
        private System.Windows.Forms.Button btnUserm;
        private System.Windows.Forms.Label mainLB2;
        private System.Windows.Forms.Label mainLB1;
        private System.Windows.Forms.Button btnAboutUS;
        private System.Windows.Forms.Panel pnContaint;
        private UserControlCLB userControlCLB1;
        private System.Windows.Forms.Panel pnColor;
        private UserControlSV userControlSV1;
        private UserControlActivity userControlActivity1;
        private UserControlInformation userControlInformation1;
        private UserStatistical userStatistical1;
    }
}