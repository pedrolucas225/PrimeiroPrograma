using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio1 {
        public static void Executar() {
            //1 – Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Meu nome é: ");
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(nome);
                Console.ResetColor();  
            }
            
        }
    }
}
