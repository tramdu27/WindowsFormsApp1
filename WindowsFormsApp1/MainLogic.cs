using C1.Win.C1FlexGrid;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public class MainLogic
    {
        #region Fields
        private DataLayer dataLayer;
        #endregion
        #region Constructor
        public MainLogic()
        {
            dataLayer = new DataLayer();
        }
        #endregion
        #region Validation
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public bool CheckIfIdExists(string userID)
        {
            return dataLayer.CheckIfIdExists(userID);
        }
        #endregion
        #region Operations
        public bool SaveUser(string userID, string userName, string password, string email, string tel, int disabled)
        {
            return dataLayer.SaveUser(userID, userName, password, email, tel, disabled);
        }

        public void DeleteUser(string userID)
        {
            dataLayer.DeleteUser(userID);

        }

        public bool UpdateUser(string userID, string userName, string password, string email, string tel, int disabled)
        {
            return dataLayer.UpdateUser(userID, userName, password, email, tel, disabled);
        }
        public bool View(string userID, string userName, string password, string email, string tel, int disabled)
        {
            return dataLayer.ViewUser(userID, userName, password, email, tel, disabled);
        }

        #endregion
        #region Private
        private void ReloadData(C1.Win.C1FlexGrid.C1FlexGrid flexGrid)
        {
            flexGrid.Refresh();

        }
        #endregion
    }

}
