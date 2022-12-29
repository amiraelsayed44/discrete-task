using System;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(" please enter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" please enter the second number");
            int n2 = int.Parse(Console.ReadLine());
            for (int x = n1; x <= n2; x++)
            {
                bool prime = true;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        prime = false;
                        
                    }

                }
                if (prime)
                    Console.WriteLine(x + " is prime number");


            }

           

               
            
        }
    }
}
