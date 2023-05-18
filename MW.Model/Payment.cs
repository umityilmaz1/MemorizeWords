using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.Model
{
    public class Payment
    {
        public Payment()
        {
            IsPaymentDone = false;
            PaymentDate = DateTime.Now;
            PaymentPrice = 100;
        }

        [ForeignKey("User")]
        public Guid ID { get; set; }

        public bool IsPaymentDone { get; set; }

        public string PaymentType { get; set; }

        public decimal PaymentPrice { get; set;}

        public DateTime PaymentDate { get; set; }

        public virtual User User { get; set; }

    }
}
