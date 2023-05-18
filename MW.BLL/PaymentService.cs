using MW.DAL.EntityDAL;
using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.BLL
{
    public class PaymentService
    {
        DAL.EntityDAL.PaymentDAL PaymentDAL;
        public PaymentService()
        {
            PaymentDAL = new PaymentDAL();
        }
        public bool Add(Payment payment)
        {
            return PaymentDAL.Add(payment)>0;
        }
        public bool Update(Payment payment)
        {
            return PaymentDAL.Update(payment)>0;
        }
        public bool Delete(Payment payment)
        {
           return PaymentDAL.Delete(payment)>0;
        }

        public List<Payment> ListAll()
        {
            return PaymentDAL.ListAll();
        }

        public Payment GetByID(Guid paymentID)
        {
            return PaymentDAL.GetByID(paymentID);
        }

        public Payment GetByUserID(Guid userID)
        {
            return PaymentDAL.GetByUserID(userID);
        }

        public decimal GetFund(DateTime date1,DateTime date2)
        {

            return PaymentDAL.GetFund(date1, date2);
        }
    }
}
