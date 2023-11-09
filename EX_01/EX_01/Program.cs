using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] contagens = new int[4];

            while (true)
            {
                Console.Write("Digite um número (ou um número negativo para sair): ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                    break;

                if (numero >= 0 && numero <= 25)
                {
                    contagens[0]++;
                }
                else if (numero >= 26 && numero <= 50)
                {
                    contagens[1]++;
                }
                else if (numero >= 51 && numero <= 75)
                {
                    contagens[2]++;
                }
                else if (numero >= 76 && numero <= 100)
                {
                    contagens[3]++;
                }
            }

            Console.WriteLine("Contagem no intervalo [0-25]: " + contagens[0]);
            Console.WriteLine("Contagem no intervalo [26-50]: " + contagens[1]);
            Console.WriteLine("Contagem no intervalo [51-75]: " + contagens[2]);
            Console.WriteLine("Contagem no intervalo [76-100]: " + contagens[3]);

            Console.ReadKey();
        }
    }
}
