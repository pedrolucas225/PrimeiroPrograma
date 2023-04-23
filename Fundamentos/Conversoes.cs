using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {

        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine("O valor quebrado convertido seria: {0}",quebrado);

            double nota = 9.7;
            int notaTrucada = (int) nota;
            Console.WriteLine("A nota Trucada seria: {0}",notaTrucada);

            Console.WriteLine("Digite a sua idade: ");
            string IdadeString = Console.ReadLine();
            int IdadeIteira = int.Parse(IdadeString);
            Console.WriteLine("Idade inserida: {0}", IdadeIteira);

            IdadeIteira = Convert.ToInt32(IdadeIteira);
            Console.WriteLine("Resultado: {0}", IdadeIteira);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado: {0}", numero1);

            Console.WriteLine("Digite o segundao número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);
        }
    }
}
