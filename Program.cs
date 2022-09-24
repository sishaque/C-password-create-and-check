using System;

namespace first_csharp
{
    class Program 
    {
        public static void Main(string[] args)
        {
           string set_password()
           {
            Console.WriteLine("Pick your password: ");
            string password = Console.ReadLine();
            return password;
           }

           void verify_password()
           {
            string check = set_password();
            while (true)
            {
                Console.WriteLine("Enter your password: ");
                string your_pass = Console.ReadLine();
                if (your_pass == check)
                {
                    Console.WriteLine("Passwords Match!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Try again!");
                }
            }
           }

           verify_password();
           Console.ReadKey();

        
        }
            
    }
    
}
    


