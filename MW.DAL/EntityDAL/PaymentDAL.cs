using MW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.DAL.EntityDAL
{
    public class PaymentDAL
    {
        public int Add(Payment payment)
        {
            using (MwDbContext db = new MwDbContext())
            {

                db.Entry(payment).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges() ;
            }
        }

        public int Update(Payment payment)
        {
            using (MwDbContext db = new MwDbContext())
            {

                db.Entry(payment).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }

        public int Delete(Payment payment)
        {
            using (MwDbContext db = new MwDbContext())
            {

                db.Entry(payment).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();
            }
        }

        public List<Payment> ListAll()
        {
            using(MwDbContext db = new MwDbContext())
            {
                return db.Payments.ToList();
            }

        }

        public Payment GetByID(Guid paymentID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.Payments.FirstOrDefault(a => a.ID == paymentID);
            }
        }

        public Payment GetByUserID(Guid userID)
        {
            using (MwDbContext db = new MwDbContext())
            {
                return db.Payments.FirstOrDefault(a => a.User.ID == userID); 
            }
        }



        public decimal GetFund(DateTime date1,DateTime date2)
        { 
            using (MwDbContext db = new MwDbContext())
            {
                List<Payment> payment = db.Payments.Where(a => a.PaymentDate >= date1 && a.PaymentDate <= date2).ToList();
                if (payment == null) { return 0; }
                else return payment.Sum(a => a.PaymentPrice);
            }
        }
    }
}
