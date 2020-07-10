namespace ProjectCLB
{
    partial class MemberofCLB
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
            this.lbMember1 = new System.Windows.Forms.Label();
            this.lbMember2 = new System.Windows.Forms.Label();
            this.lbMember3 = new System.Windows.Forms.Label();
            this.lbMember4 = new System.Windows.Forms.Label();
            this.lbMember5 = new System.Windows.Forms.Label();
            this.cbxMemberOption = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.UbtnClose = new System.Windows.Forms.Button();
            this.UbtnSave = new System.Windows.Forms.Button();
            this.btnMinize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxMemberJoin = new System.Windows.Forms.TextBox();
            this.tbxMemberCLB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMember1
            // 
            this.lbMember1.AutoSize = true;
            this.lbMember1.Location = new System.Drawing.Point(33, 90);
            this.lbMember1.Name = "lbMember1";
            this.lbMember1.Size = new System.Drawing.Size(52, 13);
            this.lbMember1.TabIndex = 0;
            this.lbMember1.Text = "Tùy chọn";
            // 
            // lbMember2
            // 
            this.lbMember2.AutoSize = true;
            this.lbMember2.Location = new System.Drawing.Point(33, 135);
            this.lbMember2.Name = "lbMember2";
            this.lbMember2.Size = new System.Drawing.Size(61, 13);
            this.lbMember2.TabIndex = 1;
            this.lbMember2.Text = "Thành viên";
            // 
            // lbMember3
            // 
            this.lbMember3.AutoSize = true;
            this.lbMember3.Location = new System.Drawing.Point(33, 187);
            this.lbMember3.Name = "lbMember3";
            this.lbMember3.Size = new System.Drawing.Size(58, 13);
            this.lbMember3.TabIndex = 2;
            this.lbMember3.Text = "Câu lạc bộ";
            // 
            // lbMember4
            // 
            this.lbMember4.AutoSize = true;
            this.lbMember4.Location = new System.Drawing.Point(33, 235);
            this.lbMember4.Name = "lbMember4";
            this.lbMember4.Size = new System.Drawing.Size(75, 13);
            this.lbMember4.TabIndex = 3;
            this.lbMember4.Text = "Ngày tham gia";
            // 
            // lbMember5
            // 
            this.lbMember5.AutoSize = true;
            this.lbMember5.Location = new System.Drawing.Point(33, 282);
            this.lbMember5.Name = "lbMember5";
            this.lbMember5.Size = new System.Drawing.Size(46, 13);
            this.lbMember5.TabIndex = 4;
            this.lbMember5.Text = "Ngày rời";
            // 
            // cbxMemberOption
            // 
            this.cbxMemberOption.FormattingEnabled = true;
            this.cbxMemberOption.Location = new System.Drawing.Point(138, 90);
            this.cbxMemberOption.Name = "cbxMemberOption";
            this.cbxMemberOption.Size = new System.Drawing.Size(208, 21);
            this.cbxMemberOption.TabIndex = 5;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(138, 235);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(208, 20);
            this.dateFrom.TabIndex = 8;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(138, 282);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(208, 20);
            this.dateTo.TabIndex = 9;
            // 
            // UbtnClose
            // 
            this.UbtnClose.BackColor = System.Drawing.Color.Red;
            this.UbtnClose.FlatAppearance.BorderSize = 0;
            this.UbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbtnClose.ForeColor = System.Drawing.Color.White;
            this.UbtnClose.Image = global::ProjectCLB.Properties.Resources.logout;
            this.UbtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UbtnClose.Location = new System.Drawing.Point(209, 332);
            this.UbtnClose.Name = "UbtnClose";
            this.UbtnClose.Size = new System.Drawing.Size(98, 38);
            this.UbtnClose.TabIndex = 21;
            this.UbtnClose.Text = "Thoát";
            this.UbtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UbtnClose.UseVisualStyleBackColor = false;
            this.UbtnClose.Click += new System.EventHandler(this.UbtnClose_Click);
            // 
            // UbtnSave
            // 
            this.UbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(186)))));
            this.UbtnSave.FlatAppearance.BorderSize = 0;
            this.UbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbtnSave.ForeColor = System.Drawing.Color.White;
            this.UbtnSave.Image = global::ProjectCLB.Properties.Resources.saved;
            this.UbtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UbtnSave.Location = new System.Drawing.Point(49, 332);
            this.UbtnSave.Name = "UbtnSave";
            this.UbtnSave.Size = new System.Drawing.Size(98, 38);
            this.UbtnSave.TabIndex = 20;
            this.UbtnSave.Text = "Lưu";
            this.UbtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UbtnSave.UseVisualStyleBackColor = false;
            this.UbtnSave.Click += new System.EventHandler(this.UbtnSave_Click);
            // 
            // btnMinize
            // 
            this.btnMinize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinize.Location = new System.Drawing.Point(313, 0);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(33, 23);
            this.btnMinize.TabIndex = 23;
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
            this.btnClose.Location = new System.Drawing.Point(352, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxMemberJoin
            // 
            this.tbxMemberJoin.Location = new System.Drawing.Point(138, 135);
            this.tbxMemberJoin.Name = "tbxMemberJoin";
            this.tbxMemberJoin.Size = new System.Drawing.Size(208, 20);
            this.tbxMemberJoin.TabIndex = 24;
            // 
            // tbxMemberCLB
            // 
            this.tbxMemberCLB.Location = new System.Drawing.Point(138, 179);
            this.tbxMemberCLB.Name = "tbxMemberCLB";
            this.tbxMemberCLB.Size = new System.Drawing.Size(208, 20);
            this.tbxMemberCLB.TabIndex = 25;
            // 
            // MemberofCLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.tbxMemberCLB);
            this.Controls.Add(this.tbxMemberJoin);
            this.Controls.Add(this.btnMinize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.UbtnClose);
            this.Controls.Add(this.UbtnSave);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.cbxMemberOption);
            this.Controls.Add(this.lbMember5);
            this.Controls.Add(this.lbMember4);
            this.Controls.Add(this.lbMember3);
            this.Controls.Add(this.lbMember2);
            this.Controls.Add(this.lbMember1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberofCLB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberofCLB";
            this.Load += new System.EventHandler(this.MemberofCLB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMember1;
        private System.Windows.Forms.Label lbMember2;
        private System.Windows.Forms.Label lbMember3;
        private System.Windows.Forms.Label lbMember4;
        private System.Windows.Forms.Label lbMember5;
        private System.Windows.Forms.ComboBox cbxMemberOption;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button UbtnClose;
        private System.Windows.Forms.Button UbtnSave;
        private System.Windows.Forms.Button btnMinize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxMemberJoin;
        private System.Windows.Forms.TextBox tbxMemberCLB;
    }
}