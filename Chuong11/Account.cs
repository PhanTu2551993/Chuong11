using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong11
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }

        public Account(int accountNumber, string accountName, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = accountBalance;
        }

        public void Deposit(double amount)
        {
            AccountBalance += amount;
        }

        public void Withdraw(double amount)
        {
            if (AccountBalance >= amount)
            {
                AccountBalance -= amount;
            }
            else
            {
                Console.WriteLine("Số tiền trong tài khoản còn không đủ !");
            }

        }
    }
}
