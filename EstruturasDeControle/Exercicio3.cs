using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio3 {
        public static void Executar() {
            //4 – Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
            //se for menor que 18 anos exiba na cor vermelha “Sem permissão”,
            //caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.

            int idade;
            int idadePermitida = 18;
            Console.WriteLine("Para ter acesso as essas informações. Você teria que ser maior de idade!\n");
            Console.WriteLine("Por favor, digite a sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            if (idade >= idadePermitida) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida!");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão!");
                Console.ResetColor();
            }
        }
    }
}
