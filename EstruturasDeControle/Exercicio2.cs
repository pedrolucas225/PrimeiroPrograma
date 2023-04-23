using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio2 {
        public static void Executar() {
            
            string continuar;
            do {
                Console.Write("Digite um numero, para saber se ele é par ou impar: ");
                int.TryParse(Console.ReadLine(), out int NumeroDigitado);
                if (NumeroDigitado % 2 == 0) {

                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("<<<Este número é par>>>");
                    Console.ResetColor();
                }

                else {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("<<<Este número é impar>>>");
                    Console.ResetColor();
                }
                Console.WriteLine("Deseja continuar?(S/N)");
                continuar = Console.ReadLine();
            } while (continuar.ToLower() == "s");

            












        }
    }
}
