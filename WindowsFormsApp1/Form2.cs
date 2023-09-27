using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BasicWebDataSetTableAdapters;

using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {


        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        private Main main;
        private MainLogic mainLogic;


        public Form2(Main main)
        {
            InitializeComponent();
            this.main = main;
            mainLogic = new MainLogic();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            #region Lấy dữ liệu 
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;
            string userID = textID.Text.ToUpper();
            string userName = textName.Text;
            string tel = textTel.Text;
            int disabled = checkDisabled.Checked ? 1 : 0;
            #endregion

            #region Kiểm tra và xử lý
            bool idExists = mainLogic.CheckIfIdExists(userID);

            if (textID.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập mã người dùng!", "Thông báo", MessageBoxButtons.OK);
                textID.Focus();
            }
            else if (!mainLogic.IsValidEmail(email))
            {
                label6.Text = "Email không hợp lệ.";
                label6.Visible = true;
            }
            else if (password != confirmPassword)
            {
                lblMess.Text = "Mật khẩu không khớp.";
                lblMess.Visible = true;
            }
            else if (idExists)
            {
                MessageBox.Show("Mã người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bool saved = mainLogic.SaveUser(userID, userName, password, email, tel, disabled);

                if (saved)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                    main.ReloadData();
                }
                else
                {
                    MessageBox.Show("Lưu không thành công. Kiểm tra lại thông tin người dùng.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            #endregion
        }

        public void btnNhaptiep_Click(object sender, EventArgs e)
        {
            #region Lấy dữ liệu 
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;
            string userID = textID.Text.ToUpper();
            string userName = textName.Text;
            string tel = textTel.Text;
            int disabled = checkDisabled.Checked ? 1 : 0;
            #endregion

            #region Kiểm tra và xử lý
            bool idExists = mainLogic.CheckIfIdExists(userID);

            if (textID.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập mã người dùng!", "Thông báo", MessageBoxButtons.OK);
                textID.Focus();
            }
            else if (!mainLogic.IsValidEmail(email))
            {
                label6.Text = "Email không hợp lệ.";
                label6.Visible = true;
                lblMess.Visible = false;
            }
            else if (password != confirmPassword)
            {
                lblMess.Text = "Mật khẩu không khớp.";
                lblMess.Visible = true;
                label6.Visible = false;
            }
            else if (idExists)
            {
                MessageBox.Show("Mã người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                textID.Clear();
                textName.Clear();
                textPassword.Clear();
                textConfirmPassword.Clear();
                textTel.Clear();
                textEmail.Clear();
                checkDisabled.Checked = false;
                lblMess.Visible = false;
                label6.Visible = false;
            }
            else
            {
                bool saved = mainLogic.SaveUser(userID, userName, password, email, tel, disabled);

                if (saved)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                    textID.Clear();
                    textName.Clear();
                    textPassword.Clear();
                    textConfirmPassword.Clear();
                    textTel.Clear();
                    textEmail.Clear();
                    checkDisabled.Checked = false;

                    main.ReloadData();
                }
                else
                {
                    MessageBox.Show("Lưu không thành công. Kiểm tra lại thông tin người dùng.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            #endregion
        }

        // Các sự kiện và phương thức khác ở đây...





        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
