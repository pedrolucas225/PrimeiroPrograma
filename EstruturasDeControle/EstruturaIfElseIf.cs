using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            Console.WriteLine("Digite a nota do aluno: ");
            
            double.TryParse(Console.ReadLine(), out double notaConvertida);

            if (notaConvertida >= 9.0) {
                Console.WriteLine("Você está no quadro de Honra! E foi aprovado!");
            }
            else if (notaConvertida >= 7.0 && notaConvertida < 9.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Fez mais que sua orbigação");
            }
            else if (notaConvertida >= 5.0 && notaConvertida < 7.0) {
                Console.WriteLine("Você esta de recuperação!");
            }
            else 
            {
                Console.WriteLine("Você está reprovado!");
                Console.WriteLine("Te vejo na proxima...");
            }
            
            Console.WriteLine("Fim!!!");
        }
    }
}
