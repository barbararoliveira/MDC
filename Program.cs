using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, dividendo, divisor, resto;
            bool vlvalido1, vlvalido2; //vl = valor


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" ----- MDC----- \n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite o 1º número (a): ");
                    vlvalido1 = Int32.TryParse (Console.ReadLine(), out numero1);

            Console.Write("Digite o 2º número (b): ");
                    vlvalido2 = Int32.TryParse (Console.ReadLine(), out numero2);

            if (!vlvalido1 ||!vlvalido2 ||numero1 <=0 || numero2 <=0 )

            {
            Console.Write("Programa finalizado: número ");
                      Console.ForegroundColor = ConsoleColor.DarkRed;
                              Console.WriteLine("INVÁLIDO.");
                                      Console.ForegroundColor = ConsoleColor.White;
                                              Console.WriteLine("Pressione enter.");
                                                      Console.ReadKey();
                                                              Environment.Exit(-1);
            }

            if (numero1 > numero2)

            {
             dividendo = numero1;
             divisor = numero2;
            }

            else

            {
             dividendo = numero2;
             divisor = numero1;
            }

            while (dividendo % divisor !=0)

            {
             resto = dividendo % divisor;
             dividendo = divisor;
             divisor = resto;
            }

            Console.WriteLine($"MDC (a, b) = {divisor}");

            
            Console.WriteLine("\nPressione enter para finalizar <3 ");
                    Console.ReadKey();

        }
    }
}
