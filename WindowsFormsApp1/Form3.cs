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
    public partial class Form3 : Form
    {
        private Form1 form1;
        private DataGridView dataGridView1;
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;

        //private string userID;
        //private string userName;
        //private string password;
        //private string email;
        //private string tel;
        //private int disabled;
        public Form3(string userID, string userName, string password, string email, string tel, bool disabled, Form1 form1)
        {
            InitializeComponent();
            //this.userID = userID;
            //this.userName = userName;
            //this.password = password;
            //this.email = email;
            //this.tel = tel;
            //this.disabled = disabled;
            textID.Text = userID;
            textName.Text = userName;
            textPassword.Text = password;
            textEmail.Text = email;
            textTel.Text = tel;
            checkDisabled.Checked = disabled;
            this.form1 = form1;
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string userid = textID.Text.Trim();
            string username = textName.Text;
            string password = textPassword.Text;
            string email = textPassword.Text;
            string tel = textTel.Text;
            int disabled = checkDisabled.Checked ? 1 : 0;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("pcd_UpdateUser", connection))
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
            textID.Clear();
            textName.Clear();
            textPassword.Clear();
         
            textTel.Clear();
            textEmail.Clear();
            checkDisabled.Checked = false;
            form1.ReloadData();

        }
    }
}
