using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.EntityDAL
{
    public class PasswordDAL
    {
        public int Add(Password password)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(password).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();

            }

        }

        public int Update(Password password)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(password).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();

            }

        }

        public int Delete(Password password)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(password).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();

            }
        }

        public List<Password> ListAll()
        {
            using (MwDbContext db = new MwDbContext())
            {
               return db.Passwords.ToList();
            }
        }

        public Password GetByID (Guid passID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.Passwords.FirstOrDefault(a => a.ID == passID);
            }
        }

        public List<Password> GetByUserID(Guid userID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.Passwords.Where(a => a.UserID == userID).ToList();
            }
        }

        public Password IsPasswordTrue(string passwordText)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.Passwords.SingleOrDefault(a => a.PasswordText == passwordText && a.IsActive);
            }

        }
    }
}
