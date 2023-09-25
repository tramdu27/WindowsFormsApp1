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
    public partial class Mainform : Form
    {
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;

        public Mainform()
        {
            InitializeComponent();
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicWebDataSet.pcd_GetUsers' table. You can move, or remove it, as needed.
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);

        }

        private void c1FlexGrid1_Click(object sender, EventArgs e)
        {

        }

        private void c1FlexGridSearchPanel1_Load(object sender, EventArgs e)
        {

        }

        private void c1ContextMenu1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }
        public void ReloadData()
        {
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);

        }
        private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form2 form2 = new Form2(this); // Truyền tham chiếu đến Form1
            form2.ShowDialog();
        }
        private void FlexGrid1_RowsAdded(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            UpdateRowNumbers();
        }

        private void FlexGrid1_RowsRemoved(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            UpdateRowNumbers();
        }
        private void UpdateRowNumbers()
        {
            for (int i = 0; i < FlexGrid1.Rows.Count; i++)
            {
                FlexGrid1[i + 1, "STT"] = (i + 1).ToString();
            }
        }

        private void c1Command3_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            // Đảm bảo bạn đã chọn ít nhất một dòng trong FlexGrid
            if (FlexGrid1.RowSel > 0)
            {
                // Lấy dòng được chọn đầu tiên
                Row selectedRow = FlexGrid1.Rows[FlexGrid1.RowSel];

                // Lấy các giá trị từ các ô trong dòng

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
                    // Thực hiện xóa bằng cách gọi phương thức xóa dòng
                    FlexGrid1.Rows.Remove(selectedRow);

                    // Sau đó, bạn cần thực hiện xóa trong cơ sở dữ liệu ở đây
                    using (SqlConnection connection = new SqlConnection(cs))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("pcd_DeleteUsers", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@userID", userID);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Reload dữ liệu vào FlexGrid sau khi xóa
                    this.ReloadData();
                }
            }

            //    if (dataGridView1.SelectedRows.Count > 0)
            //    {
            //        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            //        int stt = Convert.ToInt32(selectedRow.Cells["STT"].Value);
            //        string userID = selectedRow.Cells["UserID"].Value.ToString();
            //        string userName = selectedRow.Cells["UserName"].Value.ToString();
            //        string userEmail = selectedRow.Cells["Email"].Value.ToString();
            //        string password = selectedRow.Cells["Password"].Value.ToString();
            //        string tel = selectedRow.Cells["Tel"].Value.ToString();
            //        bool disabled = Convert.ToBoolean(selectedRow.Cells["Disabled"].Value);

            //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận xóa",
            //MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            //        if (result == DialogResult.Yes)
            //        {
            //            using (SqlConnection connection = new SqlConnection(cs))
            //            {
            //                connection.Open();

            //                using (SqlCommand command = new SqlCommand("pcd_DeleteUsers", connection))
            //                {
            //                    command.CommandType = CommandType.StoredProcedure;
            //                    command.Parameters.AddWithValue("@userID", userID);
            //                    command.ExecuteNonQuery();
            //                }
            //            }

            //        }

            //        this.ReloadData();



            //    }
        }

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
                bool disabled = Convert.ToBoolean(selectedRow["Disabled"]);

                //int stt = Convert.ToInt32(selectedRow.Cells["STT"].Value);
                //string userID = selectedRow.Cells["UserID"].Value.ToString();
                //string userName = selectedRow.Cells["UserName"].Value.ToString();
                //string userEmail = selectedRow.Cells["Email"].Value.ToString();
                //string password = selectedRow.Cells["Password"].Value.ToString();
                //string tel = selectedRow.Cells["Tel"].Value.ToString();
                //bool disabled = Convert.ToBoolean(selectedRow.Cells["Disabled"].Value);


                Form3 form3 = new Form3(userID, userName, userEmail, password, tel, disabled, this);
                form3.ShowDialog();
            }

        }

        private void c1Command4_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (FlexGrid1.RowSel > 0)
            {


                Row selectedRow = FlexGrid1.Rows[FlexGrid1.RowSel];

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

        private void FlexGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
