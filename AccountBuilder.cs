using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignDemo
{
    internal class AccountBuilder
    {
        public Account account = new Account();

        public AccountBuilder SetAccountId(int accountId)
        {
            account.AccountId = accountId;
            return this;
        }
        public AccountBuilder SetAccountHolderName(string accountHolderName)
        {
            account.AccountHolderName = accountHolderName;
            return this;
        }
        public AccountBuilder SetBankName(string bankName)
        {
            account.BankName = bankName;
            return this;
        }
        public AccountBuilder SetAccountType(string accountType)
        {
            account.AccountType = accountType;
            return this;
        }
        public AccountBuilder SetAccountBalance(double balance)
        {
            account.Balance = balance;
            return this;
        }

        public Account Build()
        {
            return account;
        }

    }
}
