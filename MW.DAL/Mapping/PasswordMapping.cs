using MW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.Mapping
{
    public class PasswordMapping : EntityTypeConfiguration<Password>
    {
        public PasswordMapping()
        {

            HasRequired(a => a.User).WithMany(a => a.Passwords).HasForeignKey(a => a.UserID);
      
        }
    }
}
