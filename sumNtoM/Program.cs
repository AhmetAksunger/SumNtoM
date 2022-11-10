using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNtoM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumNtoM(2, 10);
            sumNtoM(10, 2);
            Console.ReadLine();
        }
        static void sumNtoM(int n, int m)
        {
            
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter the starting number: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the last number");
                m = Convert.ToInt32(Console.ReadLine());
                if (n > m)
                {
                    sumNtoM(m, n);
                }
                for (int i = n; i <= m; i++)
                {
                    sum = sum + i;
                }
                if (m > n)
                {
                    Console.WriteLine(sum);
                }
            }
            

        }
    }
}
