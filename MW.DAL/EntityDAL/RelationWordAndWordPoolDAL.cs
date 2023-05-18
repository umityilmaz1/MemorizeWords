using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.Model;
using MW.DAL.EntityDAL;


namespace MW.DAL.EntityDAL
{
    public class RelationWordAndWordPoolDAL
    {
        WordPoolDAL _wordPoolDAL = new WordPoolDAL();

        public int Add(RelationWordAndWordPool relation)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(relation).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();
            }
        } //OK
        public int Update(RelationWordAndWordPool relation)
        {
            using (MwDbContext db = new MwDbContext())
            {
                db.Entry(relation).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        } //OK
        public int Delete(RelationWordAndWordPool relation)
        {
            using (MwDbContext db = new MwDbContext())
            {
                relation.IsActive = false;
                db.Entry(relation).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();

            }
        } //OK
        public List<RelationWordAndWordPool> ListAll()
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.RelationsWordsAndWordPools.ToList();
            }
        } //OK
        public List<RelationWordAndWordPool> GetActiveListByWordPoolID(Guid wordPoolID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.RelationsWordsAndWordPools.Where(a => a.WordPoolID == wordPoolID && a.IsActive == true).ToList();
            }
        } //OK
        public List<string[]> ListWordsCount()
        {
            MwDbContext db = new MwDbContext();

            List<Word> word = db.Words.ToList();
            List<string[]> wordList = new List<string[]>();
            string[] dizi;// = new string[2];

            foreach (var item in word)
            {
                dizi = new string[2];
                dizi[0] = item.EnglishText;
                dizi[1] = db.RelationsWordsAndWordPools.Count(a => a.WordID == item.ID).ToString();
                wordList.Add(dizi);
            }


            return wordList;
        }
        public List<string[]> ListUserWordsCount(DateTime date1, DateTime date2)
        {
            MwDbContext db = new MwDbContext();
            List<string[]> userWordsCount = new List<string[]>();
            List<User> user = db.Users.ToList();

            string[] dizi;

            foreach (var item in user)
            {
                // List<WordPool> wordpool = db.WordPools.Where(a => a.UserID == item.ID & a.CreatedDate > date1 & a.CreatedDate < date2).ToList();
                List<WordPool> tempWordPools = _wordPoolDAL.GetListByUserID(item.ID);
                List<RelationWordAndWordPool> relation = null;

                foreach (WordPool item2 in tempWordPools)
                {
                    relation = db.RelationsWordsAndWordPools.Where(a => a.WordPoolID == item2.ID & a.CreatedDate > date1 & a.CreatedDate < date2).ToList();
                }

                dizi = new string[2];

                dizi[0] = item.Name + " " + item.Surname;
                if (relation==null)
                    dizi[1] = "0";
                else
                    dizi[1] = relation.Count().ToString();
                userWordsCount.Add(dizi);

            }
            return userWordsCount;
        }
        public int GetActiveWordPoolItemCountByWordPoolID(Guid wordPoolID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.RelationsWordsAndWordPools.Where(a => a.WordPoolID == wordPoolID && a.IsActive == true).ToList().Count();
            }
        } //OK
        public RelationWordAndWordPool GetActiveRelationByWordIDAndWordPoolID(Guid wordID, Guid wordPoolID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.RelationsWordsAndWordPools.SingleOrDefault(a => a.WordPoolID == wordPoolID && a.IsActive == true && a.WordID == wordID);
            }
        } //OK

    }
}
