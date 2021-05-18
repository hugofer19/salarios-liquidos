using System;

namespace Salários
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            double bruto, segSocial, irs, liquido;

            //obtenção de dados
            Console.Write("Salário Bruto:");
            bruto = double.Parse(Console.ReadLine());

            //calculo

            segSocial = bruto * 0.2;
            if(bruto < 500)
            {
                irs = 0;
            }
            else if(bruto >= 500 && bruto < 1000)
            {
                irs = bruto * 0.12;
            }
            else if(bruto >= 1000 && bruto < 1500)
            {
                irs = bruto * 0.15;
            }
            else
            {
                irs = bruto * 0.18;
            }
            liquido = bruto - segSocial - irs;

            //apresentar resultado
            Console.WriteLine("Líquido: " + liquido);
            Console.Read();
        }
    }
}
