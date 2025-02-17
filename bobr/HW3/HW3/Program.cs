using System;

namespace HW3
{
    public class ForeignPassport
    {
        public string PassportNumber { get; private set; }
        public string FullName { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }

        public ForeignPassport(string passportNumber, string fullName, DateTime issueDate, DateTime expiryDate)
        {
            if (string.IsNullOrWhiteSpace(passportNumber) || passportNumber.Length != 9 || !IsValidPassportNumber(passportNumber))
            {
                throw new ArgumentException("Invalid passport number. Passport number must be alphanumeric and 9 characters long.");
            }
            PassportNumber = passportNumber;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("Full name cannot be empty.");
            }
            FullName = fullName;

            if (issueDate > DateTime.Now)
            {
                throw new ArgumentException("Issue date cannot be in the future.");
            }
            IssueDate = issueDate;

            if (expiryDate <= issueDate)
            {
                throw new ArgumentException("Expiry date must be later than the issue date.");
            }
            ExpiryDate = expiryDate;
        }

        private bool IsValidPassportNumber(string passportNumber)
        {
            foreach (char c in passportNumber)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Passport Number: " + PassportNumber);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Issue Date: " + IssueDate.ToShortDateString());
            Console.WriteLine("Expiry Date: " + ExpiryDate.ToShortDateString());
        }
    }

    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber) || accountNumber.Length != 10)
            {
                throw new ArgumentException("Invalid account number. Account number must be exactly 10 characters.");
            }

            if (string.IsNullOrWhiteSpace(accountHolder))
            {
                throw new ArgumentException("Account holder name cannot be empty.");
            }

            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }

            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select the task to execute:");
                Console.WriteLine("1. Number System Converter");
                Console.WriteLine("2. Foreign Passport");
                Console.WriteLine("3. Bank Account");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        NumberSystemConverter();
                        break;
                    case 2:
                        ForeignPassportTask();
                        break;
                    case 3:
                        BankAccountTask();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void NumberSystemConverter()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Number System Converter Calculator");
                Console.WriteLine("1. Convert from Decimal to Binary");
                Console.WriteLine("2. Convert from Decimal to Hexadecimal");
                Console.WriteLine("3. Convert from Binary to Decimal");
                Console.WriteLine("4. Convert from Hexadecimal to Decimal");
                Console.WriteLine("5. Return to Main Menu");
                Console.Write("Choose an option (1-5): ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ReadLine();
                    continue;
                }

                if (choice == 5)
                {
                    break;
                }

                Console.Write("Enter the number: ");
                string input = Console.ReadLine();
                int number = 0;

                if (choice == 1 || choice == 2)
                {
                    if (!int.TryParse(input, out number))
                    {
                        Console.WriteLine("Invalid input. Enter an integer.");
                        Console.ReadLine();
                        continue;
                    }

                    if (number < int.MinValue || number > int.MaxValue)
                    {
                        Console.WriteLine("Number out of range for int type.");
                        Console.ReadLine();
                        continue;
                    }
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Number {number} in binary: {Convert.ToString(number, 2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Number {number} in hexadecimal: {Convert.ToString(number, 16).ToUpper()}");
                        break;
                    case 3:
                        try
                        {
                            number = Convert.ToInt32(input, 2);
                            Console.WriteLine($"Number {input} in decimal: {number}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid binary number.");
                        }
                        break;
                    case 4:
                        try
                        {
                            number = Convert.ToInt32(input, 16);
                            Console.WriteLine($"Number {input} in decimal: {number}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid hexadecimal number.");
                        }
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ForeignPassportTask()
        {
            try
            {
                ForeignPassport passport = new ForeignPassport("AB1234567", "John Doe", new DateTime(2020, 5, 15), new DateTime(2030, 5, 15));
                passport.DisplayDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                ForeignPassport invalidPassport = new ForeignPassport("1234", "Jane Doe", new DateTime(2022, 10, 10), new DateTime(2032, 10, 10));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void BankAccountTask()
        {
            try
            {
                BankAccount account = new BankAccount("1234567890", "John Doe", 500.00m);
                account.DisplayAccountInfo();

                account.Deposit(200.00m);
                account.Withdraw(100.00m);
                account.Withdraw(700.00m); 

                account.DisplayAccountInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
