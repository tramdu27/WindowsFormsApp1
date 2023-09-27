using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public class DataLayer
    {
        private Main main;
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public DataLayer()
        {
            connection = new SqlConnection(cs);
            dataAdapter = new SqlDataAdapter("pcd_GetUsers", connection);
            dataSet = new DataSet();

        }
        private bool IsValidEmail(string email)
        {
            //Email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        public bool CheckIfIdExists(string userID)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("CheckIfIdExists", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                    idParameter.Value = userID;
                    cmd.Parameters.Add(idParameter);
                    int idExists = (int)cmd.ExecuteScalar();
                    return (idExists == 1);
                }
            }
        }


        public void LoadUserData()
        {
            dataSet.Clear(); // Xóa dữ liệu hiện tại để làm mới
            dataAdapter.Fill(dataSet, "pcd_GetUsers");
        }

    
        

        public void DeleteUser(string userID)
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
        public bool SaveUser(string userID, string userName, string password, string email, string tel, int disabled)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                if (CheckIfIdExists(userID))
                {
                    return false; // Mã người dùng đã tồn tại
                }

                if (!IsValidEmail(email))
                {
                    return false; // Email không hợp lệ
                }

                connection.Open();
                using (SqlCommand command = new SqlCommand("pcd_SaveUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userid", userID);
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@tel", tel);
                    command.Parameters.AddWithValue("@disabled", disabled);
                    command.ExecuteNonQuery();
                }

                return true; // Lưu thành công
            }
        }
        public bool UpdateUser(string userID, string userName, string password, string email, string tel, int disabled)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("pcd_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userid", userID);
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@tel", tel);
                    command.Parameters.AddWithValue("@disabled", disabled);
                    command.ExecuteNonQuery();
                }
                return true; // Cập nhật thành công
            }
            

        }
    }
}
