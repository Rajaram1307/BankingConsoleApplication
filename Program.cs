using System;
class Program{
    static void Main(string []a){
        Console.WriteLine("=== BANKING MANAGEMENT SYSTEM ===");
        bool isExit = true;
        while(isExit){
            Console.WriteLine("\t\t1. Create Account");
            Console.WriteLine("\t\t2. Deposit");
            Console.WriteLine("\t\t3. Withdraw");
            Console.WriteLine("\t\t4. Check Balance");
            Console.WriteLine("\t\t5. View All Accounts");
            Console.WriteLine("\t\t6. Exit");
            Console.WriteLine("Enter choice to continue the process: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
            case 1:
                // createAccount();
                break;
            case 2:
                // deposit();
                break;
            case 3:
                // withdraw();
                break;
            case 4:
                // checkBalance();
                break;
            case 5:
                // viewAllAccount();
                break;
            case 6:
                isExit = false;
                break;
            default:
                Console.WriteLine("\t\t Invaild choice");
                break;                       
            }
        }
    }
}
