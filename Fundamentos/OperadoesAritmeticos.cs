using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoesAritmeticos
    {
        public static void Executar() {
            // Preço Desconto
            double preco ;
            double imposto;
            double desconto;
            Console.WriteLine("Digite um Preço: ");
            double.TryParse(Console.ReadLine(), out preco);

            Console.WriteLine("Digite a quantidade de imposto: ");
            double.TryParse(Console.ReadLine(), out imposto);

            Console.WriteLine("Digite a quantidade do desconto: ");
            double.TryParse(Console.ReadLine(), out desconto);

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço total é: {0}", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            //Número Par/Impar

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
