using System;

namespace combustível_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            double Alcool, Gasolina, Desconto, Quantidade, Valor;

            Console.WriteLine("Bem vindo ao posto!!!");

            Console.WriteLine("Você gostaria de abastecer com Alcool(A) ou Gasolina(G): ");
            string respostaCombustivel = Console.ReadLine();

            switch (respostaCombustivel)
            {
                case "A":
                    Console.WriteLine("Quantos litros irão ser colocados?: ");
                    Quantidade = double.Parse(Console.ReadLine());
                    if (Quantidade <= 20)
                    {
                        Alcool = Quantidade * 4.90;
                        Desconto = Quantidade * 0.03;
                        Valor = Alcool - Desconto;
                        Console.WriteLine("Você ira pagar: " + Valor.ToString("N2"));
                    }
                    else 
                    {
                        Alcool = Quantidade * 4.90;
                        Desconto = Quantidade * 0.05;
                        Valor = Alcool - Desconto;
                        Console.WriteLine("Você ira pagar: " + Valor.ToString("N2"));
                    }
                    break;

                case "G":
                    Console.WriteLine("Quantos litros irão ser colocados?: ");
                    Quantidade = double.Parse(Console.ReadLine());
                    if (Quantidade <= 20)
                    {
                        Gasolina = Quantidade * 5.30;
                        Desconto = Quantidade * 0.04;
                        Valor = Gasolina - Desconto;
                        Console.WriteLine("Você ira pagar: " + Valor.ToString("N2"));
                    }
                    else
                    {
                        Gasolina = Quantidade * 5.30;
                        Desconto = Quantidade * 0.06;
                        Valor = Gasolina - Desconto;
                        Console.WriteLine("Você ira pagar: " + Valor.ToString("N2"));
                    }
                    break;

                default:
                break;
            }
        }
    }
}
