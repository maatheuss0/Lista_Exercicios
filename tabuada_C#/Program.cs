using System;

namespace tabuada_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada iniciada!!!");

            Console.WriteLine("Insira o número desejado: ");
            int tab = Convert.ToInt16(Console.ReadLine());

            for (int c = 1; c <= 10; c++)
            {
                Console.WriteLine(tab + " x " + c + " = " + tab * c);
            }
            Console.WriteLine();
        }

    }
}
