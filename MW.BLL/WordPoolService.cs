using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.Model;
using MW.DAL.EntityDAL;

namespace MW.BLL
{
    public class WordPoolService
    {
        WordPoolDAL _wordPoolDAL;
        UserService _userService;
        RelationWordAndWordPoolService _relationWordAndWordPoolService;

        public WordPoolService()
        {
            _wordPoolDAL = new WordPoolDAL();
            _userService = new UserService();
            _relationWordAndWordPoolService = new RelationWordAndWordPoolService();
        } //OK
        public bool Add(WordPool wordPool)
        {
            return _wordPoolDAL.Add(wordPool) > 0;

        } //OK
        public bool Update(WordPool wordPool)
        {
            return _wordPoolDAL.Update(wordPool) > 0;
        } //OK
        public bool Delete(WordPool wordPool)
        {
            return _wordPoolDAL.Delete(wordPool) > 0;
        } //OK
        public List<WordPool> ListAll()
        {
            return _wordPoolDAL.ListAll();
        } //OK
        public WordPool GetByID(Guid wordPoolID)
        {
            return _wordPoolDAL.GetByID(wordPoolID);
        } //OK
        public List<WordPool> GetListByUserID(Guid userID)
        {
            return _wordPoolDAL.GetListByUserID(userID).ToList();
        } //OK        
        public bool IsWordPoolExist(Guid userID, string wordPoolName)
        {
            WordPool tempWordPool = _wordPoolDAL.GetListWhichIsActiveByUserID(userID).SingleOrDefault(a => a.Name == wordPoolName);

            if (tempWordPool != null)
                return true;

            return false;
        } //OK
        public bool CanAddMoreWordPool(Guid userID)
        {       
            if (_wordPoolDAL.GetListWhichIsActiveByUserID(userID).Count == 1 && _userService.GetUserRoleNameByUserID(userID) == "Restricted")
                return false;

            return true;
        } //OK
        public bool CanAddMoreWordToWordPool(Guid userID,Guid wordPoolID)
        {
            if (_wordPoolDAL.GetListWhichIsActiveByUserID(userID).Count == 1 && _userService.GetUserRoleNameByUserID(userID) == "Restricted" && _relationWordAndWordPoolService.GetWordPoolItemCountByWordPoolID(wordPoolID)==10)
                return false;

            return true;
        } //OK
    }
}
