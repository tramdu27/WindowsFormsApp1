using BUS;
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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
    //    private Main main;
    //    private SqlConnection connection;
    //    string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
    //    private MainLogic mainLogic;
    //    public Form4(MainLogic mainLogic)
    //    {
    //        this.mainLogic = mainLogic;
    //    }
    //    public Form4(string userID, string userName, string password, string email, string tel, int disabled, Main main)
    //    {
    //        InitializeComponent();

    //        textID.Text = userID;
    //        textName.Text = userName;
    //        textPassword.Text = password;
    //        textEmail.Text = email;
    //        textTel.Text = tel;
    //        disabled = checkDisabled.Checked ? 1 : 0;
    //        this.main = main;
    //        mainLogic = new MainLogic();
    //    }


    #region Fields
        private Main main;
    private LogicLayer logicLayer;
    //private string userID;
    //private string userName;
    //private string userEmail;
    //private string password;
    //private string tel;
    //private int disabled;
    #endregion

    #region Constructor
    public Form4(LogicLayer logicLayer)
    {
        this.logicLayer = logicLayer;
    }



    public Form4(string userID, string userName, string password, string email, string tel, int disabled, Main main)
    {
        InitializeComponent();
        textID.Text = userID;
        textName.Text = userName;
        textPassword.Text = password;
        textEmail.Text = email;
        textTel.Text = tel;
        disabled = checkDisabled.Checked ? 1 : 0;
        this.main = main;
        logicLayer = new LogicLayer();
    }
    #endregion
}
}
