using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(num);
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Отрицательное число");
               
            }
            else
            {
                double f = 1;
                for (int i = 1; i < n + 1; i++)
                {
                    f = f * i;
                    Thread.Sleep(5);
                }
                Console.WriteLine(f);
            }
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
