namespace WindowsFormsApp1
{
    partial class Form4
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
            this.checkDisabled = new System.Windows.Forms.CheckBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkDisabled
            // 
            this.checkDisabled.AutoSize = true;
            this.checkDisabled.Location = new System.Drawing.Point(182, 277);
            this.checkDisabled.Name = "checkDisabled";
            this.checkDisabled.Size = new System.Drawing.Size(114, 20);
            this.checkDisabled.TabIndex = 29;
            this.checkDisabled.Text = "Không hiển thị ";
            this.checkDisabled.UseVisualStyleBackColor = true;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(179, 234);
            this.textTel.Name = "textTel";
            this.textTel.ReadOnly = true;
            this.textTel.Size = new System.Drawing.Size(297, 22);
            this.textTel.TabIndex = 28;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(179, 183);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(297, 22);
            this.textEmail.TabIndex = 27;
            //this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(179, 127);
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(297, 22);
            this.textPassword.TabIndex = 25;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(179, 76);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(297, 22);
            this.textName.TabIndex = 24;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(179, 24);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(297, 22);
            this.textID.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã nhân viên ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 318);
            this.Controls.Add(this.checkDisabled);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
           // this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkDisabled;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}