using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Progressão Aritmética 🔥🔥🔥");
Console.WriteLine("---------------------------------\n");

Thread.Sleep(1000);
float razao;
int vezes;
float comeco;

Console.WriteLine("digite o número inicial da progressão aritmética:");
while (!float.TryParse(Console.ReadLine(), out comeco))
{
    Console.WriteLine("um número válido, por favor");
    float.TryParse(Console.ReadLine(), out comeco);
}

Console.WriteLine("digite a RAZÃO da progressão aritmética:");
while (!float.TryParse(Console.ReadLine(), out razao))
{
    Console.WriteLine("um número válido, por favor");
    float.TryParse(Console.ReadLine(), out razao);
}

Console.WriteLine("até que número?:");
while (!int.TryParse(Console.ReadLine(), out vezes))
{
    Console.WriteLine("um número válido, por favor");
    int.TryParse(Console.ReadLine(), out vezes);
}

for (float i = comeco; i <= vezes; i += razao)
{
    Console.Write($"{i} ➡️ ");
    Thread.Sleep(1);
}
Console.WriteLine("👍");