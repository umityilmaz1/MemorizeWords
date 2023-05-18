using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<User>();
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
