using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.Model;
using System.Data.SqlClient;

namespace MW.DAL.EntityDAL
{
    public class WordDAL
    {
        public int Add(Word word)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Words.Add(word);
                return _db.SaveChanges();
            }
        }
        public int Update(Word word)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Entry(word).State = System.Data.Entity.EntityState.Modified;
                return _db.SaveChanges();
            }
        }
        public int Delete(Word word)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                _db.Words.Attach(word);
                _db.Words.Remove(word);
                return _db.SaveChanges();
            }
        }
        public List<Word> ListAll()
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Words.ToList();
            }
        }
        public Word GetByID(Guid wordID)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Words.Where(a => a.ID == wordID).SingleOrDefault();
            }
        }
        public bool DoesWordExist(string englishText)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                Word existing = _db.Words.Where(a => a.EnglishText == englishText).SingleOrDefault();

                return existing == null;

            }

        }
        public Word GetWordByText(string englishText)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Words.Where(a => a.EnglishText == englishText).SingleOrDefault();

            }
        }
        public List<Word> ListWordsContain(string text)
        {
            using (MwDbContext _db = new MwDbContext())
            {
                return _db.Words.Where(a => a.EnglishText.Contains(text)).ToList();

            }

        }



    }
}
