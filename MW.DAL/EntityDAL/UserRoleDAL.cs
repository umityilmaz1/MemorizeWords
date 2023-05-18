using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.EntityDAL
{
    public class UserRoleDAL
    {
        public UserRoleDAL()
        {

        }
        public int Add(UserRole role)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.UserRoles.Add(role);
                return _db.SaveChanges();
            }
        }
        public int Update(UserRole role)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Entry(role).State = System.Data.Entity.EntityState.Modified;
                return _db.SaveChanges();
            }
        }
        public int Delete(UserRole role)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.UserRoles.Remove(role);
                return _db.SaveChanges();
            }
        }
        public List<UserRole> ListAll()
        {
            using(MwDbContext _db = new MwDbContext())
            {
                return _db.UserRoles.ToList();
            }
        }
        public UserRole GetRoleByID(Guid roleID)
        {
            using(MwDbContext _db = new MwDbContext())
            {
                return _db.UserRoles.SingleOrDefault(a=>a.ID==roleID);
            }
        }
        public UserRole GetRoleByMail(string mail)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                Guid roleID = _db.Users.FirstOrDefault(a => a.EMail == mail).RoleID;
                return GetRoleByID(roleID);
            }
        }

        public string GetRoleNameByMail(string mail)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                User user = _db.Users.FirstOrDefault(a => a.EMail == mail);
                return user.Role.RoleName;

            }

        }

        public UserRole GetRoleByName(string roleName)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.UserRoles.SingleOrDefault(a => a.RoleName == roleName);
            }
        }


        public string GetRoleNameByUserID(Guid userID)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.UserRoles.SingleOrDefault(a => a.ID == a.Users.FirstOrDefault(b=>b.ID==userID).RoleID).RoleName;
            }
        } //OK

    }
}
