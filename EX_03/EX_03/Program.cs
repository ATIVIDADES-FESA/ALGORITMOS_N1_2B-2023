using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo, cheque;
            char userInput;

            while (true)
                {
                    Console.WriteLine("Informe o saldo da conta: ");
                    saldo = double.Parse(Console.ReadLine());

                    if(saldo > 0)
                    {
                        break;
                    }else
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Informe o limite do cheque especial");
                    cheque = double.Parse(Console.ReadLine());

                    if(cheque > 0)
                    {
                        break;
                    }else
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }
            while (true)
            {
                
                while(true)
                {
                    Console.WriteLine("Digite uma opção: ");
                    Console.WriteLine("'D' depósito: ");
                    Console.WriteLine("'S' saque: ");
                    Console.WriteLine("'V' visualizar saldo: ");
                    Console.WriteLine("'X' sair: ");

                    userInput = Console.ReadLine().ToUpper()[0];

                    if (userInput != 'D' && userInput != 'S' && userInput != 'V' && userInput != 'X')
                        Console.WriteLine($"{userInput} não é uma operação válida, digite novamente: ");
                    else
                        break;
                }

                if(userInput == 'D')
                {
                    double valor;

                    while (true)
                    {
                        Console.WriteLine("Informe o valor para depósito: ");
                        valor = double.Parse(Console.ReadLine());

                        if(valor > 0)
                        {
                            saldo += valor;
                            Console.WriteLine($"Depósito realizado, seu saldo atual é: R$ {saldo}");
                            break;
                        }else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                    }

                }

                if(userInput == 'S')
                {
                    double valor;

                    while (true)
                    {
                        Console.WriteLine("Digite o valor de saque: ");
                        valor = double.Parse(Console.ReadLine());
                        if (valor < 0)
                        {
                            Console.WriteLine("Valor inválido");
                        }else if(saldo - valor < (cheque * (-1)))
                        {
                            Console.WriteLine("O valor ultrapassa o limite do seu cheque especial");
                            break;
                        }
                        else
                        {
                            saldo -= valor;
                            Console.WriteLine($"Saque realizado com sucesso, seu saldo atual é R$ {saldo}");
                            break;
                        }
                    }
                }

                if( userInput == 'V')
                {
                    Console.WriteLine($"Seu saldo atual é: R$ {saldo}");
                }

                if(userInput == 'X')
                {
                    break;
                }
            }
        }
    }
}
