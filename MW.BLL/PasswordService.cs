using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.BLL
{
    public class PasswordService
    {
        DAL.EntityDAL.PasswordDAL PasswordDAL;
        public PasswordService()
        {
            PasswordDAL = new DAL.EntityDAL.PasswordDAL();
        }

        public bool Add(Password password)
        {
            DeactivatePassword(password.UserID);
            return PasswordDAL.Add(password)>0;
        }

       
        void DeactivatePassword(Guid userID)
        {
            List<Password> passwords = GetByUserID(userID);
            Password pass = passwords.SingleOrDefault(a => a.IsActive);
            pass.IsActive = false;
            Update(pass);
        }

        public bool Update(Password password)
        {
            return PasswordDAL.Update(password)>0;
        }
        public bool Delete(Password password)
        {
            return PasswordDAL.Delete(password)>0;
        }

        public List<Password> ListAll()
        {
            return PasswordDAL.ListAll();
        }

        public Password GetByID(Guid passID)
        {
            return PasswordDAL.GetByID(passID);
        }

        public List<Password> GetByUserID(Guid userID)
        {
            return PasswordDAL.GetByUserID(userID);
        }

        public Password IsPasswordTrue(string passwordText)
        {
            return PasswordDAL.IsPasswordTrue(passwordText);
        }
    }
}
