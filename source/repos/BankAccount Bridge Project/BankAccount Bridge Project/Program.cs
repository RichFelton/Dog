using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bridge_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.Write("Please enter your first and last name: ");
            client.ClientName = Console.ReadLine();
            Console.Write("Please enter the amount of the balance of your checking account: ");
            Checking acctChecking = new Checking(double.Parse(Console.ReadLine()));
            Console.Write("Please enter the amoung of the balance of your savings account: ");
            Savings acctSavings = new Savings();
            acctSavings.Balance = double.Parse(Console.ReadLine());
            acctSavings.InterestRate();
            acctChecking.InterestRate();
            int menuChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("[1] View Client Information");
                Console.WriteLine("[2] View Account Balance");
                Console.WriteLine("[3] Deposit Funds");
                Console.WriteLine("[4] Withdraw Funds");
                Console.WriteLine("[5] Exit");

                int userInput;
                menuChoice = int.Parse(Console.ReadLine());
                acctSavings.InterestRate();
                acctChecking.InterestRate();
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine(client.ClientName);
                        Console.WriteLine("Your checking account number is: " + acctChecking.AcctNumber);
                        Console.WriteLine("Your savings account number is: " + acctSavings.AcctNumber);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        acctSavings.InterestRate();
                        acctChecking.InterestRate();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Which account balance do you want to see?");
                        Console.WriteLine("[1] Savings balance");
                        Console.WriteLine("[2] Checking balance");
                        Console.WriteLine("[3] return");
                        do
                        {
                            userInput = 0;
                            userInput = int.Parse(Console.ReadLine());
                            acctSavings.InterestRate();
                            acctChecking.InterestRate();
                            switch (userInput)
                            {
                                case 1: //checking account balance
                                    Console.WriteLine("Your checking account balance is: " + acctChecking.Balance);
                                    Console.WriteLine("Press enter to continue");
                                    Console.ReadLine();
                                    acctSavings.InterestRate();
                                    acctChecking.InterestRate();
                                    break;
                                case 2: //savings account balance 
                                    Console.WriteLine("Your savings account balance is: " + acctSavings.Balance);
                                    Console.WriteLine("Press enter to continue");
                                    Console.ReadLine();
                                    acctSavings.InterestRate();
                                    acctChecking.InterestRate();
                                    break;
                                case 3: //leave the switch
                                    userInput = 0;
                                    break;

                                default:
                                    Console.WriteLine("Invalid response!");
                                    break;

                            }

                        }
                        while (userInput == 0);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Into which account would you like to make a deposit?");
                        Console.WriteLine("[1] Savings balance");
                        Console.WriteLine("[2] Checking balance");
                        Console.WriteLine("[3] return");
                        do
                        {
                            userInput = 0;
                            userInput = int.Parse(Console.ReadLine());
                            acctSavings.InterestRate();
                            acctChecking.InterestRate();
                            switch (userInput)
                            {
                                case 1: //checking account deposit
                                    Console.WriteLine("How much would you like to deposit: ");
                                    acctChecking.Deposit(double.Parse(Console.ReadLine()));
                                     acctSavings.InterestRate();
                                     acctChecking.InterestRate();
                                    break;
                                case 2: //savings account deposit 
                                    Console.WriteLine("How much would you like to deposit: ");
                                    acctSavings.Deposit(double.Parse(Console.ReadLine()));
                                    acctSavings.InterestRate();
                                    acctChecking.InterestRate();
                                    break;
                                case 3: //leave the switch
                                    break;

                                default:
                                    Console.WriteLine("Invalid response!");
                                    break;

                            }

                        }
                        while (userInput == 0);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("From which account would you like to make a withdrawal?");
                        Console.WriteLine("[1] Savings balance");
                        Console.WriteLine("[2] Checking balance");
                        Console.WriteLine("[3] return");
                        do
                        {
                            userInput = 0;
                            userInput = int.Parse(Console.ReadLine());
                            acctSavings.InterestRate();
                            acctChecking.InterestRate();
                            switch (userInput)
                            {
                                case 1: //checking account withdrawal
                                    Console.WriteLine("How much would you like to withdraw: ");
                                    acctChecking.Withdrawal(double.Parse(Console.ReadLine()));
                                    acctSavings.InterestRate();
                                    acctChecking.InterestRate();
                                    break;
                                case 2: //savings account withdrawal 
                                    Console.WriteLine("How much would you like to withdraw: ");
                                    acctSavings.Withdrawal(double.Parse(Console.ReadLine()));
                                    acctSavings.InterestRate();
                                    acctChecking.InterestRate();
                                    break;
                                case 3: //leave the switch
                                    break;

                                default:
                                    Console.WriteLine("Invalid response!");
                                    break;

                            }

                        }
                        while (userInput == 0);
                        break;

                    case 5:
                        menuChoice = 0;
                        break;
                    default:
                        break;

                }// end menu switch
            } while (menuChoice > 0);

    {

            }

        } // mainclass
    }

        
}
