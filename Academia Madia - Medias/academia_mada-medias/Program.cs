using System;
using System.Media;

Console.OutputEncoding = System.Text.Encoding.UTF8;

#region definições
//DIÁLOGOS

void dialogo(string texto, int delay, int formatacao = 0)
{
    for (int i = 0; i < texto.Length; i++)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.Enter)
            {
                switch (formatacao)
                {
                    case 1:
                        Console.Write($"\u001b[3m{texto.Substring(i)}\u001b[0m");
                        break;
                    case 2:
                        Console.Write($"\u001b[1m{texto.Substring(i)}\u001b[0m");
                        break;
                    default:
                        Console.Write(texto.Substring(i));
                        break;
                }
                break;
            }
        }

        switch (formatacao)
        {
            case 1:
                Console.Write($"\u001b[3m{texto[i]}\u001b[0m");
                break;
            case 2:
                Console.Write($"\u001b[1m{texto[i]}\u001b[0m");
                break;
            default:
                Console.Write(texto[i]);
                break;
        }
        Thread.Sleep(delay);
    }

    Console.Write("\n");

    while (Console.KeyAvailable)
    {
        Console.ReadKey(true);
    }

    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {

    }
}

void dialogo_continuo(string texto, int delay, int formatacao = 0)
{
    for (int i = 0; i < texto.Length; i++)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.Enter)
            {
                switch (formatacao)
                {
                    case 1:
                        Console.Write($"\u001b[3m{texto.Substring(i)}\u001b[0m");
                        break;
                    case 2:
                        Console.Write($"\u001b[1m{texto.Substring(i)}\u001b[0m");
                        break;
                    default:
                        Console.Write(texto.Substring(i));
                        break;
                }
                break;
            }
        }

        switch (formatacao)
        {
            case 1:
                Console.Write($"\u001b[3m{texto[i]}\u001b[0m");
                break;
            case 2:
                Console.Write($"\u001b[1m{texto[i]}\u001b[0m");
                break;
            default:
                Console.Write(texto[i]);
                break;
        }
        Thread.Sleep(delay);
    }

    while (Console.KeyAvailable)
    {
        Console.ReadKey(true);
    }
}

//MÉDIAS
SoundPlayer som = new SoundPlayer(@"pipipi.wav");
List<double> notas = new List<double>();
List<double> medias = new List<double>();
List<string> nomes = new List<string>();
int quant = 0;
int count = 0;
void digitarNota()
{
    while (count < 4)
    {
        Console.WriteLine($"\nDigite a {notas.Count + 1}ª nota:");

        double nota;

        while (!double.TryParse(Console.ReadLine().Replace(".", ","), out nota))
        {
            dialogo_continuo("INSIRA UM NÚMERO, IMBECÍL!!\n", 15);
        }

        notas.Add(nota);
        count++;
    }
}

void aluno()
{
    dialogo_continuo("\nPrimeiro, digite o nome do aluno:", 15);

    string nome = Console.ReadLine();

    while (string.IsNullOrEmpty(nome) || nomes.Contains(nome))
    {
        if (nomes.Contains(nome))
        {
            dialogo_continuo("DIGITA UM NOME QUE NÃO FOI USADO ANTES!!\n", 15);
        }
        else
        {
            dialogo_continuo("DIGITA UM NOME!!\n", 15);
        }
        nome = Console.ReadLine();
    }

    nomes.Add(nome);
}

double soma(List<double> lista)
{
    double total = 0;
    foreach (double nota in lista)
    {
        total += nota;
    }
    return total;
}

double media(double total, List<double> lista)
{
    return Math.Round(total / lista.Count);
}

void status(double med)
{
    if (med == 0)
    {
        dialogo("quem é esse animal?? pelo amor, certeza que é a nota do Igor", 15);
    }
    else if (med < 5)
    {
        dialogo("ah... beleza, mais um imbecíl pra conta, 0 novidades", 15);
    }
    else if (med < 7)
    {
        dialogo("Uhhhh, por pouco viu?", 15);
    }
    else if (med < 8)
    {
        dialogo("esse daí colou, certeza, o mínimo pra passar", 15);
    }
    else if (med < 10)
    {
        dialogo("Bom, mas podia ter sido um 10, né?", 15);
    }
    else
    {
        dialogo("não fez mais que a obrigação", 15);
    }

    if (med < 7)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        dialogo("REPROVADO!!", 15);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        dialogo("APROVADO!!", 15);
        Console.ResetColor();
    }
}

void estrutura()
{
    while (true)
    {
        notas.Clear();
        count = 0;

        aluno();

        dialogo_continuo("Tá, agora as notas\n", 15);

        digitarNota();

        double resultado = media(soma(notas), notas);
        medias.Add(resultado);

        dialogo_continuo("\ntá, tá, agora o sistema faz o resto\n", 15);

        som.Play();
        dialogo_continuo("...", 1000);
        som.Stop();
        dialogo("\nbeleza, tudo pronto", 15);
        dialogo($"média {resultado}...", 15);

        status(resultado);

        dialogo_continuo("Mais algum aluno? (S/N)\n", 15);

        string resposta = Console.ReadLine();

        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
        {
            dialogo_continuo("S/N!!\n", 15);
            resposta = Console.ReadLine();
        }

        if (resposta.ToUpper() == "N")
        {
            break;
        }

        dialogo("Tá, então vamos continuar", 15);
    }
}
#endregion

Console.WriteLine(".-.~Academia Madia~.-.");
Console.WriteLine("-----------------------------");

dialogo("Olá novo membro, seja bem-vindo a Academia Madia e blablabla", 15);
dialogo("Tá tá, vamos pular toda essa apresentação, tô precisando de ajuda pra calcular as médias dos alunos, ok?", 15);
dialogo("Só dá as notas e o sistema mágico faz o resto", 15);

estrutura();

dialogo_continuo("Beleza, então as médias são:\n\n", 15);

foreach (string n in nomes)
{
    Console.WriteLine($"{n}: {medias[nomes.IndexOf(n)]}");
}

dialogo($"\nE a média da sala é: {media(soma(medias), medias)}", 15);

dialogo_continuo("\ntá ótimo, valeu pela ajuda", 15);