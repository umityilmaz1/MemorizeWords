using MW.DAL.EntityDAL;
using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MW.BLL
{
    public class UserService
    {
        UserDAL _userDAL;
        UserRoleDAL _userRoleDAL;
        public UserService()
        {
            _userDAL = new UserDAL();
            _userRoleDAL = new UserRoleDAL();
        }
        public bool Add(User user)
        {
            try
            {
                CheckMail(user.EMail);
                IsMailExist(user.EMail);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            user.IsActive = false;
            user.RoleID = _userRoleDAL.GetRoleByName("Restricted").ID;
            return _userDAL.Add(user) > 0;
        }
        public bool Update(User user)
        {
            return _userDAL.Update(user) > 0;
        }
        public bool Delete(User user)
        {
            user.IsActive = false;
            return Update(user);
        }
        public List<User> ListAll()
        {
            return _userDAL.ListAll();
        }
        public User GetByID(Guid userID)
        {
            return _userDAL.GetById(userID);
        }
        public bool GetByMail(string userMail)
        {
            return _userDAL.GetByMail(userMail);
        }
        public User GetUserByLogin(string userMail, string userPassword)
        {
            try
            {
                User user = _userDAL.GetUserByLogin(userMail, userPassword);
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool ActivateUser(User user)
        {
            user.IsActive = true;
            return _userDAL.Update(user) > 0;
        }
        void CheckMail(string mail)
        {
            try
            {
                MailAddress mailAdress = new MailAddress(mail);
            }
            catch
            {
                throw new Exception("Girmiş olduğunuz mail adresi, mail formatına uymuyor. Lütfen mail adresinizi kontrol ediniz.");
            }
        }
        void IsMailExist(string mail)
        {
            bool result = _userDAL.GetByMail(mail);
            if (result)
                throw new Exception("Girmiş olduğunuz mail adresi başka bir kullanıcı tarafından kullanılmaktadır.");
        }
        public List<User> ListRestrictedUsers()
        {
            return _userDAL.ListRestrictedUsers();
        }
        public string GetUserRoleNameByUserID(Guid userID)
        {
            return _userDAL.GetUserRoleNameByUserID(userID);
        } //OK

    }
}
