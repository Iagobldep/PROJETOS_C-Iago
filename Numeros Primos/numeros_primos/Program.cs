using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("Calculadorinha massa");
    Console.WriteLine("------------------------------");
    Console.WriteLine("\nQuer ver a lista de números primos (1), a calculadora de números primos(2), a sequência de Fibonacci (3) ou a média (4)?");

    int escolha;
    int.TryParse(Console.ReadLine(), out escolha);
    while (escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4)
    {
        Console.WriteLine("escolha 1, 2, 3 ou 4, por favor");
        int.TryParse(Console.ReadLine(), out escolha);
    }

    if (escolha == 1)
    {
        Console.WriteLine("Quer a lista até que número?");

        int quant;
        int num;

        while (!int.TryParse(Console.ReadLine(), out quant))
        {
            Console.WriteLine("Um número inteiro, por favor");
            int.TryParse(Console.ReadLine(), out quant);
        }

        for (num = 1; num <= quant; num++)
        {
            int cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if (cont <= 2)
            {
                Console.WriteLine($"- {num}");
            }
        }
    }
    else if (escolha == 2)
    {
        Console.WriteLine("\nDigite um número para verificar se é primo ou não: ");

        int num;
        int cont = 0;

        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Um número inteiro e positivo, por favor");
            int.TryParse(Console.ReadLine(), out num);
        }

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                cont++;
            }
        }

        if (num == 2)
        {
            Console.WriteLine($"{num} é primo par");
        }
        else if (cont <= 2)
        {
            Console.WriteLine($"{num} é primo");
        }
        else
        {
            Console.WriteLine($"{num} não é primo");
        }
    }
    else if (escolha == 3)
    {
        Console.WriteLine("\nQuer que a sequência de Fibonacci mostre quantos números?");

        int quant, num = 1, num_ant = 1, soma;

        while (!int.TryParse(Console.ReadLine(), out quant))
        {
            Console.WriteLine("Um número inteiro, por favor");
            int.TryParse(Console.ReadLine(), out quant);
        }

        for (int i = 1; i <= quant; i++)
        {
            if (i == 1)
            {
                Console.WriteLine($"{i} - {num}");
            }
            else if (i == 2)
            {
                Console.WriteLine($"{i} - {num_ant}");
            }
            else
            {
                soma = num + num_ant;
                num = num_ant;
                num_ant = soma;
                Console.WriteLine($"{i} - {soma}");
            }
        }
    }
    else if (escolha == 4)
    {

    }

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("\nAperte Enter para outra operação");
    Console.ResetColor();
    Console.ReadLine();
    Console.Clear();
}
/* Organização de Pensamentos.
1 - se inicia no 0
2 - inicialmente soma 1
3 - sempre soma os 2 últimos dígitos
4 - O usuário escolhe o número de texto

ferramentas lógicas:

usaremos for para que a sequencia seja sequencial
precisaremos de 3 variáveis
numeroTermos
t1 1	t2 1	t3 ?
t3 = t1 + t2
t2 = t1
t1 = t3
 */