using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    public delegate decimal ChargeInterest(decimal amount); 

    public class Payment:ToDoItem
    {
        public ChargeInterest charge;
        public event EventHandler onOverPayment;
        public DateTime? PaymentDate { get; set; }
        public decimal Amount { get; private set; }
        public decimal Balance { get; private set; }
        
        public Payment(string title, DateTime date, decimal amount )
            : base(title, date)
        {
            Balance = amount;
            Amount = amount;
        }

        public void Refund(decimal amount)
        {
            Balance -= amount;
            if ((onOverPayment!=null) && Balance<0)
            {
                onOverPayment(this, new EventArgs());
            }
        }

        public void Interest()
        {
            if (charge != null)
            {
                Balance += charge(Balance);
            }
        }

        public void Interest2(ChargeInterest chargeMethod)
        {
            if (chargeMethod != null)
            {
                Balance += chargeMethod(Balance);
            }
        }

        public void Interest3(Func<decimal,DateTime,decimal> chargeMethod)
        {
            if (chargeMethod != null)
            {
                Balance += chargeMethod(Balance, DueDate);
            }
        }
    }
}
