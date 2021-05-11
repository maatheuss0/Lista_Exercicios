using System;

namespace produto_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "";
            int quantidade = 0;
            double preçoUnitario = 0;
            double desconto = 0;
            double total = 0;
            double valor = 0;


            Console.WriteLine("Bem vindo ao mercado!!!");

            Console.WriteLine("Insira o nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("Escreva o preço unitário: ");
            preçoUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= 5)
            {
                total = quantidade * preçoUnitario;
                desconto = total * 0.02;
                valor = total - desconto;

                Console.WriteLine("Você comprou: " + quantidade);
                Console.WriteLine("Com o desconto de: " + desconto);
                Console.WriteLine("Você ira pagar: " + valor.ToString("N2"));
            }

            else if (quantidade > 5 && quantidade <= 10)
            {
                total = quantidade * preçoUnitario;
                desconto = total * 0.03;
                valor = total - desconto;

                Console.WriteLine("Você comprou: " + quantidade);
                Console.WriteLine("Com o desconto de: " + desconto);
                Console.WriteLine("Você ira pagar: " + valor.ToString("N2"));
            }

            else
            {
                total = quantidade * preçoUnitario;
                desconto = total * 0.05;
                valor = total - desconto;

                Console.WriteLine("Você comprou: " + quantidade);
                Console.WriteLine("Com o desconto de: " + desconto);
                Console.WriteLine("Você ira pagar: " + valor.ToString("N2"));
            }

        }
    }
}
