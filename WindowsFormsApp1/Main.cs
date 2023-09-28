﻿using C1.Win.C1FlexGrid;
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
using DAO;
using BUS;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        #region Fields

        public DataLayer layer;
        private LogicLayer logicLayer;
        private Form3 form3;
        private Form4 form4;
        #endregion
        #region Constructor
        public Main()
        {
            InitializeComponent();
            layer = new DataLayer();
            logicLayer = new LogicLayer();

        }
        #endregion
        #region LoadData


        private void Main_Load(object sender, EventArgs e)
        {
            ReloadData();

        }

        public void ReloadData()
        {
           //load dữ liệu lên FlexGrid
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);
            //Xóa dữ liệu hiện tại để làm mới 
            layer.LoadUserData();

        }
        #endregion

        #region Command Button
        private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
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

                logicLayer.UpdateUser(userID, userName, userEmail, password, tel, disabled);
                Form3 form3 = new Form3(userID, userName, userEmail, password, tel, disabled, this);
                form3.Show();

            }
        }
        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

        }


        private void c1Command3_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            // Đã chọn ít nhất 1 dòng
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
                bool disabled = Convert.ToBoolean(selectedRow["Disabled"]);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Gọi DeleteUser() trong class LogicLayer
                    logicLayer.DeleteUser(userID);
                    //Gọi ReloadData() để load lại dữ liệu sau khi xóa user
                    ReloadData();


                }
            }
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
                logicLayer.View(userID, userName, password, userEmail, tel, disabled);
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

        private void FlexGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}

