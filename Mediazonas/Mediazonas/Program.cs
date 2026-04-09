using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("MediaZonas 🔥🔥🔥");
Console.WriteLine("---------------------------------------");

/*
declarar variaveis
1º loop infinito
sair
ler
se sair = s
break
2º loop enquanto sair diferente de sim e diferente de nao
loop

break. sai 2º loop

se sair == s
break sai 1º loop
 */

int quant = 0;
double n = 0, media, notas = 0;
string sair = "";

while (true)
{
    Console.WriteLine($"\nDigite a {quant + 1}ª nota:");
    while (!double.TryParse(Console.ReadLine()!.Replace(".", ","), out n))
    {
        Console.WriteLine("Digite um número válido para a nota:");
    }
    notas += n;
    quant++;

    Console.WriteLine("\nDeseja finalizar? (s/n)");
    sair = Console.ReadLine();

    while (sair.ToLower() != "s" && sair.ToLower() != "n")
    {
        Console.WriteLine("Digite somente 's' para sim ou 'n' para não:");
        sair = Console.ReadLine();
    }

    if (sair.ToLower() == "s")
    {
        break;
    }
}

media = Math.Round(notas / quant, 1);

Console.WriteLine($"\nCalculando média");
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);

Console.WriteLine($"\nA média das notas é: {media}");