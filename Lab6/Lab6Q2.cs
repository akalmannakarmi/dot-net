// A bank holds different types of accounts for its customers: deposite accounts, loan accounts and
// mortgage accounts. Customers can be individuals or companies. All accounts have a customer, balance
// and interest rate (monthly based). Deposite accounts allow depositing and withdrawing of money. 
// Loan and mortgage acounts allow only depositing. All accounts can calculate their interest_rate.
// Loan Accounts have no interest rate during the first 3 months if held by individuals and during 
// the first 2 months if held by a company. Deposit accounts have no interest rate if their balance
// is positive and less than 1000. Mortgage accounts have 1/2 the interest rate during the first 12 months
// for companies and no interest rate during the first 6 months for individuals. Your task is to write 
// an object -oriented model of the bank system. You must identity the classes, interfaces, base classes
// and abstract actions and implement the interest calculation functionality.

namespace Lab6
{
    public class Q2
    {
        public static void run(string[] args)
        {
            ICustomer individual = new IndividualCustomer("John Doe");
            ICustomer company = new CompanyCustomer("TechCorp");

            Account[] accounts = new Account[]
            {
            new DepositAccount(individual, 1200, 0.01m),
            new LoanAccount(individual, 5000, 0.05m),
            new MortgageAccount(company, 10000, 0.03m)
            };

            foreach (var account in accounts)
            {
                Console.WriteLine($"Account of {account.Customer.Name}: Balance = {account.Balance}, Interest for 12 months = {account.CalculateInterest(12)}");
            }
        }
    }
    interface ICustomer
    {
        string Name { get; }
    }

    class IndividualCustomer : ICustomer
    {
        public string Name { get; private set; }

        public IndividualCustomer(string name)
        {
            Name = name;
        }
    }

    class CompanyCustomer : ICustomer
    {
        public string Name { get; private set; }

        public CompanyCustomer(string name)
        {
            Name = name;
        }
    }

    abstract class Account
    {
        public ICustomer Customer { get; private set; }
        public decimal Balance { get; protected set; }
        public decimal MonthlyInterestRate { get; private set; }

        public Account(ICustomer customer, decimal balance, decimal monthlyInterestRate)
        {
            Customer = customer;
            Balance = balance;
            MonthlyInterestRate = monthlyInterestRate;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract decimal CalculateInterest(int months);
    }

    class DepositAccount : Account
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate) { }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance.");
            Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (Balance > 0 && Balance < 1000)
                return 0;
            return Balance * MonthlyInterestRate * months;
        }
    }

    class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate) { }

        public override decimal CalculateInterest(int months)
        {
            int noInterestMonths = Customer is IndividualCustomer ? 3 : 2;
            if (months <= noInterestMonths)
                return 0;
            return Balance * MonthlyInterestRate * (months - noInterestMonths);
        }
    }

    class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (Customer is CompanyCustomer)
            {
                int reducedRateMonths = Math.Min(months, 12);
                return (Balance * MonthlyInterestRate * reducedRateMonths / 2) +
                       (Balance * MonthlyInterestRate * (months - reducedRateMonths));
            }
            else if (Customer is IndividualCustomer)
            {
                int noInterestMonths = Math.Min(months, 6);
                return Balance * MonthlyInterestRate * (months - noInterestMonths);
            }
            return Balance * MonthlyInterestRate * months;
        }
    }
}