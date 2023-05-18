using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.Model;

namespace MW.DAL.Mapping
{
    class WordPoolMapping:EntityTypeConfiguration<WordPool>
    {
        public WordPoolMapping()
        {
            HasRequired(a => a.User).WithMany(a => a.WordPools).HasForeignKey(a => a.UserID);
        }
    }
}
