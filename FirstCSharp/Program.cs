// static int CalculateAge(int birthYear)
// {
//     return DateTime.Now.Year - birthYear;
// }
//
// int age;
// string name;
//
// Console.Write("Name: ");
// name = Console.ReadLine();
//
// Console.Write("Birth year: ");
// age = CalculateAge(Convert.ToInt32(Console.ReadLine()));
//
// Console.WriteLine($"My name is {name}. {age} years old.");


// ==============================SERT OPERATOR ILE IS=====================================
//
// string name;
// int age;
//
// Console.Write("Name: ");
// name = Console.ReadLine();
//
// Console.Write("Age: ");
// age = Convert.ToInt32(Console.ReadLine());
//
// static string CheckAge(int age)
// {
//     if (age >= 18)
//     {
//         return "You are adult.";
//     }
//     else
//     {
//         return "You are not adult.";
//     }
// }
//
// Console.WriteLine($"Hello, {name}! {CheckAge(age)}");
//
//
// ==============================VALIDATION ISH=====================================
//
// int age;
//
// Console.Write("Age: ");
// bool isValid = int.TryParse(Console.ReadLine(), out age);
//
// static string CheckAge(int age)
// {
//     return age >= 65 ? "You are senior" :
//         age >= 18 ? "You are adult.": "You are not adult.";
// }
//
// if (isValid && age > 0)
// {
//     Console.WriteLine(CheckAge(age));
// }
// else
// {
//     Console.WriteLine("Please enter a valid age.");
// };
//
//
// ==============================LIST ISH=====================================
//
// List<int> numbers = new List<int> { 10, 25, 8, 40, 15, 30, 5 };
//
// foreach (var item in numbers)
// {
//     Console.WriteLine("List Array:" + item);
// }
//
// var result = numbers.Where(i => i > 10).ToList();
//
// foreach (var item in result)
// {
//     Console.WriteLine("Filtered Array:" + item);
// }
//
// var mapped = numbers.Select(i => i * 2).ToList();
//
// foreach (var item in mapped)
// {
//     Console.WriteLine("Mapped Array:" + item);
// }
//
// Console.WriteLine("Array length:" + numbers.Count);
//
// var cutEded = numbers.Where(i => i % 2 == 0).ToList();
//
// foreach (var item in cutEded)
// {
//     Console.WriteLine("Cut Array:" + item);
// }


// ==============================CLASS ISH=====================================

// class User
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Email { get; set; }
// }
//
// List<User> users = new List<User>
// {
//     new User { Name = "Firuza", Age = 22, Email = "firuzeveliyev2@gmail.com" },
//     new User { Name = "Ali", Age = 21, Email = "ali@gmail.com" },
//     new User { Name = "Leyla", Age = 17, Email = "leyla@gmail.com" },
// };
//
// foreach (var i in users)
// {
//     Console.WriteLine(i.Name);
// }


// ==============================CLASS OBJECT CONSTRUCTOR OOP=====================================

// class User
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Email { get; set; }
//
//     public User(string name, int age, string email)
//     {
//         this.Name = name;
//         this.Age = age;
//         this.Email = email;
//     }
//
//     public void GetInfo()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}, Email: {Email}");
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         // User user = new User("Firuza", 21, "fira@gmail.com");
//         // user.GetInfo();
//
//         List<User> users = new List<User>
//         {
//             new User("Firuza", 22, "fira@gmail.com"),
//             new User("Ali", 21, "ali@gmail.com"),
//             new User("Leyla", 17, "leyla@gmail.com"),
//             new User("Amir", 18, "amir@gmail.com")
//         };
//
//         foreach (var i in users)
//         {
//             i.GetInfo();
//         }
//
//         var adult = users.Where(u => u.Age >= 18).Select(u => u.Name).ToList();
//
//         for (inti = 0; i < adult.Count; i++)
//         {
//             Console.WriteLine($"Adult name: {adult[i]}");
//         }
//
//         var bigAdult = users.Any(u => u.Age >= 30);
//         Console.WriteLine(bigAdult);
//     }
// }


// ==============================BANK ACCOUNT TASK=====================================

// class BankAccount
// {
//     public string AccountNumber { get; private set; }
//     public decimal Balance { get; private set; }
//
//     public BankAccount(string accountNumber)
//     {
//         AccountNumber = accountNumber;
//     }
//
//     public void Deposit(decimal amount)
//     {
//         if (amount > 0)
//         {
//             Balance += amount;
//         }
//         else
//         {
//             throw new ArgumentException("Amount must be greater than 0.");
//         }
//     }
//
//     public void Withdraw(decimal amount)
//     {
//         if (amount > 0 && Balance >= amount)
//         {
//             Balance -= amount;
//         }
//         else
//         {
//             throw new ArgumentException("Insufficient balance");
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         BankAccount account = new BankAccount("AA12345");
//
//         account.Deposit(500);
//         account.Deposit(100);
//         account.Withdraw(200);
//
//         Console.WriteLine(account.Balance);
//     }
// }


// ==============================INHERITANCE TASK=====================================

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
//
//     public void Introduce()
//     {
//         Console.WriteLine($"My name is {Name} and I am {Age} years old.");
//     }
// }
//
// class Student : Person
// {
//     public string University { get; set; }
//
//     public Student(string name, int age, string uni) : base(name, age)
//     {
//         University = uni;
//     }
//
//     public void Study()
//     {
//         Console.WriteLine($"I study at {University}.");
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Student student = new Student("Firuza", 22, "Baku Engineering University");
//
//         student.Introduce();
//         student.Study();
//     }
// }


// ==============================POLYMORPHISM TASK=====================================

class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public virtual void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}

class Developer : Employee
{
    public Developer(string name) : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine("Developer is coding.");
    }
}

class Designer : Employee
{
    public Designer(string name) : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine("Designer is designing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Developer("Firuza"),
            new Designer("Ali")
        };

        foreach (Employee employee in employees)
        {
            employee.Work();
        }
    }
}