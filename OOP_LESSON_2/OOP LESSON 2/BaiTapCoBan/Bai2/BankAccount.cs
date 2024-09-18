using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_2.BaiTapCoBan.Bai2
{
    class BankAccount
    {
        public long accountNumber { get; set; }
        public string accountHolder { get; set; }
        private double balance { get; set; }
        public BankAccount(long accountNumber, string accountHolder)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            balance = 0;
        }
        public void deposit(double depositnumber)
        {

            balance = balance + depositnumber;
            Console.WriteLine($"So du sau khi nap {balance}");
        }
        public void withdraw(double withdrawnumber)
        {
            if (balance < withdrawnumber)
            {
                Console.WriteLine($"So du hien tai {balance}");
                Console.WriteLine("So du khong du");
            }
            else
            {
                balance = balance - withdrawnumber;
                Console.WriteLine($"So du sau khi rut {balance}");
            }
        }
    }
}
