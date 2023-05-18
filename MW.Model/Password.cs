using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class Password : BaseEntity
    {
        public string PasswordText { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}
