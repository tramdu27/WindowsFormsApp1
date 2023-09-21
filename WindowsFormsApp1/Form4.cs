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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        public Form4(string userID, string userName, string password, string email, string tel, bool disabled)
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
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
