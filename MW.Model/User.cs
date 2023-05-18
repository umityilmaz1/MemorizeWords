using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class User : BaseEntity
    {
        public User()
        {
            Passwords = new HashSet<Password>();
            WordPools = new HashSet<WordPool>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid RoleID { get; set; }
        public int PracticeNumber { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual UserRole Role { get; set; }
        public virtual ICollection<Password> Passwords { get; set; }
        public virtual ICollection<WordPool> WordPools { get; set; }

    }
}
    