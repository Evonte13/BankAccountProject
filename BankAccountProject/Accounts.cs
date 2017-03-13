using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Accounts
    {



        //fields
        protected string accountHolder;
        protected int accountNumber;
        protected decimal accountBalance;

        
        public Accounts()
        {
            this.accountHolder = "James Bond 007";
            this.accountNumber = 25123341;
            this.accountBalance = 100000;
        }

        #region Properties
        //properties
        public string AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        #endregion

        #region Methods
        //methods 
        public virtual void Deposit()
        {
            Console.WriteLine("How much are you depositing today, in dollars and cents?");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            accountBalance = accountBalance + depositAmount;
            Console.WriteLine("Thank you! Your deposit was + " + depositAmount + " and your new account balance is: " + accountBalance);

        }

        public virtual void Withdraw()
        {
            Console.WriteLine("How much are you withdrawing today, in dollars and cents?");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            accountBalance = accountBalance - withdrawalAmount;
         
            Console.WriteLine("Thank you! Your withdrawal was  " + withdrawalAmount + " and your new account balance is: " + accountBalance);

        }
        // need to add all accounts money together to get an total balance
        public virtual void PrintStats()
        {
            Console.WriteLine("Account Name: {0}" , AccountHolder);
            Console.WriteLine("Account Number: {0}" , accountNumber);
            Console.WriteLine("Account Balance: {0}", accountBalance);
           

        }
        #endregion

    }





}

