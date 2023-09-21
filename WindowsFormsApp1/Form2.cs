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


     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;

            string userid = textID.Text.ToUpper();
            string username = textName.Text;
            string password = textPassword.Text;
            //string email = textPassword.Text;
            string tel = textTel.Text;
            int disabled = checkDisabled.Checked ? 1 : 0;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

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
                


            }
            //btnNhaptiep.Visible = true;
            //btnLuu.Visible = false;
            //textID.Clear();
            //textName.Clear();
            //textPassword.Clear();
            //textConfirmPassword.Clear();
            //textTel.Clear();
            //textEmail.Clear();
            //checkDisabled.Checked = false;
            //Form1 parentForm = (Form1)this.Owner; // Lấy tham chiếu đến Form1
            //parentForm.ReloadDataGridView();
            
            
        }

        private void btnNhaptiep_Click(object sender, EventArgs e)
        {
            //string userid = textID.Text.Trim();
            //string username = textName.Text;
            //string password = textPassword.Text;
            //string email = textPassword.Text;
            //string tel = textTel.Text;
            //int disabled = checkDisabled.Checked ? 1 : 0;
            //using (SqlConnection connection = new SqlConnection(cs))
            //{
            //    connection.Open();

            //    using (SqlCommand command = new SqlCommand("pcd_SaveUsers", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@userid", userid);
            //        command.Parameters.AddWithValue("@username", username);
            //        command.Parameters.AddWithValue("@password", password);
            //        command.Parameters.AddWithValue("@email", email);
            //        command.Parameters.AddWithValue("@tel", tel);
            //        command.Parameters.AddWithValue("@disabled", disabled);


            //        command.ExecuteNonQuery();


            //    }



            //}
            //btnNhaptiep.Visible = false;
            //btnLuu.Visible = true;


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
