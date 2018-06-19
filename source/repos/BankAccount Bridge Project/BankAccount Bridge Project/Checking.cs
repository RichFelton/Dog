using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bridge_Project
{
    class Checking : Account
    {
        public Checking(double balance)
        {
            Random acctNum = new Random();
            this.AcctNumber = acctNum.Next(10000, 99999);
            this.AcctType = "Checking";
            this.Balance = balance;
        }
        
        public override void InterestRate()
        {
            Ticker = Ticker + 1;
            if (Ticker == 3)
            {
            Balance = Balance + (Balance * .015);
            Ticker = 0;
            }

        }

        


    }//class
}//namespace
