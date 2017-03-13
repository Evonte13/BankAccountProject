using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Reserve : Accounts
    {


        private int reserveAccountNumber;
        private double reserveAccountBalance;




        //Constructors



        public Reserve()
        {

            this.reserveAccountNumber = 123445;
            this.reserveAccountBalance = 1750;

        }


        //Properties

        public int ReserveAccountNumber
        {
            get { return this.reserveAccountNumber; }
            set { this.reserveAccountNumber = value; }
        }
        public double ReserveAccountBalance
        {
            get { return this.reserveAccountBalance; }
            set { this.reserveAccountBalance = value; }
        }



        //Methods

        public  void AddReserve()
        {
            Console.WriteLine("We can review your Reserve account to see if you qualify for a larger reserve amount.");
            Console.WriteLine("Please enter your three digit credit score");
            int creditScore = Convert.ToInt32(Console.ReadLine());
            int reserveBump = 3000;
            Console.WriteLine("Thank you. You have earned additional reserve in the amount of +" + reserveBump + " on " + DateTime.Now);
            reserveAccountBalance = reserveAccountBalance + reserveBump;
            Console.WriteLine("Your total available reserve is: " + reserveAccountBalance);

        }

        public void PrintReserveStats()
        {
            Console.WriteLine("Reserve Balance: " + this.reserveAccountBalance);

        }



    }
}
