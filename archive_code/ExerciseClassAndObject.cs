using TestProject;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = "Tim";
            string lastName = "Shao";

            BankCustomer customer1 = new BankCustomer();

            firstName = "Lisa";
            BankCustomer customer2 = new BankCustomer(firstName, lastName);

            firstName = "Sandy";
            lastName = "Zoeng";
            BankCustomer customer3 = new BankCustomer(firstName, lastName);

            Console.WriteLine($"BankCustomer 1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerId}");
            Console.WriteLine($"BankCustomer 2: {customer2.FirstName} {customer2.LastName} {customer2.CustomerId}");
            Console.WriteLine($"BankCustomer 3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerId}");

            // =======================

            BankAccount account1 = new BankAccount(customer1.CustomerId);
            BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
            BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

            Console.WriteLine($"Account 1: Account # {account1.AccountNumber}, type {account1.AccountType}, balance {account1.Balance}, rate {BankAccount.InterestRate}, customer ID {account1.CustomerId}");
            Console.WriteLine($"Account 2: Account # {account2.AccountNumber}, type {account2.AccountType}, balance {account2.Balance}, rate {BankAccount.InterestRate}, customer ID {account2.CustomerId}");
            Console.WriteLine($"Account 3: Account # {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance}, rate {BankAccount.InterestRate}, customer ID {account3.CustomerId}");

        }
    }
}



namespace TestProject
{
    public class BankCustomer
    {
        private static int s_nextCustomerId;

        public string FirstName = "Tim";
        public string LastName = "Shao";
        public readonly string CustomerId;

        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        public BankCustomer()
        {
            CustomerId = s_nextCustomerId++.ToString("D10");
        }

        public BankCustomer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = s_nextCustomerId++.ToString("D10");
        }
    }

    public class BankAccount
    {
        private static int s_nextAccountNumber = 1;

        public int AccountNumber;
        public double Balance = 0;
        public static double InterestRate;
        public string AccountType = "Checking";
        public readonly string CustomerId;

        static BankAccount()
        {
            Random random = new Random();
            s_nextAccountNumber = random.Next(10000000, 20000000);
            InterestRate = 0;
        }

        public BankAccount(string customerIdNumber)
        {
            AccountNumber = s_nextAccountNumber++;
            CustomerId = customerIdNumber;
        }

        public BankAccount(string customerIdNumber, double balance, string accountType)
        {
            AccountNumber = s_nextAccountNumber++;
            CustomerId = customerIdNumber;
            Balance = balance;
            AccountType = accountType;
        }
    }
}

