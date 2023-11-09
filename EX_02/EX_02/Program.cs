using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            int value, total;
            total = 1;

            Console.WriteLine("Digite um número: ");
            value = int.Parse(Console.ReadLine());
            result = $"{value}";

            for (int i = value; i > 1; i--)
            {
                total *= i;
                result += $" x {i - 1}";
            }

            Console.WriteLine($"{value}! = {result} = {total}");

            Console.ReadKey();
        }
    }
}
