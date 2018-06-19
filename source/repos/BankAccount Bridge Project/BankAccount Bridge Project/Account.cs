using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bridge_Project
{
    public abstract class Account
    {
        public int AcctNumber { get; set; }
        public double Balance { get; set; }
        public string AcctType { get; set; }
        public int Ticker { get; set; }
        
        public virtual void CurrentBalance()
        {

        }

        public virtual void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;

        }

        public virtual void Withdrawal(double withdrawAmount)
        {
            this.Balance = this.Balance - withdrawAmount;
        }

        public abstract void InterestRate();
        

   

    }//abstract class
}//namespace
