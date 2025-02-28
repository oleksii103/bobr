using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public delegate bool NumberFilter(int number);
    public delegate void NumberProcessor(int number);

    static void Main()
    {
        Console.WriteLine("Choose a task:");
        Console.WriteLine("1 - Number filtering");
        Console.WriteLine("2 - Credit Card Management");
        Console.WriteLine("3 - Number Processing Chain");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            RunNumberFiltering();
        }
        else if (choice == 2)
        {
            RunCreditCardManagement();
        }
        else if (choice == 3)
        {
            RunNumberProcessingChain();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void RunNumberFiltering()
    {
        Console.Write("Enter the number of elements: ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("Enter " + count + " numbers separated by spaces: ");
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if (numbers.Length != count)
        {
            Console.WriteLine("Error: The number of entered elements does not match the specified count.");
            return;
        }

        Console.WriteLine("Even numbers: " + string.Join(", ", FilterArray(numbers, IsEven)));
        Console.WriteLine("Odd numbers: " + string.Join(", ", FilterArray(numbers, IsOdd)));
        Console.WriteLine("Prime numbers: " + string.Join(", ", FilterArray(numbers, IsPrime)));
        Console.WriteLine("Fibonacci numbers: " + string.Join(", ", FilterArray(numbers, IsFibonacci)));
    }

    static List<int> FilterArray(int[] numbers, NumberFilter filter)
    {
        return numbers.Where(n => filter(n)).ToList();
    }

    static bool IsEven(int number) => number % 2 == 0;

    static bool IsOdd(int number) => number % 2 != 0;

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static bool IsFibonacci(int number)
    {
        if (number < 0) return false;
        int a = 0, b = 1;
        while (a < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == number;
    }

    static void RunNumberProcessingChain()
    {
        Console.Write("Enter a number to process: ");
        int number = int.Parse(Console.ReadLine());

        NumberProcessor chain = CheckPositive;
        chain += CheckEven;
        chain += CheckPrime;
        chain += CheckFibonacci;

        chain.Invoke(number);
    }

    static void CheckPositive(int number)
    {
        if (number > 0)
            Console.WriteLine($"{number} is positive.");
    }

    static void CheckEven(int number)
    {
        if (number % 2 == 0)
            Console.WriteLine($"{number} is even.");
    }

    static void CheckPrime(int number)
    {
        if (IsPrime(number))
            Console.WriteLine($"{number} is prime.");
    }

    static void CheckFibonacci(int number)
    {
        if (IsFibonacci(number))
            Console.WriteLine($"{number} is a Fibonacci number.");
    }

    class CreditCard
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PIN { get; private set; }
        public decimal CreditLimit { get; set; }
        public decimal Balance { get; private set; }

        public event Action<decimal> OnDeposit;
        public event Action<decimal> OnWithdraw;
        public event Action OnCreditUsed;
        public event Action<decimal> OnBalanceReached;
        public event Action<string> OnPinChanged;

        public CreditCard(string cardNumber, string ownerName, DateTime expiryDate, string pin, decimal creditLimit, decimal balance)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            ExpiryDate = expiryDate;
            PIN = pin;
            CreditLimit = creditLimit;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            OnDeposit?.Invoke(amount);
        }

        public void Withdraw(decimal amount)
        {
            if (Balance + CreditLimit >= amount)
            {
                Balance -= amount;
                OnWithdraw?.Invoke(amount);
                if (Balance < 0) OnCreditUsed?.Invoke();
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void ChangePin(string newPin)
        {
            PIN = newPin;
            OnPinChanged?.Invoke(newPin);
        }
    }

    static void RunCreditCardManagement()
    {
        CreditCard card = new CreditCard("1234-5678-9876-5432", "John Doe", DateTime.Now.AddYears(3), "1234", 1000, 500);

        card.OnDeposit += amount => Console.WriteLine($"Deposited: {amount}");
        card.OnWithdraw += amount => Console.WriteLine($"Withdrawn: {amount}");
        card.OnCreditUsed += () => Console.WriteLine("Credit funds used!");
        card.OnPinChanged += newPin => Console.WriteLine("PIN changed successfully.");

        card.Deposit(200);
        card.Withdraw(800);
        card.ChangePin("4321");
    }
}