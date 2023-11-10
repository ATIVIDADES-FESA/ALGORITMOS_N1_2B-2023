using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            
            while (true)
            {
                Console.Write("Quantos nomes você quer informar? ");

                quantidade = int.Parse(Console.ReadLine());

                if(quantidade > 0 && quantidade <= 30)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Informe no mínimo 1 ou no máximo 30");
                }
            }

            string[] nomes = new string[quantidade];

            for(int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine();
            }

            while(true)
            {
                int userInput;

                while(true)
                {
                    Console.WriteLine("1-> Exibir todos os nomes");
                    Console.WriteLine("2-> Exibir o maior nome");
                    Console.WriteLine("3-> Exibir apenas o primeiro nome");
                    Console.WriteLine("4-> Exibir apenas os nomes que inicial com vogal");
                    Console.WriteLine("5-> Sair");

                    userInput = int.Parse(Console.ReadLine());

                    if(userInput >= 1 && userInput <= 5)
                    {
                        break;
                    }
                }

                if(userInput == 1)
                {
                    Console.WriteLine("===TODOS OS NOMES===");
                    for(int i = 0; i < nomes.Length; i++)
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }

                if(userInput == 2)
                {
                    int maiorComprimento = 0;

                    foreach (string nome in nomes)
                    {
                        if (nome.Length > maiorComprimento)
                        {
                            maiorComprimento = nome.Length;
                        }
                    }

                    Console.WriteLine("===MAIOR(ES) NOME(S)===");

                    foreach (string nome in nomes)
                    {
                        if (nome.Length == maiorComprimento)
                        {
                            Console.WriteLine(nome);
                        }
                    }
                }

                if(userInput == 3)
                {
                    string[] nomesRetorno = new string[nomes.Length];

                    for(int i = 0; i < nomes.Length; i++)
                    {
                        string primeiroNome;
                        primeiroNome = nomes[i].Split(' ')[0];
                        nomesRetorno[i] = primeiroNome;
                    }

                    Console.WriteLine("===PRIMEIRO NOME===");

                    for(int i = 0; i < nomesRetorno.Length; i++)
                    {
                        Console.WriteLine(nomesRetorno[i]);
                    }
                }

                if(userInput == 4)
                {
                    Console.WriteLine("===NOME QUE INICIAM COM VOGAIS===");
                    foreach(string nome in nomes)
                    {
                        if (nome.Length > 0 && "aeiouAEIOU".Contains(nome[0]))
                        {
                            Console.WriteLine(nome);
                        }
                    }
                }

                if(userInput == 5)
                {
                    break;
                }
            }
        }
    }
}
