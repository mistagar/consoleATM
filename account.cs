using System;
namespace ConsoleBanking
{
    public class account
    {
        string firstName;
        string lastName;
        string accountType;
        string email;
        string password;
        double balance;
        public string accountNumber;


        public account(string firstName, string lastName, string accountType, string email, string password, string accountNumber, double balance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.accountType = accountType;
            this.email = email;
            this.password = password;
            this.accountNumber = accountNumber;
            this.balance = balance;

        }

        public string firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string lasttname
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string accounttype
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //public void openAccount()
        //{
        //    Console.WriteLine("Enter your first name: ");
        //    firstName = Console.ReadLine();

        //    Console.WriteLine("Enter your last name: ");
        //    lastName = Console.ReadLine();

        //    Console.WriteLine("Enter the option number for type of account. 1. Savings 2. Current:: ");
        //    var temp = int.Parse(Console.ReadLine());
        //    if (temp == 1)
        //        accountType = "Savings";
        //    else
        //        accountType = "Current";

        //    Console.WriteLine("Enter your email: ");
        //    email = Console.ReadLine();

        //    Console.WriteLine("Enter your password: ");
        //    password = Console.ReadLine();

        //    Console.WriteLine("How much would you like to deposit: ");
        //    balance = int.Parse(Console.ReadLine());

        //    string r;
        //    string startwith = "1001";
        //    Random rand = new Random();
        //    r = rand.Next(1, 999999).ToString("D6");
        //    accountNumber = startwith + r;



        //    Console.WriteLine("Congratulations! Your account has been created.");
        //    Console.WriteLine("Your account number is " + accountNumber);
        //    Console.WriteLine("Your account balance is " + balance);

        //}



    }
}

