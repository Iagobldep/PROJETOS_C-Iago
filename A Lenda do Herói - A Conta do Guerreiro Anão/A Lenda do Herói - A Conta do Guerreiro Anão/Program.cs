using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] personagens = {"Joaquim", "João Macarrão", "Alex", "Thorin"};
void dialogo(string texto, int vel)
{
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }

    Console.Write("\n");
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
void fala(string texto, int vel, int persona)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{personagens[persona]}:\n");
    Console.ResetColor();
    Console.Write("- ");
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }

    Console.Write("\n\n");
    Console.ReadLine();
}

void fala_continua(string texto, int vel, int persona)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{personagens[persona]}:\n");
    Console.ResetColor();
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }
}

Console.WriteLine("A Lenda do(s) Herói(s) - A Conta do Guerreiro Anão\n");
Console.WriteLine("----------------------------------------------\n");

goto Interativo;

dialogo_continuo("Carregando", 15);
dialogo_continuo(".", 1000);
dialogo_continuo(".", 1000);
dialogo_continuo(".\n\n", 1000);

dialogo("Eis então, nossos aventureiros, os heróis de todo o reino, as luzes mais brilhantes do nosso cruzeiro", 15);
dialogo("Eis aqueles que irão salvar o mundo inteiro!! dum perigo forasteiro que tanto nos causara medo", 15);
dialogo_continuo("EIS ENTÃO!!\n\n", 200);

fala("JOÃO, SEU MERDA, DEVOLVE MEU ARCO, NÃO É BRINQUEDO", 15, 0);
fala("TU QUE SE LASQUE, OLHA, EU SOU UM ARQUEIRO VALENTE!!", 15, 1);
fala("pelo amor, eu tô cuidando de 2 goblins...", 15, 2);

dialogo_continuo(".", 1000);
dialogo_continuo(".", 1000);
dialogo_continuo(".", 1000);
dialogo("esses são os caras que vão salvar todo mundo?", 15);
dialogo("Beleza, né? Eles mataram um drgão agora a pouco, eu posso confiar", 15);

fala("Certeza que o Thorin tá em casa? O vagabundo tá sempre numa taverna", 15, 1);
fala("É bom que esteja, a gente marcou horário", 15, 2);

dialogo("Nossos heróis chegaram à forja do mago Thorin", 15);

fala("THORIN, SEU VAGABUNDO, VEM AQUI AGORA", 15, 0);
fala("JOAQUIM!!", 15, 2);

Interativo:
int lerMoedas()
{
    Console.WriteLine("Digite um valor:");
    if (int.TryParse(Console.ReadLine(), out int valor))
    {
        return valor;
    }
    else
    {
        fala("O QUE ESTÁ FAZENDO?? ISSO É TENTATIVA DE GOBLIN!! DÊ UM NÚMERO VÁLIDO!!", 15, 3);
        return lerMoedas();
    }
}

Console.WriteLine(lerMoedas());