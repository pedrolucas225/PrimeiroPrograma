using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio4 {
        public static void Executar() {
            //4 - Crie um algoritmo que calcule a média de um aluno no semestre.

            double notaP1;
            double notaP2;
            double outros;
            double quiz;

            Console.WriteLine("Digite a sua nota da P1: ");
            double.TryParse(Console.ReadLine(), out notaP1);

            Console.WriteLine("Digite a sua nota da P2: ");
            double.TryParse(Console.ReadLine(), out notaP2);

            Console.WriteLine("Digite a sua nota de Outros: ");
            double.TryParse(Console.ReadLine(), out outros);

            Console.WriteLine("Digite a sua nota de Quiz: ");
            double.TryParse(Console.ReadLine(), out quiz);

           double mediaP1P2 = ((notaP1 * 0.6) + (notaP2 * 0.6)) / 2;
            Console.WriteLine("Média de P1 e P2: {0}", mediaP1P2);
           double mediaOutros = outros * 0.2;
            Console.WriteLine("Média de Outros: {0}", mediaOutros);
           double mediaQuiz = quiz * 0.2;
            Console.WriteLine("Média de Quiz: {0}", mediaQuiz);

           double mediaTotal = mediaP1P2 + mediaOutros + mediaQuiz;
            Console.WriteLine("A sua média seria: {0}", mediaTotal);

            if (mediaTotal >= 7) {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Aprovado!!!");
                Console.ResetColor();
            }
            else if (mediaTotal >= 5) {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Exame!!!");
                Console.ResetColor();

            }
            else {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Reprovado!!!");
                Console.ResetColor();

            }
                
        }
    }
}
