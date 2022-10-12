using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleBanking;
using Microsoft.VisualBasic.FileIO;

public class Program
{//var myaccount = new account();
    

    public static void Main(string[] args)
    {
        string fn, ln, accType, email, pword, accNo;
        int bal;
        List<account> accountlist = new List<account>();
        account mainAccount;// The account we're working with   
        
       
        

        start();
        //login();
        menu();
        Console.WriteLine("Thank you for banking with us!");
        Console.ReadLine();

        void start()
        {
            //account mainAccount; Console.WriteLine("Welcome to the Console Banking");
            int option = 0;
            //this point is to repeat the process if a wrong input is encountered.
        point:

            Console.WriteLine("Enter the number to perform an operation \n 1-- Open Account \n 2--Login");
            option = int.Parse(Console.ReadLine());


            if (option == 1)
            {

            //myaccount.openAccount();
            //accounts.Add(new account(myaccount.firstName, myaccount.lastName, myaccount.accountType, myaccount.email, myaccount.password, myaccount.accountNumber, myaccount.balance));
            //This mark is to create a second account
            mark:
                Console.WriteLine("Enter your first name: ");
                fn = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                ln = Console.ReadLine();

                Console.WriteLine("Enter the option number for type of account. 1. Savings 2. Current:: ");
                var temp = int.Parse(Console.ReadLine());
                if (temp == 1)
                    accType = "Savings";
                else
                    accType = "Current";

                Console.WriteLine("Enter your email: ");
                email = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                pword = Console.ReadLine();

                Console.WriteLine("How much would you like to deposit: ");
                bal = int.Parse(Console.ReadLine());

                string r;
                string startwith = "1001";
                Random rand = new Random();
                r = rand.Next(1, 999999).ToString("D6");
                accNo = startwith + r;



                Console.WriteLine("Congratulations! Your account has been created.");
                Console.WriteLine("Your account number is " + accNo);
                Console.WriteLine("Your account balance is {0}",bal);

                //List<account> accounts = new List<account>();

                accountlist.Add(new account(fn, ln, accType, email, pword, accNo, bal));

                //Console.WriteLine(accountlist[0]+" "+ accountlist[1]);
                Console.WriteLine("Hello "+ fn);
                Console.WriteLine("Would you like to create another another? 1 for yes and 0 for No.");
                var answer = int.Parse(Console.ReadLine());


                switch (answer)
                {
                    case 1:
                        goto mark;
                        break;
                    case 0:
                        login();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }

            }
            else if (option == 2)
            {
                login();


            }
            else
            {
                Console.WriteLine("Invalid number entered");
                goto point;
                //start();
            }


        }


        //look at this. it's not working yet
        void login()
        {


            //List<account> accounts = new List<account>();
            //account mainAccount;
            Console.WriteLine("Enter your Account number and password to login in.");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Number : ");
                    var acc = Console.ReadLine();
                    mainAccount = accountlist.FirstOrDefault(a => a.accountNumber == acc);
                    
                    if (mainAccount != null) { break; }
                    else { Console.WriteLine("Account number not recognized"); }
                }
                catch
                {
                    Console.WriteLine("Account number not recognized");
                }

            }


            while (true)
            {
                try
                {
                    bool mainPword;
                    reenter:
                    Console.WriteLine("Enter Password: ");
                    var pword = Console.ReadLine();
                    mainPword = mainAccount.Password == pword;
                    //mainPword = accountlist.FirstOrDefault(a => a.Password == pword);
                    if (mainPword == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pin number not recognized. Please enter correct pin");
                        goto reenter;

                    }
                }
                catch
                {
                    Console.WriteLine("Pin number not recognized");
                }
            }

            Console.WriteLine("Welcome " + mainAccount.firstname + "\n Press Enter to continue...");
            Console.ReadLine();


        }


        void menu()
        {
            int selection = 0;
            retry:
            
                Console.WriteLine("\n\n Please choose an option: ");
                Console.WriteLine("\n 1. Deposit");
                Console.WriteLine("\n 2. Withdraw");
                Console.WriteLine("\n 3. Balance");
                Console.WriteLine("\n 4. Transfer");
                Console.WriteLine("\n 5. Statement");
                Console.WriteLine("\n 6. Exit");

                selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        deposit();
                        break;
                    case 2:
                        withdraw();
                        break;
                    case 3:
                        balance();
                        break;
                    case 4:
                        transfer();
                        break;
                    case 5:
                        statement();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Wrong input. Try again...");
                        goto retry;

                }

            
        }

        void deposit()
        {
            Console.WriteLine("How much would you like to deposit: ");
            int deposit = int.Parse(Console.ReadLine());

            var mybalance = accountlist[0].Balance;
            accountlist[0].Balance = mybalance + deposit;
        }

        void withdraw()
        {
            Console.WriteLine("How much would you like to withdraw: ");
            int deposit = int.Parse(Console.ReadLine());

            var mybalance = accountlist[0].Balance;
            accountlist[0].Balance = mybalance - deposit;
        }

        void transfer()
        {
            if (accountlist.Count > 1)
            {
                Console.WriteLine("To make a transfer, enter the amount: ");
                int transfer = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the account number to transfer to: ");
                var accountTrfNo = Console.ReadLine();
                accountlist[0].Balance -= transfer;
                mainAccount = accountlist.FirstOrDefault(a => a.accountNumber == accountTrfNo);

                mainAccount.Balance += transfer;
                Console.WriteLine("Your new balance is :"+ accountlist[0].Balance);



            }

        }

        void balance()
        {
            Console.WriteLine("Your account balance is: "+ accountlist[0].Balance);
        }

        void statement()
        {
            Console.WriteLine("Full Name" + accountlist[0].firstname +" " + accountlist[0].lasttname);
            Console.WriteLine("Account number: " + accountlist[0].accountNumber);
            Console.WriteLine("Account type: "+ accountlist[0].accounttype);
            Console.WriteLine("Balance: "+ accountlist[0].Balance);
        }




    }
}

