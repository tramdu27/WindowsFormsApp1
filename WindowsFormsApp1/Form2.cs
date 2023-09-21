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
using static C1.Util.Win.Win32;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;

        // SqlConnection con = new SqlConnection("Data Source=VIP\\SQL2017;Initial Catalog=BasicWeb;Integrated Security=True");

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;
            string userid = textID.Text.ToUpper();
            string username = textName.Text;

            string tel = textTel.Text;
            int disabled = checkDisabled.Checked ? 1 : 0;



            using (SqlConnection connection = new SqlConnection(cs))
            {
                if (textID.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã người dùng!", "Thông báo", MessageBoxButtons.OK);
                    textID.Focus();
                    return;
                }
                if (!IsValidEmail(email))
                {
                    label6.Text = "Email không hợp lệ.";
                    label6.Visible = true;
                }

                if (password != confirmPassword)
                {
                    lblMess.Text = "Mật khẩu không khớp.";
                    lblMess.Visible = true;
                }
                else
                {
                    label6.Visible = false;
                    lblMess.Visible = false;

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("pcd_CheckID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userID", userid);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Close();
                            MessageBox.Show("Mã người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                            textID.Focus();
                            return;
                        }
                        reader.Close();
                    }

                    using (SqlCommand command = new SqlCommand("pcd_SaveUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userid", userid);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@disabled", disabled);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }





        } 
        public void btnNhaptiep_Click(object sender, EventArgs e)
            {

                textID.Clear();
                textName.Clear();
                textPassword.Clear();
                textConfirmPassword.Clear();
                textTel.Clear();
                textEmail.Clear();
                checkDisabled.Checked = false;

            }
        }
    } 
