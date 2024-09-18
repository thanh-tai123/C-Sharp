using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_2.BaiTapNangCao.Bai3
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }

        public abstract decimal calculateSalary();
    }
    public class Manager : Employee
    {
        private decimal ManagerSalary;
        private decimal bonus;

        public Manager(string name, decimal Salary, decimal bonus) : base(name)
        {
            ManagerSalary = Salary;
            this.bonus = bonus;
        }

        public override decimal calculateSalary()
        {
            return ManagerSalary + bonus;
        }
    }
    public class Developer : Employee
    {
        private decimal DeveloperSalary;
        private decimal bonus;

        public Developer(string name, decimal DeveloperSalary, decimal bonus) : base(name)
        {
            this.DeveloperSalary = DeveloperSalary;
            this.bonus = bonus;
        }

        public override decimal calculateSalary()
        {
            return DeveloperSalary + bonus;
        }
    }
    public class Intern : Employee
    {
        private decimal InternSalary;
        private decimal bonus;
        public Intern(string name, decimal internSalary, decimal bonus) : base(name)
        {
            InternSalary = internSalary;
            this.bonus = bonus;
        }

        public override decimal calculateSalary()
        {
            return InternSalary += bonus;

        }
    }


}
