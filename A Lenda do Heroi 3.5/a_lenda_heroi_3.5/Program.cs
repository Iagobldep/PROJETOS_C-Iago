/*
Olá, aventureiros(as) de C#! 🚀 Hoje vamos aplicar nossos conhecimentos de manipulação de vetores (arrays) e Clean Code em uma missão épica! 🧹💻
🎯 O seu objetivo: Vocês foram convocados pela Guilda dos Aventureiros 🛡️ para criar um programa de console que calcula a média de poder das habilidades de seus heróis e exibe o resultado final. Vocês podem escolher focar na precisão das flechas de um Arqueiro, na potência das poções de um Alquimista ou na energia vital restaurada por uma Dríade.
📋 Tarefas do programa:📦 Declare um vetor (array) utilizando o tipo double para armazenar os valores das habilidades (ex: dano de 5 flechas, cura de 4 poções ou mana de 3 sementes da natureza).📏 Utilize a propriedade .Length para descobrir o tamanho desse vetor dinamicamente durante o cálculo.🧮 Percorra o vetor, some todos os valores de poder e calcule a média da habilidade do herói escolhido.🖨️ Exiba o resultado final no terminal para o Mestre da Guilda utilizando Console.WriteLine.
✨ Regras de Ouro (Aplicando Clean Code):
🏷️ Nomes descritivos: Evitem nomes obscuros ou genéricos. Usem variáveis concisas e claras, como danoDasFlechas, curaDasPocoes, energiaDasDriades e mediaDePoder, para que o código seja autoexplicativo.
🧩 KISS (Keep It Stupid Simple): Mantenham a solução estupidamente simples e direta, sem complicar o que não precisa ser complicado.
📏 Funções com um único objetivo: Criem um método pequeno e com apenas um objetivo exclusivo para calcular a média, separando essa responsabilidade do resto do código.
A Guilda conta com vocês! Mãos à obra e boa codificação! ⌨️🔥
*/

#region definições
using System;
using System.Numerics;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

void dialogo(string texto, int vel)
{
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }

    Console.ReadLine();
}
void dialogo_continuo(string texto, int vel)
{
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }
}
void dialogo_negrito(string texto, int vel)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }
    Console.ResetColor();
}

/// <summary>
/// coisas
/// <\summary>
/// <summary>
/// Exibe um texto no console com efeito de digitação e cor personalizada.
/// 
/// Tabela de cores:
/// 1  = Magenta
/// 2  = Blue
/// 3  = Red
/// 4  = Yellow
/// 5  = DarkGreen
/// 6  = Cyan
/// 7  = White
/// 8  = DarkRed
/// 9  = DarkBlue
/// 10 = DarkMagenta
/// 11 = DarkYellow
/// 12 = Gray
/// 13 = DarkGray
/// 14 = Green
/// 15 = Black (pode não aparecer em fundo preto)
/// 
/// Qualquer outro valor = cor padrão do console
/// </summary>
/// <param name="texto">Texto que será exibido</param>
/// <param name="vel">Velocidade da digitação (em milissegundos)</param>
/// <param name="cor">Número correspondente à cor desejada</param>
void dialogo_colorido(string texto, int vel, int cor)
{
    switch (cor)
    {
        default:
            Console.ResetColor();
            break;
        case 1:
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            break;
        case 6:
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        case 7:
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case 8:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            break;
        case 9:
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            break;
        case 10:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            break;
        case 11:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            break;
        case 12:
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case 13:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            break;
        case 14:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case 15:
            Console.ForegroundColor = ConsoleColor.Black;
            break;
    }

    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }
    Console.ResetColor();
}

double[] dano_flechas = { 5, 10, 15, 20, 25 };
#endregion

Console.WriteLine("A Lendo do Herói 3.5:\n");
Console.WriteLine("-----------------------------------------------\n");


