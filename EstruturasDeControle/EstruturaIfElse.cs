using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {
            double notaDeCorte = 7.0;
            Console.WriteLine("Digite a sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double reprovado = 3.0;


            if (nota >= notaDeCorte) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
