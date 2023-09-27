using C1.Win.C1FlexGrid;
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
    public partial class Main : Form
    {
        #region Fields

        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        private DataLayer layer;
        private MainLogic mainLogic;
        private Form3 form3;
        private Form4 form4;
        #endregion
        #region Constructor
        public Main()
        {
            InitializeComponent();
            layer = new DataLayer();
            mainLogic = new MainLogic();

        }
        #endregion
        #region LoadData


        private void Main_Load(object sender, EventArgs e)
        {
            ReloadData();
            
        }
        
        public void ReloadData()
        {
            layer.LoadUserData();
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);

        }
        #endregion

        #region Command Button
        private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {


            if (FlexGrid1.RowSel > 0)
            {
                Row selectedRow = FlexGrid1.Rows[FlexGrid1.RowSel];
                string userID = selectedRow["UserID"].ToString();
                string userName = selectedRow["UserName"].ToString();
                string userEmail = selectedRow["Email"].ToString();
                string password = selectedRow["Password"].ToString();
                string tel = selectedRow["Tel"].ToString();

                int disabled = selectedRow["Disabled"].ToString().Equals("True") ? 1 : 0;

                mainLogic.UpdateUser(userID, userName, userEmail, password, tel, disabled);
                Form3 form3 = new Form3(userID, userName, userEmail, password, tel, disabled);
                form3.ShowDialog();

            }
        }
        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form2 form2 = new Form2(this); 
            form2.ShowDialog();
        }


        


        private void c1Command4_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            // Đã chọn ít nhất 1 dòng
            if (FlexGrid1.RowSel > 0)
            {
                // Lấy dòng đầu tiên
                Row selectedRow = FlexGrid1.Rows[FlexGrid1.RowSel];

                // Lấy giá trị từ các ô trong dòng
                string userID = selectedRow["UserID"].ToString();
                string userName = selectedRow["UserName"].ToString();
                string userEmail = selectedRow["Email"].ToString();
                string password = selectedRow["Password"].ToString();
                string tel = selectedRow["Tel"].ToString();
                int disabled = selectedRow["Disabled"].ToString().Equals("True") ? 1 : 0;

                // Gọi phương thức View để lấy thông tin người dùng
                mainLogic.View(userID, userName, password, userEmail, tel, disabled);
                // Hiển thị Form4 để xem thông tin người dùng
                Form4 form4 = new Form4(userID, userName, password, userEmail, tel, disabled, this);
                form4.ShowDialog();



            }
        }






        #endregion

        private void c1Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void c1Command1_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
        //{


        //    if (FlexGrid1.RowSel > 0)
        //    {
        //        Row selectedRow = FlexGrid1.Rows[FlexGrid1.RowSel];
        //        string userID = selectedRow["UserID"].ToString();
        //        string userName = selectedRow["UserName"].ToString();
        //        string userEmail = selectedRow["Email"].ToString();
        //        string password = selectedRow["Password"].ToString();
        //        string tel = selectedRow["Tel"].ToString();

        //        int disabled = selectedRow["Disabled"].ToString().Equals("True") ? 1 : 0;

        //        mainLogic.UpdateUser(userID, userName, userEmail, password, tel, disabled);
        //        Form3 form3 = new Form3(userID, userName, userEmail, password, tel, disabled);
        //        form3.ShowDialog();

        //    }
        //}
    }
}

