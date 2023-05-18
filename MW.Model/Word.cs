using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class Word : BaseEntity
    {

        public Word()
        {
            // WordPools = new HashSet<WordPool>(); //Relation tablosu oluşturduğumuzdan burası şu anda kullanılmıyor
        }

        public string EnglishText { get; set; }
        public string TurkishText { get; set; }

        // public virtual ICollection<WordPool> WordPools { get; set; } //Relation tablosu oluşturduğumuzdan burası şu anda kullanılmıyor
        public virtual ICollection<RelationWordAndWordPool> Relation1 { get; set; }

        public override string ToString()
        {
            return EnglishText;
        }
    }
}
