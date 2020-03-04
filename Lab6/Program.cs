using System;
using BankLibrary;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<Account> bank = new Bank<Account>("VTBBank");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\tVTB Bank\n");
            
            bool flat = true;
            while (flat)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n1.Create New Account\t\t2.Close Account\t\t3.Withdraw");
                Console.WriteLine("4.Put\t\t\t\t5.Print inform\t\t6.Transfer");
                Console.WriteLine("\t\t\t\t7.Exit");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nChoose number: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        OpenAccount(bank); break;
                    case 2:
                        CloseAccount(bank); break;
                    case 3:
                        WithDraw(bank); break;
                    case 4:
                        Put(bank); break;
                    case 5:
                        PrintInform(bank); break;
                    case 6:
                        Transfer(bank); break;
                    case 7: 
                        flat = false; 
                        continue;
                }
                bank.calculate();
            }
            Console.ReadKey();
        }
        private static void Transfer(Bank<Account> bank)
        {
            Console.Write("Transfer account ID: ");
            int idfrom = Convert.ToInt32(Console.ReadLine());
            Console.Write("Receiving account ID: ");
            int idto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            bank.Transfer(idfrom, idto, sum);

        }
        private static void OpenAccount(Bank<Account> bank)
         {
            Console.WriteLine("\nKind Of Account:\n1.Credit\t\t2.Deposit\t\t3.Demand");
            Console.Write("\nChoose number: ");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.Write("Full Name: ");
            string nameClient = Convert.ToString(Console.ReadLine());
            Console.Write("Passport: ");
            string passportClient = Convert.ToString(Console.ReadLine());
            Console.Write("Adress: ");
            string adressClient = Convert.ToString(Console.ReadLine());
            Console.Write("Sum = ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            string accountType = "";
            int period = 0;
            switch (type)
            {
                case 1: accountType = "Credit"; break;
                case 2:
                    accountType = "Deposit";
                    Console.WriteLine("Period: 30. 30 Days\t\t90. 90 Days\t\t180. 180 Days");
                    period = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3: accountType = "Demand"; break;
            }
            bank.Open(nameClient, adressClient, accountType, sum, passportClient, period);
        }
        private static void CloseAccount(Bank<Account> bank)
        {
            Console.Write("ID Account: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you sure? (y/n)");
            if (Console.ReadLine() == "n") return;
            bank.Close(id);
        }
        private static void WithDraw(Bank<Account> bank)
        {
            Console.Write("ID Account: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum withdraw: ");
            bank.Withdraw(Convert.ToDecimal(Console.ReadLine()), id);
            
        }
        private static void Put(Bank<Account> bank)
        {
            Console.Write("ID Account: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum Put: ");
            bank.Put(Convert.ToDecimal(Console.ReadLine()), id);
        }
        private static void PrintInform(Bank<Account> bank)
        {
            Console.Write("ID Account: ");
            int id = Convert.ToInt32(Console.ReadLine());
            bank.InForm(id);
        }
    }
}
