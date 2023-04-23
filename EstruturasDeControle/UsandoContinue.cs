using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Console.WriteLine("Numeros pares entre 1 e {0}", intervalo);
            Console.ResetColor();

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(i + " ");
                Console.ResetColor();

            }   
            
        }
    }
}
