using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //select options
            Console.WriteLine("Select 1 to print the first 20 numbers");
            Console.WriteLine("Select 2 to print the  squares of n numbers");
            Console.WriteLine("Select 3 to print the first 20 numbers");
            Console.WriteLine("Select 4 to print the first 20 numbers");
            Console.WriteLine("Select 5 to print the first 20 numbers");
            Console.WriteLine("Select 6 to print the first 20 numbers");
            Console.WriteLine("Select 7 to print the first 20 numbers");

            //print first 20 numbers

            Console.WriteLine(" List of numbers from 1-20:\n");
            for (int i = 1; i <= 20; i++)
          
                Console.WriteLine("{0}", i);




            //print the square of n numbers
            
           
            int Sum = 0;
            Console.WriteLine("Input the number of terms to calculate");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine("Input the next number to calculate");
               int Response= int.Parse( Console.ReadLine());

                Sum = (Sum + Response);

            }
          int Square = (Sum * Sum);
            Console.WriteLine("{0}", Square);
            Console.ReadLine();
        }

    }
}
