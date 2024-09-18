using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_2.BaiTapNangCao.Bai4
{
    public abstract class Account
    {
        public string AccountNumber { get; }
        protected decimal balance;

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            balance = initialBalance;
        }

        public decimal Balance => balance;

        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Da nap {amount} vao tai khoan {AccountNumber}. So du hien tai: {balance}");
            }
            else
            {
                Console.WriteLine("So tien phai lon hon 0.");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Da rut {amount} tu tai khoan {AccountNumber}. So du hien tai: {balance}");
            }
            else
            {
                Console.WriteLine("Khong du so du de rut tien.");
            }
        }
    }


    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
            : base(accountNumber, initialBalance)
        {
            this.interestRate = interestRate;
        }

        public void ApplyInterest()
        {
            decimal interest = balance * interestRate / 100;
            balance += interest;
            Console.WriteLine($"Lai xuat {interestRate}% da duoc ap dung. So du hien tai: {balance}");
        }
    }


    public class CurrentAccount : Account
    {
        public CurrentAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance) { }
    }
}
