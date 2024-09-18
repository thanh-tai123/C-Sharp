// See https://aka.ms/new-console-template for more information
using OOP_LESSON_2.BaiTapCoBan.Bai1;
using OOP_LESSON_2.BaiTapCoBan.Bai2;
using OOP_LESSON_2.BaiTapCoBan.Bai3;
using OOP_LESSON_2.BaiTapNangCao.Bai2;
using OOP_LESSON_2.BaiTapNangCao.Bai3;
using OOP_LESSON_2.BaiTapNangCao.Bai4;
using System.Security.Principal;
//1
Console.WriteLine("Hello, World!");
Person person_number1 = new Person("Hector", 23, "Go Vap");
person_number1.HienThi();

Person person_number2 = new Person("John", 44, "Quan 3");
person_number2.HienThi();

Person person_number3 = new Person("Nick", 26, "Quan 1");
person_number3.HienThi();

//2
BankAccount bankAccount = new BankAccount(8789814597081, "Nguyen Thanh Tai");
bankAccount.deposit(1000);
bankAccount.withdraw(10000);


//3
Animal dog = new Dog("Dog");
dog.makeSound();

Animal cat = new Cat("Cat");
cat.makeSound();

Animal bird = new Bird("Bird");
bird.makeSound();
//4
List<Animal> animals = new List<Animal>();
animals.Add(new Dog("Bubby"));
animals.Add(new Bird("Lifd"));
animals.Add(new Cat("Tweety"));

Dog foundDog = animals.OfType<Dog>().FirstOrDefault();
foundDog?.makeSound();

//Bai tap nang cao
//2
Student student = new Student("PS28998", "Nguyen Thanh Tai", 9);
student.Display();
student.updateDiem(10);
student.Display();
//3
List<Employee> employees = new List<Employee>();
employees.Add(new Manager("M1", 2000, 10));
employees.Add(new Developer("D1", 1400, 4));
employees.Add(new Intern("I1", 1000, 1));

foreach (Employee employee in employees)
{
    Console.WriteLine($"Name {employee.Name}, Salary:  {employee.calculateSalary()}");
}


//4
List<Account> accounts = new List<Account>
{
            new SavingsAccount("PS001", 2000, 5),
            new CurrentAccount("PS001", 1500)
        };


foreach (var account in accounts)
{
    account.Deposit(500);
    account.Withdraw(300);

    if (account is SavingsAccount savingsAccount)
    {
        savingsAccount.ApplyInterest();
    }

    Console.WriteLine($"So du tai khoan {account.AccountNumber}: {account.Balance}");
}