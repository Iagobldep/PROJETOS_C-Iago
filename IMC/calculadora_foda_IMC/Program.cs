using System;
using System.Threading;
using System.Xml.Serialization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

float altura, peso, imc;
/*
variaveis altura, peso, imc
ler altura e peso
imc = peso / altura²Math.Pow(altura, 2)
IMC Classificação
Menos de 18,5: Abaixo do peso
se 18, 5 - 24,9: Peso normal
senao se 25,0 - 29,9: Sobrepeso
senao se 30,0 - 34,9: Obesidade grau I
senao se 35,0 - 39,9: Obesidade grau II
senao acima de 40: Obesidade grau III
fim
 */

Console.WriteLine("Calculadora de IMC do Iagão 😀👍");
Console.WriteLine("---------------------------------");
Thread.Sleep(1000);
Console.WriteLine("\nAperte Enter para começar...");
Console.ReadLine();

Console.WriteLine("\nDigite seu peso em kg:");

while (!float.TryParse(Console.ReadLine().Replace(".", ","), out peso))
{ 
    Console.WriteLine("Um número válido, por favor:");
}

Console.WriteLine("\nTá bom, agora digite sua altura em m:");

while (!float.TryParse(Console.ReadLine().Replace(".", ","), out altura))
{
    Console.WriteLine("Um número válido, por favor:");
}

Console.WriteLine("Ok, só um minuto");

Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);

imc = peso / (float)(Math.Pow(altura, 2));
imc = (float)(Math.Round(imc, 2));
string estado;

if (imc < 18)
{
    estado = "Magreza";
}
else if (imc < 24.9)
{
    estado = "Normal";
}
else if (imc < 29.9)
{
    estado = "Sobrepeso";
}
else if (imc < 39.9)
{
    estado = "Obesidade";
}
else
{
    estado = @"
    .-------------'```'----....,,__                        _,
   |                               `'`'`'`'-.,.__        .'(
   |                                             `'--._.'   )
   |                                                   `'-.<
   \               .-'`'-.                            -.    `\
    \               -.o_.     _                     _,-'`\    |
     ``````''--.._.-=-._    .'  \            _,,--'`      `-._(
       (^^^^^^^^`___    '-. |    \  __,,..--'                 `
        `````````   `'--..___\    |`
                              `-.,'
";
}


Console.WriteLine("\nOk, tudo bem, temos um resultado");

Thread.Sleep(1000);

Console.WriteLine($"\nSeu peso é: {peso}\nSua altura é:{altura}\nE seu IMC é:\n {imc} e sua classificação é:\n {estado}");