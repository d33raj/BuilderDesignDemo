using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignDemo
{
    internal class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return $"Account Id: {AccountId}\nAccount Holder Name: {AccountHolderName}\n" +
                   $"Bank Name: {BankName}\nAccount Type: {AccountType}\nAccount Balance: {Balance}\n";
        }
    }
}
