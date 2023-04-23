using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", Váriaveis_e_Constantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Beatriz - Amor da minha vida", Beatriz.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoesAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estruturas If - Estruturas de Controle ", EstruturaIf.Executar},
                {"Estruturas If/Else - Estruturas de Controle ", EstruturaIfElse.Executar},
                {"Estruturas If/Else/If - Estruturas de Controle ", EstruturaIfElseIf.Executar},
                {"Estruturas de Switch - Estruturas de Controle ", EstruturaSwitchClass1.Executar},
                {"Estruturas de While - Estruturas de Controle ", EstruturaWhile.Executar},
                {"Estruturas de Do While - Estruturas de Controle ", EstruturasDoWhile.Executar},
                {"Estruturas For - Estruturas de Controle ", EstruturaFor.Executar},
                {"Estruturas ForEach - Estruturas de Controle ", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle ", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle ", UsandoContinue.Executar},
                {"Execicio 1 - Estruturas de Controle ", Exercicio1.Executar},
                {"Execicio 2 - Estruturas de Controle ", Exercicio2.Executar},
                {"Execicio 3 - Estruturas de Controle ", Exercicio3.Executar},
                {"Execicio 4 - Estruturas de Controle ", Exercicio4.Executar},




            });

            central.SelecionarEExecutar();
        }
    }
}