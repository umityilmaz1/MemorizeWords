using MW.DAL.EntityDAL;
using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.BLL
{
    public class UserRoleService
    {
        UserRoleDAL _userRoleDAL;
        public UserRoleService()
        {
            _userRoleDAL = new UserRoleDAL();
        }
        public bool Add(UserRole userRole)
        {
            return _userRoleDAL.Add(userRole) > 0;
        }
        public bool Update(UserRole userRole)
        {
            return _userRoleDAL.Update(userRole) > 0;
        }
        public bool Delete(UserRole userRole)
        {
            return _userRoleDAL.Delete(userRole) > 0;
        }
        public List<UserRole> ListAll()
        {
            return _userRoleDAL.ListAll();
        }
        public UserRole GetRoleByID(Guid roleID)
        {
            return _userRoleDAL.GetRoleByID(roleID);
        }
        public UserRole GetRoleByMail(string mail)
        {
            return _userRoleDAL.GetRoleByMail(mail);
        }

        public string GetUserRoleNameByMail(string mail)
        {
            return _userRoleDAL.GetRoleNameByMail(mail);

        }

        public UserRole GetRoleByName(string roleName)
        {
            return _userRoleDAL.GetRoleByName(roleName);
        }

        public string GetRoleNameByUserID(Guid userID)
        {
            return _userRoleDAL.GetRoleNameByUserID(userID);
        } //OK //vakit kalırsa bu işlem user üzerine aktarılacak
    } 

}


