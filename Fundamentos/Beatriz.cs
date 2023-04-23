using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Beatriz
    {
        public static void Executar() {




            Console.WriteLine("Você quer casar comigo? ");
            string resposta = Console.ReadLine();

            if (resposta == "s") {
                Console.WriteLine("Sabia que ia dizer sim :)");
                Console.WriteLine("--------------- Fala não pra vc vê --------------", resposta);
            }
            else if (resposta == "n") {
                Console.WriteLine("Vou me matar ali e ja volto");
            }
            
           
            
        }
    }
}
