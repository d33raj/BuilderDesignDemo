namespace BuilderDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new AccountBuilder()
                              .SetAccountId(101)
                              .SetAccountHolderName("Dheeraj")
                              .SetBankName("SBI")
                              .SetAccountBalance(1000)
                              .SetAccountType("Savings Account")
                              .Build();
            Console.WriteLine(account1);

            Account account2 = new AccountBuilder()
                             .SetAccountId(102)
                             .SetAccountHolderName("Nani")
                             .SetBankName("AXIS")
                             .SetAccountType("Corpus Fund Account")
                             .Build();
            Console.WriteLine(account2);
        }
    }
}
