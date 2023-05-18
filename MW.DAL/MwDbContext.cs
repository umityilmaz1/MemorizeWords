using MW.DAL.Mapping;
using MW.DAL.Mappings;
using MW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL
{
    class MwDbContext : DbContext
    {
        public MwDbContext() : base("name=myConnStr")
        {

           
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Password> Passwords { get; set; }

        public virtual DbSet<UserRole> UserRoles { get; set; }

        public virtual DbSet<WordPool> WordPools { get; set; }

        public virtual DbSet<Word> Words { get; set; }

        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<RelationWordAndWordPool> RelationsWordsAndWordPools { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new PasswordMapping());
            modelBuilder.Configurations.Add(new WordPoolMapping());
            modelBuilder.Configurations.Add(new RelationWordAndWordPoolMapping());
        }

    }
}
