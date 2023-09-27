namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.checkDisabled = new System.Windows.Forms.CheckBox();
            this.btnNhaptiep = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblMess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(191, 25);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(297, 22);
            this.textID.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(191, 77);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(297, 22);
            this.textName.TabIndex = 6;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(191, 128);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(297, 22);
            this.textPassword.TabIndex = 7;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Location = new System.Drawing.Point(191, 184);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(297, 22);
            this.textConfirmPassword.TabIndex = 8;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(191, 243);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(297, 22);
            this.textEmail.TabIndex = 9;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(191, 294);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(297, 22);
            this.textTel.TabIndex = 10;
            // 
            // checkDisabled
            // 
            this.checkDisabled.AutoSize = true;
            this.checkDisabled.Location = new System.Drawing.Point(194, 337);
            this.checkDisabled.Name = "checkDisabled";
            this.checkDisabled.Size = new System.Drawing.Size(114, 20);
            this.checkDisabled.TabIndex = 11;
            this.checkDisabled.Text = "Không hiển thị ";
            this.checkDisabled.UseVisualStyleBackColor = true;
            // 
            // btnNhaptiep
            // 
            this.btnNhaptiep.Location = new System.Drawing.Point(194, 380);
            this.btnNhaptiep.Name = "btnNhaptiep";
            this.btnNhaptiep.Size = new System.Drawing.Size(83, 26);
            this.btnNhaptiep.TabIndex = 12;
            this.btnNhaptiep.Text = "Nhập tiếp";
            this.btnNhaptiep.UseVisualStyleBackColor = true;
            this.btnNhaptiep.Click += new System.EventHandler(this.btnNhaptiep_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(301, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 26);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(408, 380);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(83, 26);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Location = new System.Drawing.Point(191, 209);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(54, 16);
            this.lblMess.TabIndex = 15;
            this.lblMess.Text = "lblMess";
            this.lblMess.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên nhân viên";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMess);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnNhaptiep);
            this.Controls.Add(this.checkDisabled);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form2";
            this.Text = "Cập nhật thông tin người dùng";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.CheckBox checkDisabled;
        private System.Windows.Forms.Button btnNhaptiep;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}