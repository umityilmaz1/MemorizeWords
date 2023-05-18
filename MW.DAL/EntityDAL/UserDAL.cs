using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.EntityDAL
{
    public class UserDAL
    {
        public UserDAL()
        {

        }
        public int Add(User user)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Users.Add(user);
                return _db.SaveChanges();
            }
        }
        public int Update(User user)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                return _db.SaveChanges();
            }
        }
        public int Delete(User user)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Users.Remove(user);
                return _db.SaveChanges();
            }
        }
        public List<User> ListAll()
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Users.ToList();
            }
        }
        public User GetById(Guid userID)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Users.Find(userID);
            }
        }
        public bool GetByMail(string userMail)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                User currentUser = _db.Users.Where(a => a.EMail == userMail).FirstOrDefault();
                if (currentUser == null)
                    return false;

                return true;
            }
        }
        public User GetUserByLogin(string userMail, string userPassword)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                User currentUser;
                try
                {
                    currentUser = _db.Users.Single(a => a.EMail == userMail);
                    Password password = currentUser.Passwords.Single(a => a.PasswordText == userPassword && a.IsActive);
                }
                catch
                {
                    throw new Exception("Kullanıcı bilgileri hatalı! Kullanıcı adınızı ve parolanızı konrol ediniz.");
                }
                return currentUser;
            }
        }
        public List<User> ListRestrictedUsers()
        {
            using (MwDbContext _db = new MwDbContext())
            {
                UserRoleDAL _userRole = new UserRoleDAL();
                Guid roleID = _userRole.GetRoleByName("Restricted").ID;
                return _db.Users.Where(a => a.RoleID == roleID).ToList();

            }

        }
        public string GetUserRoleNameByUserID(Guid userID)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Users.SingleOrDefault(a => a.ID == userID).Role.RoleName;
            }
        } //OK

    }
}
