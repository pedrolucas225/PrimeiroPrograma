﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaWhile {
        public static void Executar() {
            
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;


            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira um palpite");
                
                int.TryParse(Console.ReadLine(), out int palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Numero encontrado em {0} tentativas", 
                        tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
               
            
                




            }

        }
    }
}
