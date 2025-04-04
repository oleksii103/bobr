using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }

    public class Firm
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }
    }

    class Program
    {
        static List<Firm> firms = new List<Firm>
        {
            new Firm
            {
                Name = "Canabis Market",
                FoundationDate = DateTime.Now.AddYears(-2).AddDays(-1),
                BusinessProfile = "Drug`s",
                DirectorFullName = "Mihail Righ",
                EmployeesCount = 8000,
                Address = "Lviv",
                Employees = new List<Employee>()
            },
            new Firm
            {
                Name = "Black & White Solutions",
                FoundationDate = DateTime.Now.AddDays(-123),
                BusinessProfile = "IT",
                DirectorFullName = "Anna Black",
                EmployeesCount = 95,
                Address = "Manchester",
                Employees = new List<Employee>
                {
                    new Employee { FullName = "Daniel Brown", Position = "Developer", Phone = "23500000", Email = "daniel@bws.com", Salary = 5000 },
                    new Employee { FullName = "Lionel Messi", Position = "Manager", Phone = "23111111", Email = "lionel@bws.com", Salary = 8000 }
                }
            }
        };

        static void Main(string[] args)
        {
            var allEmployeesOfFirm = firms.First(f => f.Name == "Black & White Solutions").Employees;
            var highPaidEmployees = firms.First(f => f.Name == "Black & White Solutions").Employees.Where(e => e.Salary > 5000);
            var allManagers = firms.SelectMany(f => f.Employees).Where(e => e.Position.ToLower() == "manager");
            var phoneStartsWith23 = firms.SelectMany(f => f.Employees).Where(e => e.Phone.StartsWith("23"));
            var emailStartsWithDi = firms.SelectMany(f => f.Employees).Where(e => e.Email.StartsWith("di", StringComparison.OrdinalIgnoreCase));
            var namedLionel = firms.SelectMany(f => f.Employees).Where(e => e.FullName.Split(' ')[0] == "Lionel");

            while (true)
            {
                Console.WriteLine("\n===== Firm Query Menu =====");
                Console.WriteLine("1. Show all firms");
                Console.WriteLine("2. Firms with 'Food' in the name");
                Console.WriteLine("3. Marketing firms");
                Console.WriteLine("4. Marketing or IT firms");
                Console.WriteLine("5. Firms with more than 100 employees");
                Console.WriteLine("6. Firms with 100-300 employees");
                Console.WriteLine("7. Firms located in London");
                Console.WriteLine("8. Firms with director's surname 'White'");
                Console.WriteLine("9. Firms founded more than 2 years ago");
                Console.WriteLine("10. Firms founded exactly 123 days ago");
                Console.WriteLine("11. Firms with director 'Black' and name containing 'White'");
                Console.WriteLine("12. All employees of 'Black & White Solutions'");
                Console.WriteLine("13. Employees of 'Black & White Solutions' with salary > 5000");
                Console.WriteLine("14. All managers");
                Console.WriteLine("15. Employees with phone starting with '23'");
                Console.WriteLine("16. Employees with email starting with 'di'");
                Console.WriteLine("17. Employees named 'Lionel'");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": Print("All firms", firms); break;
                    case "2": Print("Firms with 'Food' in the name", firms.Where(f => f.Name.Contains("Food"))); break;
                    case "3": Print("Marketing firms", firms.Where(f => f.BusinessProfile == "Marketing")); break;
                    case "4": Print("Marketing or IT firms", firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT")); break;
                    case "5": Print("Firms with more than 100 employees", firms.Where(f => f.EmployeesCount > 100)); break;
                    case "6": Print("Firms with 100-300 employees", firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300)); break;
                    case "7": Print("Firms located in London", firms.Where(f => f.Address == "London")); break;
                    case "8": Print("Firms with director's surname 'White'", firms.Where(f => f.DirectorFullName.Split(' ').Last() == "White")); break;
                    case "9": Print("Firms founded more than 2 years ago", firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 2 * 365)); break;
                    case "10": Print("Firms founded 123 days ago", firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays >= 123 && (DateTime.Now - f.FoundationDate).TotalDays < 124)); break;
                    case "11": Print("Firms with director 'Black' and name containing 'White'", firms.Where(f => f.DirectorFullName.Split(' ').Last() == "Black" && f.Name.Contains("White"))); break;
                    case "12": PrintEmployees("All employees of 'Black & White Solutions'", allEmployeesOfFirm); break;
                    case "13": PrintEmployees("Employees of 'Black & White Solutions' with salary > 5000", highPaidEmployees); break;
                    case "14": PrintEmployees("All managers", allManagers); break;
                    case "15": PrintEmployees("Employees with phone starting with '23'", phoneStartsWith23); break;
                    case "16": PrintEmployees("Employees with email starting with 'di'", emailStartsWithDi); break;
                    case "17": PrintEmployees("Employees named 'Lionel'", namedLionel); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid option. Try again."); break;
                }
            }
        }

        static void Print(string title, IEnumerable<Firm> result)
        {
            Console.WriteLine($"\n--- {title} ---");
            foreach (var firm in result)
            {
                Console.WriteLine($"Name: {firm.Name}, Founded: {firm.FoundationDate.ToShortDateString()}, Profile: {firm.BusinessProfile}, Director: {firm.DirectorFullName}, Employees: {firm.EmployeesCount}, Address: {firm.Address}");
            }
            if (!result.Any()) Console.WriteLine("No firms found.");
        }

        static void PrintEmployees(string title, IEnumerable<Employee> employees)
        {
            Console.WriteLine($"\n--- {title} ---");
            foreach (var e in employees)
            {
                Console.WriteLine($"Name: {e.FullName}, Position: {e.Position}, Phone: {e.Phone}, Email: {e.Email}, Salary: {e.Salary}");
            }
            if (!employees.Any()) Console.WriteLine("No employees found.");
        }
    }
}

