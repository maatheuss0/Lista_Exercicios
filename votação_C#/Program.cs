using System;

namespace nascimento_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado, anoAtual;
            
            Console.WriteLine("Bem vindo a urna!!!");

            anoAtual = DateTime.Now.Year; 

            Console.WriteLine("Você pode votar? Escreva seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            resultado = anoAtual - anoNascimento;

            if (resultado >= 16)
            {
                Console.WriteLine("Você pode votar, escolha com sabedoria!!!");
            }

            else 
            {
                Console.WriteLine("Você ainda não tem a idade necessária!!!");
            }
        }
    
    }
}
