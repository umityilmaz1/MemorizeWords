using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.Model;
using MW.DAL.EntityDAL;

namespace MW.BLL
{
    public class WordService
    {
        WordDAL _wordDal;
        RelationWordAndWordPoolService _relationWordAndWordPoolService;

        public WordService()
        {
            _wordDal = new WordDAL();
            _relationWordAndWordPoolService = new RelationWordAndWordPoolService();
        }

        public bool Add(Word word)
        {
            DoesWordExist(word.EnglishText);
            return _wordDal.Add(word) > 0;

        }
        public bool Update(Word word)
        {
            return _wordDal.Update(word) > 0;
        }
        public bool Delete(Word word)
        {
            return _wordDal.Delete(word) > 0;
        }
        public List<Word> ListAll()
        {
            return _wordDal.ListAll();
        }
        public Word GetByID(Guid wordID)
        {
            return _wordDal.GetByID(wordID);
        }
        void DoesWordExist(string englishText)
        {
            bool result = _wordDal.DoesWordExist(englishText);
            if (!result)
                throw new Exception("Bu kelime sistemde bulunmaktadır.");
        }
        public List<Word> GetContains(string text)
        {

            return _wordDal.ListWordsContain(text);


        }
        public List<Word> GetAllActiveWordsOfUserByWordPoolsID(List<Guid> wordPoolID)
        {
            List<Word> wordList = new List<Word>(); ;
            foreach (Guid item in wordPoolID)
            {
                foreach (RelationWordAndWordPool item2 in _relationWordAndWordPoolService.GetActiveListByWordPoolID(item))
                {
                    wordList.Add(GetByID(item2.WordID));
                }
            }
            return wordList;
        }
    }
}
