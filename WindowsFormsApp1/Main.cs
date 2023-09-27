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
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        private DataLayer layer;
        private MainLogic mainLogic;
        public Main()
        {
            InitializeComponent();
            layer = new DataLayer();
            mainLogic = new MainLogic();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            ReloadData();
            int rowIndex = 1;
            foreach (Row row in FlexGrid1.Rows)
            {
                // Kiểm tra nếu dòng đó không phải là dòng tự động tạo ra bởi grid (chẳng hạn như dòng tổng hợp).
                if (!row.IsNode)
                {
                    row["STT"] = rowIndex;
                    rowIndex++;
                }
            }

            // Sau khi cập nhật số thứ tự, gọi phương thức Refresh() để cập nhật giao diện người dùng.
            FlexGrid1.Refresh();


        }


        public void ReloadData()
        {
            layer.LoadUserData();
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);

        }
        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form2 form2 = new Form2(this); // Truyền tham chiếu đến Form2
            form2.ShowDialog();
        }
        //private void FlexGrid1_RowsAdded(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        //{
        //    UpdateRowNumbers();
        //}

        //private void FlexGrid1_RowsRemoved(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        //{
        //    UpdateRowNumbers();
        //}
        //private void UpdateRowNumbers()
        //{
        //    for (int i = 0; i < FlexGrid1.Rows.Count; i++)
        //    {
        //        FlexGrid1[i + 1, "STT"] = (i + 1).ToString();
        //    }
        //}

        private void c1Command3_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }

        private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
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
                int disabled = selectedRow["Disabled"].ToString().Equals("True") ? 1 : 0;

                mainLogic.UpdateUser(userID, userName, userEmail, password, tel, disabled);
               
            }
        }

        private void c1Command4_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
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

                Form4 form4 = new Form4(userID, userName, userEmail, password, tel, disabled, this);
                form4.ShowDialog();


            }

        }

        private void c1ContextMenu1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicWebDataSet.pcd_GetUsers' table. You can move, or remove it, as needed.
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);

        }

        private void c1Command3_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
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
                    //Gọi DeleteUser() trong class MainLogic
                    mainLogic.DeleteUser(userID);
                    //Gọi ReloadData() để load lại dữ liệu sau khi xóa user
                    ReloadData();

                    
                }
            }
        }

        private void c1Command1_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
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
                ReloadData();
            }

        }

        private void FlexGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}

