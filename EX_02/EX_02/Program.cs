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
            Int64 value, total;

            Console.WriteLine("Digite um número: ");
            value = Int64.Parse(Console.ReadLine());
            result = $"{value}";
            
            total = value;
            for (Int64 i = value - 1; i > 0; i--)
            {
                total *= i;
                result += $" x {i}";
            }

            Console.WriteLine($"{value}! = {result} = {total}");

            Console.ReadKey();
        }
    }
}
