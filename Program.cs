// Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E.
// E = 1 + 1/1! + 1/2! + 1/3! + ... + 1/N

using System;

namespace Execercloop10
{

    class Program
    {
        static double calculoEquacao(double num)  // variável num é a escolha do usuário, que é o valor de N na equação
        {
            double E, num1, fatorial;

            E = 2;              // E = 2 o ínicio da equação 1 + 1/1! = 2, então o início da equação já está calculado 
            num1 = 1;                 
            fatorial = 1;

            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 2;
            }
            else
            {
                while (num > num1)
                {
                    fatorial = fatorial * (num1 + 1);
                    E = E + (1 / fatorial);
                    num1++;
                }
                return E;
            }

        }
        public static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            Console.Write("E = {0}", calculoEquacao(Convert.ToDouble(Console.ReadLine())));
        }
    }
}