using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {

    public class Account {

        public int Id { get; private set; }
        public decimal Balance { get; private set; } = 0;
        public string Description { get; set; }

        public void Deposit(decimal Amount) {
            Balance += Amount;
        }
        public void Withdraw(decimal Amount) {
            if(Amount > Balance) {
                throw new Exception("Insufficient funds");
            }
            Balance -= Amount;
        }
        public Account(int Id) {
            this.Id = Id;
        }
    }
}
