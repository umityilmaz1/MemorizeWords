using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW.Model;

namespace MW.DAL.Mapping
{
    class RelationWordAndWordPoolMapping:EntityTypeConfiguration<RelationWordAndWordPool>
    {
        public RelationWordAndWordPoolMapping()
        {
            HasRequired(a => a.Word).WithMany(a => a.Relation1).HasForeignKey(a => a.WordID);
            HasRequired(a => a.WordPool).WithMany(a => a.Relation2).HasForeignKey(a=>a.WordPoolID);

        }
    }
}
