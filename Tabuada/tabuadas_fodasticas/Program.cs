Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("TABUADONA MASSA 🔥🔥🔥");
Console.WriteLine("__________________________");

int tabuada = 1;

//while (tabuada <= 10)
for (int j = 1; j <= 10; j++)
{
    Console.WriteLine($"\nTabuada do {tabuada}");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
    }
    tabuada ++;
}