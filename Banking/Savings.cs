using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    
    public class Savings : Account {

        public decimal InterestRate { get; set; } = 0.12m;

        public decimal CalculateAndPayInterest(int MonthsToPay = 1) {
            var Interest = InterestRate / 12 * MonthsToPay * Balance;
            Deposit(Interest);
            return Interest;
        }

    }
}
