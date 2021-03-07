using System;

namespace Test1
{
    class Program
    {
        public static int Sum_A(int n)
        {
            int  i,total;
            for (i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");
            total = n * (n + 1) / 2;
            Console.WriteLine("Sum of 1 to " + total);

            return total;

        }
        public static int Sum_B(int n)
        {
            int i=n, total;
            while (i>0)
            {
                Console.Write(i + " ");
                i--;
            }
            Console.Write("\n");
            total = n * (n + 1) / 2;

            Console.WriteLine("Sum of 1 to " + total);

            return total;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please give a number between 1-100");
            int n = Convert.ToInt32(Console.ReadLine());
            Sum_A(n);
            Sum_B(n);                 
           
       



        }
    }
}
