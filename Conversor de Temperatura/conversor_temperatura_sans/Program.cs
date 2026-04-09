using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//Autoriuza o uso de emojis e caracteres especiais do português
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️🌨️");
Console.WriteLine("Bem-vindo ao conversor legal do sans, como foi sua queda? :D");
Console.WriteLine("⠀⠀⠀⠀⠀⠀⢀⣀⣀⡠⠤⠤⠂⠒⢒⣒⠦⠤⣤⢤⡀⠀⠀⠀\n⠀⠀⣠⠖⠉⠉⡀⠀⠀⣀⡀⠀⠀⠔⡩⡴⡶⣖⠶⡖⡅⣧⡀⠀\n⠀⡊⠀⠀⠀⣤⣗⢩⣏⡉⢷⠐⡽⣡⡯⢿⣿⣿⣷⣹⢼⠀⢸⠀\n⢸⠀⠀⠀⠀⡿⡏⢏⠀⠈⡿⡇⣳⡏⠀⠀⣧⣿⠿⡯⡟⠀⡜⠀\n⠘⡄⠀⠀⠀⠹⢼⡭⣷⡿⡫⠉⠻⠟⣿⣟⣿⡛⠀⠀⠀⡞⠁⠀\n⠀⠉⣆⠀⠀⠀⠀⠐⠛⠉⣡⡞⡇⠀⠀⡄⠊⠀⠀⢠⠞⠁⠀⠀\n⠀⢀⡬⠃⡼⢤⡀⠀⠀⠘⠋⠯⠋⠁⠉⢀⣀⠀⠀⠀⠉⠢⣄⠀\n⠸⡁⠀⠀⠈⢦⠈⠕⠦⠤⡧⠔⠊⠹⠁⠀⠈⠙⢦⠀⠀⠀⠀⢇\n⠀⠙⠮⣦⠀⠀⠁⣾⠀⠀⠀⡇⠀⠀⠀⣇⣀⣀⡤⠖⠃⠀⢠⠏\n⠀⠀⠀⠈⠙⢄⡀⠀⠉⠑⠒⠉⠉⠁⠉⠀⠀⠀⢀⡀⠔⠚⠁⠀\n⠀⠀⠀⠀⠀⠀⠈⠁⠓⠤⣄⣀⣀⣀⡀⡀⠤⠂⠉⠀⠀⠀⠀⠀\n");
Console.WriteLine("Ps: ouvi dizer que um tal de Toninho disse que o dele é melhor que o meu, é mentira, tá?");
Console.WriteLine("🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴🦴");

bool carac_certo = false;
float celsius = 0;
float fahren = 0;
float kelvin = 0;

while (carac_certo == false)
{
    Console.WriteLine("\ndigita a temperatura em celsius pra eu converter para fahrenheit e kelvin aí:");

    if (float.TryParse(Console.ReadLine(), out celsius))
    {
        fahren = (celsius * 9 / 5) + 32;
        kelvin = celsius + 273.15f;
        carac_certo = true;
    }
    else
    {
        Console.WriteLine("não, só números.");
    }
}

Console.WriteLine("beleza, espera eu calcular aqui...");
Console.WriteLine("");
Thread.Sleep(1000);
for (int i = 0; i < 3; i++)
{
    Console.Write(".");
    Thread.Sleep(1000);
}

Console.WriteLine($"ok, calculando {celsius}°C para fahrenheit o resultado dá {fahren}°F, e para kelvin dá {kelvin}°K");

//fahrenheit
Thread.Sleep(1000);
carac_certo = false;

while (carac_certo == false)
{
    Console.WriteLine("\nbelê, agora digita a temperatura em fahrenheit pra eu converter para celsius e kelvin aí:");

    if (float.TryParse(Console.ReadLine(), out fahren))
    {
        celsius = (fahren - 32) * 5/9;
        kelvin = celsius + 273.15f;
        carac_certo = true;
    }
    else
    {
        Console.WriteLine("não, só números.");
    }
}

Console.WriteLine("beleza, deixa eu calcular aqui de novo...");
Console.WriteLine("");
Thread.Sleep(1000);
for (int i = 0; i < 3; i++)
{
    Console.Write(".");
    Thread.Sleep(1000);
}

Console.WriteLine($"tome, calculando {fahren}°F para celsius o resultado dá {celsius}°C, e pra kelvin dá {kelvin}°K");

//kelvin
Thread.Sleep(1000);
carac_certo = false;

while (carac_certo == false)
{
    Console.WriteLine("\nok, o último agora, digita a temperatura em kelvin pra eu converter para celsius e fahrenheit aí:");

    if (float.TryParse(Console.ReadLine(), out kelvin))
    {
        celsius = kelvin - 273.15f;
        fahren = (kelvin - 273.15f) * 9f / 5f + 32f;
        carac_certo = true;
    }
    else
    {
        Console.WriteLine("não, só números.");
    }
}

Console.WriteLine("ok, último cálculo...");
Console.WriteLine("");
Thread.Sleep(1000);
for (int i = 0; i < 3; i++)
{
    Console.Write(".");
    Thread.Sleep(1000);
}

Console.WriteLine($"tá na mão, calculando {kelvin}°K para celsius o resultado dá {celsius}°C, e pra fahrenheit dá {fahren}°F");

Thread.Sleep(1000);

Console.WriteLine("é isso aí, acho que tá tudo certinho, qualquer erro fala pra toriel ou pra alphys que fez isso aqui 👍");