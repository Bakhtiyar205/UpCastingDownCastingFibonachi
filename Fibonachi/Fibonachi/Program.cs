using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());   
            int n1 = 0;
            int n2 = 1;
            Console.Write(n1 +" "+n2+" ");
            for (int i = 2; i < n; i++)
            {

                Console.Write((i - 1) + i - 2 + " ");
            }
        }
    }
}
