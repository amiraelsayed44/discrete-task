using System;

namespace perfect_numbers
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
                int sum = 0;
                for (int i = 1;i<x; i++)
                {
                    if (x % i == 0)
                    
                        sum=sum + i;
                  

                }

                if (x == sum)
                
                    Console.WriteLine(x);
                
            }
        }
    }
}
