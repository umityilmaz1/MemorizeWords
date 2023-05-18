using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.DAL;
using MW.DAL.EntityDAL;
using MW.Model;

namespace MW.BLL
{
    public class RelationWordAndWordPoolService
    {
        RelationWordAndWordPoolDAL _relation;
        public RelationWordAndWordPoolService()
        {
            _relation = new RelationWordAndWordPoolDAL();
        }
        public int Add(RelationWordAndWordPool relation)
        {
            if (true)
            {

            }

            return _relation.Add(relation);
        } //OK
        public int Update(RelationWordAndWordPool relation)
        {
            return _relation.Update(relation);
        } //OK
        public int Delete(RelationWordAndWordPool relation)
        {
            return _relation.Delete(relation);
        } //OK
        public List<RelationWordAndWordPool> GetActiveListByWordPoolID(Guid wordPoolID)
        {
            return _relation.GetActiveListByWordPoolID(wordPoolID);
        } //OK
        public List<string[]> ListWordsCount()
        {
            return _relation.ListWordsCount();

        }
        public List<string[]> ListUserWordsCount(DateTime date1,DateTime date2)
        {
            return _relation.ListUserWordsCount(date1,date2);

        }
        public int GetWordPoolItemCountByWordPoolID(Guid wordPoolID)
        {
            return _relation.GetActiveWordPoolItemCountByWordPoolID(wordPoolID);
        } //OK
        public RelationWordAndWordPool GetActiveRelationByWordIDAndWordPoolID(Guid wordID, Guid wordPoolID)
        {
            return _relation.GetActiveRelationByWordIDAndWordPoolID(wordID,wordPoolID);
        } //OK




    }
}
