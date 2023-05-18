using MW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.Mappings
{
    class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(a => a.Name).HasMaxLength(20);
            Property(a => a.Surname).HasMaxLength(30);
            Property(a => a.EMail).HasMaxLength(50);

            HasRequired(a => a.Role)
                .WithMany(a => a.Users)
                .HasForeignKey(a => a.RoleID);
            
        }
    }
}
