using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        
        private SqlDataAdapter adapter;
        private DataTable table;
        private int selected = -1;
        private DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicWebDataSet.pcd_GetUsers' table. You can move, or remove it, as needed.
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);
            // TODO: This line of code loads data into the 'basicWebDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.basicWebDataSet.Users);
           

        }
        public void ReloadData()
        {
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);
            
            this.usersTableAdapter.Fill(this.basicWebDataSet.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Disabled")
            {
                DataGridViewCheckBoxCell cell = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;

                
                if (cell.Value == null || (int)cell.Value == 0)
                {
                    cell.Value = 1;
                }
                else
                {
                    cell.Value = 0;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRowNumbers();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateRowNumbers();
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ContextMenuStrip != null)
            {
                // Hiển thị ContextMenuStrip bên trái của Button
                button2.ContextMenuStrip.Show(button2, new Point(-button2.ContextMenuStrip.Width, 0));
            }
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Hiển thị MenuStrip tại vị trí con trỏ chuột
                ContextMenuStrip1.Show(button2, e.Location);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
      

      
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // Truyền tham chiếu đến Form1
            form2.ShowDialog();
        }

        private void pcd_GetUsersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        private void sưaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int stt = Convert.ToInt32(selectedRow.Cells["STT"].Value);
                string userID = selectedRow.Cells["UserID"].Value.ToString();
                string userName = selectedRow.Cells["UserName"].Value.ToString();
                string userEmail = selectedRow.Cells["Email"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string tel = selectedRow.Cells["Tel"].Value.ToString();
                bool disabled = Convert.ToBoolean(selectedRow.Cells["Disabled"].Value);
                

                Form3 form3 = new Form3(userID, userName, userEmail, password, tel, disabled, this);
                form3.ShowDialog();
            }


        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int stt = Convert.ToInt32(selectedRow.Cells["STT"].Value);
                string userID = selectedRow.Cells["UserID"].Value.ToString();
                string userName = selectedRow.Cells["UserName"].Value.ToString();
                string userEmail = selectedRow.Cells["Email"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string tel = selectedRow.Cells["Tel"].Value.ToString();
                bool disabled = Convert.ToBoolean(selectedRow.Cells["Disabled"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận xóa",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              
                if (result == DialogResult.Yes)
                {
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

                }

                this.ReloadData();



            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Disabled")
            {
                DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                int value = Convert.ToInt32(cell.Value);

                
                if (value == 1)
                {
                    cell.Style.ForeColor = Color.Green; 
                }
                else
                {
                    cell.Style.ForeColor = Color.Black; 
                }
            }
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width - 0, this.ClientSize.Height - 40);
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int stt = Convert.ToInt32(selectedRow.Cells["STT"].Value);
                string userID = selectedRow.Cells["UserID"].Value.ToString();
                string userName = selectedRow.Cells["UserName"].Value.ToString();
                string userEmail = selectedRow.Cells["Email"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string tel = selectedRow.Cells["Tel"].Value.ToString();
                bool disabled = Convert.ToBoolean(selectedRow.Cells["Disabled"].Value);


                Form4 form4 = new Form4(userID, userName, userEmail, password, tel, disabled, this);
                form4.ShowDialog();


            }

        }
    }
}
