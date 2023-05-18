using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            ID = Guid.NewGuid();
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
        public Guid ID { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
