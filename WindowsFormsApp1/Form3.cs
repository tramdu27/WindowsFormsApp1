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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        private Main main;
        private MainLogic mainLogic;

        public Form3(string userID, string userName, string password, string email, string tel, bool disabled, Main main)
        {
            InitializeComponent();
            textID.Text = userID;
            textName.Text = userName;
            textPassword.Text = password;
            textEmail.Text = email;
            textTel.Text = tel;
            checkDisabled.Checked = disabled;
            this.main = main;
            mainLogic = new MainLogic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userID = textID.Text.Trim();
            string userName = textName.Text;
            string password = textPassword.Text;
            string email = textEmail.Text;
            string tel = textTel.Text;
            int disabled = checkDisabled.Checked ? 1 : 0;

            if (textID.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập mã người dùng!", "Thông báo", MessageBoxButtons.OK);
                textID.Focus();
                return;
            }
            if (!mainLogic.IsValidEmail(email))
            {
                label6.Text = "Email không hợp lệ.";
                label6.Visible = true;
                return;
            }

            bool updated = mainLogic.UpdateUser(userID, userName, password, email, tel, disabled);

            if (updated)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                textID.Clear();
                textName.Clear();
                textPassword.Clear();
                textTel.Clear();
                textEmail.Clear();
                checkDisabled.Checked = false;
                main.ReloadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công. Kiểm tra lại thông tin người dùng.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
    //    private Main main;
    //    private DataGridView dataGridView1;
    //    private SqlConnection connection;
    //    string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;


    //    public Form3(string userID, string userName, string password, string email, string tel, bool disabled, Main main)
    //    {
    //        InitializeComponent();

    //        textID.Text = userID;
    //        textName.Text = userName;
    //        textPassword.Text = password;
    //        textEmail.Text = email;
    //        textTel.Text = tel;
    //        checkDisabled.Checked = disabled;
    //        this.main = main;

    //    }

    //    private void Form3_Load(object sender, EventArgs e)
    //    {

    //    }
    //    private bool IsValidEmail(string email)
    //    {

    //        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    //        Regex regex = new Regex(pattern);

    //        return regex.IsMatch(email);
    //    }
    //    private void button2_Click(object sender, EventArgs e)
    //    {
    //        string userid = textID.Text.Trim();
    //        string username = textName.Text;
    //        string password = textPassword.Text;
    //        string email = textEmail.Text;
    //        string tel = textTel.Text;
    //        int disabled = checkDisabled.Checked ? 1 : 0;
    //        if (textID.TextLength == 0)
    //        {
    //            MessageBox.Show("Vui lòng nhập mã người dùng!", "Thông báo", MessageBoxButtons.OK);
    //            textID.Focus();
    //            return;
    //        }
    //        if (!IsValidEmail(email))
    //        {
    //            label6.Text = "Email không hợp lệ.";
    //            label6.Visible = true;

    //        }


    //        else
    //        {
    //            label6.Visible = false;
    //            lblMess.Visible = false;

    //            using (SqlConnection connection = new SqlConnection(cs))
    //            {
    //                connection.Open();
    //                using (SqlCommand command = new SqlCommand("pcd_UpdateUser", connection))
    //                {
    //                    command.CommandType = CommandType.StoredProcedure;


    //                    command.Parameters.AddWithValue("@userid", userid);
    //                    command.Parameters.AddWithValue("@username", username);
    //                    command.Parameters.AddWithValue("@password", password);
    //                    command.Parameters.AddWithValue("@email", email);
    //                    command.Parameters.AddWithValue("@tel", tel);
    //                    command.Parameters.AddWithValue("@disabled", disabled);


    //                    command.ExecuteNonQuery();
    //                }
    //            }
    //            textID.Clear();
    //            textName.Clear();
    //            textPassword.Clear();

    //            textTel.Clear();
    //            textEmail.Clear();
    //            checkDisabled.Checked = false;
    //            main.ReloadData();
    //            this.Close();
    //        }


    //    }
    //}
}
