using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;
void Dialogo(string texto)
{
    Console.WriteLine (texto);
    Thread.Sleep (1000);
}

Dialogo("⚔️ A LENDA DO HERÓI 2: O INIMIGO AGORA É OUTRO ⚔️");
Dialogo("-------------------------------------------");

Console.WriteLine("Antes de começar, digite seu nome:");
string nome = Console.ReadLine();

if (nome.ToUpper() == "GASTER")
{
    Environment.Exit(0);
}

Console.WriteLine("Lindo. Agora escolha uma dessas raças:");
string[] racas = { "mago", "clérigo", "guerreiro", "druida", "anão", "elfo", "troll"};
for (int i = 0; i < racas.Length; i ++)
{
    Console.WriteLine(racas[i]);
}
string raca = Console.ReadLine();

while (racas.Contains(raca.ToLower()) == false)
{
    Console.WriteLine("Por favor, uma dessas raças:");
    for (int i = 0; i < racas.Length; i++)
    {
        Console.WriteLine(racas[i]);
    }
    raca = Console.ReadLine();
}

Console.WriteLine("Ótimo, agora defina seu nível (Número, por favor):");

int nivel = 0;
while (!int.TryParse(Console.ReadLine(), out nivel))
{
    Console.WriteLine("Número inteiro, por favor:");
}

Console.WriteLine("ok, agora seu HP (Número, por favor):");

int hp = 0;
while (!int.TryParse(Console.ReadLine(), out hp))
{
    Console.WriteLine("Número inteiro, por favor:");
}

Console.WriteLine("Perfeito, agora sua mana (Número, por favor):");

int mana = 0;
while (!int.TryParse(Console.ReadLine(), out mana))
{
    Console.WriteLine("Número inteiro, por favor:");
}

Dialogo("Perfeito, vamos te levar para sua aventura");
Dialogo("-------------------------------------------");

Dialogo("Você é um herói que acaba de chegar a uma vila, a mesma vila que seu pai um dia já salvou, que descanse em paz.");
Dialogo("Ao chegar, você é recebido por um aldeão");

Dialogo("- Bem-vindo de volta, Douglas: o herói sapequi-... espera... Quem é você? Nunca te vi por aqui antes.");
Dialogo("- De qualquer forma, um herói é um herói, meu nome é IAGULIUS");
Dialogo("- Qual é o seu nome?");

if (nome.ToUpper() == "IAGULIUS")
{
    Dialogo($"- {nome} também? Maneiro, temos o mesmo nome");
}

Dialogo($"- {nome} vejo... Interessante");
Dialogo("- De qualquer forma, a vila está sendo ameaçada por um grande dragão, mas só os membros da Guilda podem enfrentá-lo");
Dialogo("- Você precisará entrar para a Guilda para prosseguir");
Dialogo("- Mas você dever´MERECER, e para isso, quero que me responda umas coisas");
Dialogo($"- Vejo que você é um {raca} e seu nível é {nivel}");

if (raca.ToUpper() != "TROLL" && nivel >= 5)
{
    Dialogo("Beleza, você pode entrar, vejo que você é forte o bastante");
}
else if (raca.ToUpper() == "TROLL")
{
    Dialogo("Desculpa, não aceitamos trolls em nossa guilda");
}
else
{
    Dialogo("Desculpa, mas você é fraco demais");
}