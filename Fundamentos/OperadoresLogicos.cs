using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            // And - Será verdeiro se todos forem verdadeiros
            var comprouTv50 = executouTrabalho1 && executouTrabalho2;  
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            // Or - Será verdadeiro se pelo menos um for verdadeiro
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            // Xor - Será verdadeiro se somente um apenas for verdadeiro. Se mais de um for verdadeiro, será falso
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            // Negação Lógica - Pega um valor e True/False, e transforma no inverso
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
