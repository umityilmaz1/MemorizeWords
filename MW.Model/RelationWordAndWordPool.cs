using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class RelationWordAndWordPool : BaseEntity
    {
        public Guid WordID { get; set; }
        public Guid WordPoolID { get; set; }

        public virtual Word Word { get; set; }
        public virtual WordPool WordPool { get; set; }
    }
}
