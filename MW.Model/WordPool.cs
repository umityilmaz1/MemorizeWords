using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class WordPool : BaseEntity
    {
        public WordPool()
        {
            //  Words = new HashSet<Word>(); //Relation tablosu oluşturduğumuzdan burası şu anda kullanılmıyor
        }

        public string Name { get; set; }
        public Guid UserID { get; set; }

        public virtual User User { get; set; }
        //public virtual ICollection<Word> Words { get; set; } //Relation tablosu oluşturduğumuzdan burası şu anda kullanılmıyor
        public virtual ICollection<RelationWordAndWordPool> Relation2 { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
