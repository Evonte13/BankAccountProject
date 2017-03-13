using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Savings : Accounts
    {
       private double interest;
       private double savingsAccountBalance;
       private int savingsAccountNumber;

    

        //constructor
        
        public Savings()
        {
            this.savingsAccountBalance = 2000;
            this.interest = .035;
            this.savingsAccountNumber = 12309876;
        }


       //properties
        public double Interest { get; set; }
        public int SavingsAccountBalance { get; set; }
        public int SavingsAccountNumber { get; set; }

        //methods   
        public override void Deposit()
        {
            Console.WriteLine("How much are you depositing today, in dollars and cents?");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
             
            double interestAdded = interest * savingsAccountBalance;
            savingsAccountBalance = savingsAccountBalance + depositAmount + interestAdded;

            Console.WriteLine("Thank you! Your deposit was + " + depositAmount + "and the intrest that was added"+ interest + " and your new account balance is: {0:c} " , savingsAccountBalance);
   
        }
        public  void PrintStats1()
        {

 
            Console.WriteLine("Account Name: {0}", savingsAccountBalance);




        }



    }

     


}
