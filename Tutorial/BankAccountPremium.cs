using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class BankAccountPremium : BankAccount
    {
        public override double withdraw(int percentage)
        {
            double baseAmount = base.withdraw(percentage);
            double e = 1 / 100 * baseAmount;
            base.balance += e;
            return e;
        }
        public override double withdraw(double amount)
        {
            double baseAmount = base.withdraw(amount);
            double s = 1 / 100 * baseAmount;
            base.balance += s;
            return s;
        }

    }
}
