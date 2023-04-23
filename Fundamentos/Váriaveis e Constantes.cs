﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Váriaveis_e_Constantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!!!!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // Int sem sinal
            Console.WriteLine("A população Brasileira é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            // Tipos reais

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);


        }
    }
}
