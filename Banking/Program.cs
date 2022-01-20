using System;

namespace Banking {
    internal class Program {
        static void Main(string[] args) {

            var acct1 = new Account(1);
            acct1.Deposit(100);
        }
    }
}
