using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.EntityDAL
{
    public class WordPoolDAL
    {
        public int Add(WordPool wordPool)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(wordPool).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();
            }
        } //OK
        public int Update(WordPool wordPool)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(wordPool).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        } //OK
        public int Delete(WordPool wordPool)
        {
            using (MwDbContext db = new MwDbContext())
            {
                wordPool.IsActive = false;
                db.Entry(wordPool).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();

            }
        } //OK
        public List<WordPool> ListAll()
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.WordPools.ToList();
            }
        } //OK
        public WordPool GetByID(Guid worldPoolID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.WordPools.SingleOrDefault(a => a.ID == worldPoolID);
            }

        } //OK
        public List<WordPool> GetListByUserID(Guid userID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.WordPools.Where(a => a.UserID == userID).ToList();
            }

        } //OK
        public List<WordPool> GetListWhichIsActiveByUserID(Guid userID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.WordPools.Where(a => a.UserID == userID && a.IsActive == true).ToList();
            }
        } //OK    
    }


}

