using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class BankAccount
    {
        protected double balance { get; set; }
        public virtual double withdraw(double amount)
        {
            balance -= amount;
            return amount;
        }
        public virtual double withdraw(int percentage)
        {
            double z = (percentage / 100) * balance;
            balance -= z;
            return z;
        }
    }
}
