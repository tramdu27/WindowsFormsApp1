﻿using System;
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
        private Main main;
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        public Form4(string userID, string userName, string password, string email, string tel, bool disabled, Main main)
        {
            InitializeComponent();
          
            textID.Text = userID;
            textName.Text = userName;
            textPassword.Text = password;
            textEmail.Text = email;
            textTel.Text = tel;
            checkDisabled.Checked = disabled;
            this.main = main;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
