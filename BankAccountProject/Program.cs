using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking();
            Savings savings = new Savings();
            Reserve reserve = new Reserve();
            Accounts account1 = new Accounts();

            string clientInput;

            StringBuilder mainMenu = new StringBuilder();
            mainMenu.Append("OurBank Main Menu\n");
            mainMenu.Append("View Client Information, Press '1'\n");
            mainMenu.Append("View Account Balance Information, Press '2'\n");
            mainMenu.Append("To Deposit Funds from checking, Press '3'\n");
            mainMenu.Append("To Withdraw Funds from checking, Press '4'\n");
            mainMenu.Append("To Exit the Application, Press '5'\n");
            mainMenu.Append("Thank you for being a valued OurBank customer!\n");
            mainMenu.Append("Today's Date and time is: " + DateTime.Now + "\n");
            Console.WriteLine(mainMenu.ToString());
            clientInput = Console.ReadLine().ToUpper();
            if (clientInput == "1")
            {
                account1.PrintStats();
            }
            else if (clientInput == "2")
            {
                checking.PrintCheckingStats();
                reserve.PrintReserveStats();
                savings.PrintStats1();
            }
            else if (clientInput == "3")
            {
               
                checking.Deposit();
             

            }
            else if (clientInput == "4")
            {
               
                Console.WriteLine("Do you want to write a check (1), or withdraw from savings (2)?");
                int userResponse = Convert.ToInt32(Console.ReadLine());
                if (userResponse == 1)
                    checking.WriteCheck();
                else
                    savings.Withdraw();
            }
            Console.ReadKey();


            StreamWriter checkingWriter = new StreamWriter("checking.txt");
            using (checkingWriter)
            {
                checkingWriter.Write(DateTime.Now); 
            }
            StreamWriter savingsWriter = new StreamWriter("savings.txt");
            using (savingsWriter)
            {
                savingsWriter.Write(DateTime.Now);
            }
            StreamWriter reserveWriter = new StreamWriter("reserve.txt");
            using (reserveWriter)
            {
                reserveWriter.Write(DateTime.Now);
            }



        }
    }
}
