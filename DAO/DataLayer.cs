using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Text.RegularExpressions; 
namespace DAO
{
    public class DataLayer
    {
        #region Fields
       
        private SqlConnection connection;
        string cs = ConfigurationManager.ConnectionStrings["basicdb"].ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        #endregion Fields
        #region Constructor
        public DataLayer()
        {
            connection = new SqlConnection(cs);
            dataAdapter = new SqlDataAdapter("pcd_GetUsers", connection);
            dataSet = new DataSet();

        }
        #endregion
        #region Validation
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
        #endregion

        public void LoadUserData()
        {
            dataSet.Clear(); // Xóa dữ liệu hiện tại để làm mới
            dataAdapter.Fill(dataSet, "pcd_GetUsers");
        }


        #region Handle Events

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
        public bool ViewUser(string userID, string userName, string password, string email, string tel, int disabled)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("pcd_GetUsersById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userid", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader["UserID"].ToString();
                            userName = reader["UserName"].ToString();
                            userName = reader["UserName"].ToString();
                            password = reader["Password"].ToString();
                            email = reader["Email"].ToString();
                            tel = reader["Tel"].ToString();
                            disabled = Convert.ToInt32(reader["Disabled"]);
                            return true; // Trả về true nếu lấy thông tin thành công
                        }
                    }
                }
            }

            //Nếu không tìm thấy thông tin người dùng, gán giá trị mặc định cho các biến đầu ra và trả về false
            userName = string.Empty;
            password = string.Empty;
            email = string.Empty;
            tel = string.Empty;
            disabled = 0;
            return false;
        }

        
        #endregion
    }
}
