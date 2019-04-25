using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie.Tasks
{
    class Payment:ToDoItem
    {
        public DateTime? PaymentDate { get; set; }
        public decimal Amount { get; private set; }
        public decimal Balance { get; private set; }
        
        public Payment(string title, DateTime date, decimal amount )
            : base(title, date)
        {
            Amount = amount;
        }

        public void Refund(decimal amount)
        {
            Balance -= amount;
        }

        public void Interest()
        {

        }
    }
}
