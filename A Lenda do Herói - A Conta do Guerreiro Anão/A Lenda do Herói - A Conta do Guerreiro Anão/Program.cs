using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;

#region Definições

string[] personagens = {"Joaquim", "João Macarrão", "Alex", "Thorin"};
string[] cenarios = {
@"
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                          .......::-+++*=%@%                        
                                                   ..--:@@@@@@@@@@@@@@@@@+....                      
                                               .+#@@%%%##*:-=#@@@@@=.......=#.                      
                      *:@%                     .%%@%**-%%@@@@@.....:-.........                      
                     @@@...  +..               ##*.+@###:#%*@@...*+..........                       
                     @@@.@.@-.:.:              +@@%++**@%@#@@*............@@@@@.                    
               ....=.....-@ @@@..           .@@@-*@#@@%.=@..@.......:@@@@@@.....                    
               :%%.. :@@.*  @%@..         .+#*#==%#@*.+:*@.-@...#@@@@@......%@@@..                  
               .%@.=@+-.%@@@#*@*-        @%@#%@@*@-#=@#**@..@.:@@@*....-@@@@.....%@                 
                #@:.@%@@@%#**.-+.      .@@#@@=.+@%.@*@@@@@@@*.-@%@#+@@@.....+@@@-...                
                -#%.@*+=+=+*@@@@@@    .%@@..:-==%@%%**+*+..@@@=:=%@@*...@@@@.....@@@..              
                -@%.@...-..+*-+=.*-@@@@..=@@@.@@*.@@%@@@@*.#-+@@..-#%@@:....+@@@=....@.             
                :@@.@       .+@@*@@@..#@-**@@...@...@@...@@=.+-#@@.-*@#.:@@@-....@@@@...            
               ===@.@        .:*...*%=@@@@...@@@@........*=@@..#-@@@.:@@@....@@@@....@@@-           
             .*@@@@.@@     .@@@@@@%..@=..-@@@#%*@........%-=-@@#-.-@@*--*=@@@....-@@@....-          
                   -+.      .==*%@@@@@:%@@#%@@@@@...@@@@@*@%*.*@@.#.=@@#+=*...@@@.....@@@@@--       
                            .#++**:..+@@@@@#....@@@@#@#+*#@@%.@#=@@-:-.@@%+@@:....@@@@@+=+**@@@:.   
                            .+#**+%@@@@....+@@@@+@#*%##-@#**+:@%+--@@**-:@@#=-.@@@@%*+*=*+**#@@@-   
                        ..:*%@%@@@*....@@@@@%%@@%%*%#*%@@@@@%..#@%*=-@%.=-.@@*=+@:-++*+%#*@@@....   
                    ...:*@@@@@-...:@@@@*@%%@@:%#*+##%@@@%...%@@%**%%@#@@*.+-.@@:.*@++##@@@...-...   
                :..+#@@@@@....@@@@@+@@@@#@#%##++#@@@@...:.:+.@@##*#.#@@@@@@@@*:@@--#@@@.....=...    
            ..#@@%@#@.....@@@@%+=++*%%++*#+=#@@@@...:-@*...#*.%..:#.#=::..-+%@@@@@#%.........       
          .-#@#*-=**@@@@@%#**#%@#++*@@@:#%@@@....:%+.=#%*-...      .%@%%#*+=-:-+-+%.......          
            +%%##***==-*#@%%*==#@@@@%@@@@@...@==....+.....          ...::-+#@#*%-#*....             
           .@#%@@@@@%%@@#*+=+++@@@@=.@......+-..=+....                     ...:-....                
           =@@@@*@#+%#%@**=#@@@+....%*...:.@+..:..                                                  
          .%@@%@%@@@@%##%####@..#++%+..:@@#+...                                                     
             ...@@@%%%%@@@@@#@#..+@*:.:-+..                                                         
                  .-*@@@@#%@@@%.@*......                                                            
                       ..-+@@@@%=...                                                                
                             ...                                                                    
"
};
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

void fala(string texto, int delay, int persona, int formatacao = 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{personagens[persona]}:\n");
    Console.ResetColor();

    Console.Write("- ");

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

    Console.Write("\n\n");

    while (Console.KeyAvailable)
    {
        Console.ReadKey(true);
    }

    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {

    }
}

void fala_continua(string texto, int delay, int persona, int formatacao = 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{personagens[persona]}:\n");
    Console.ResetColor();

    Console.Write("- ");

    for (int i = 0; i < texto.Length; i++)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

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

void acao(string texto, int delay)
{
    for (int i = 0; i < texto.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.Enter)
            {
                Console.Write($"\u001b[3m{texto.Substring(i)}\u001b[0m");
            }
        }

        Console.Write($"\u001b[3m{texto[i]}\u001b[0m");
        Thread.Sleep(delay);
    }

    while (Console.KeyAvailable)
    {
        Console.ReadKey(true);
    }
}

void cenario(int cen)
{
    Console.WriteLine(cenarios[cen]);
    Thread.Sleep(1000);
}
#endregion

Console.WriteLine("A Lenda do(s) Herói(s) - A Conta do Guerreiro Anão\n");
Console.WriteLine("----------------------------------------------\n");

//goto Interativo;

dialogo_continuo("Carregando", 15);
dialogo_continuo(".", 1000);
dialogo_continuo(".", 1000);
dialogo_continuo(".\n\n", 1000);

dialogo("Eis então, nossos aventureiros, os heróis de todo o reino, as luzes mais brilhantes do nosso cruzeiro", 15, 1);
dialogo("Eis aqueles que irão salvar o mundo inteiro!! dum perigo forasteiro que tanto nos causara medo", 15, 1);
dialogo_continuo("EIS ENTÃO!!\n\n", 200, 1);

fala("JOÃO, SEU MERDINHA, DEVOLVE MEU ARCO, NÃO É BRINQUEDO", 15, 0);
fala("TU QUE SE LASQUE, OLHA, EU SOU O ARQUEIRO VERDE!!", 15, 1);
fala("Pelo amor, eu tô cuidando de 2 goblins...", 15, 2);

dialogo_continuo(".", 1000, 1);
dialogo_continuo(".", 1000, 1);
dialogo_continuo(".", 1000, 1);
dialogo("esses são os caras que vão salvar todo mundo?", 15, 1);
dialogo("Beleza, né? Eles mataram um Golem agora a pouco, eu acho que posso confiar...\n", 15, 1);

fala("Certeza que o Thorin tá em casa? O vagabundo tá sempre numa taverna", 15, 1);
fala("É bom que esteja, a gente marcou horário", 15, 2);
fala("Pra que marcar horário pra falar com o tio?", 15, 0);
fala("Ele não é nosso tio, só era amigo do nosso pai. Na verdade, ele odeia a gente", 15, 2);
fala("Mas ele deixava eu jogar no joguinho da fogueira dele...", 15, 0);
fala("Aquilo não era jogo, ele só deixava você brincar com o fogo na esperança de você se queimar e parar de encher o saco. O jogo que tu via é porque você esquecia de tomar seus remédios mesmo", 15, 1);
fala("E você só tá vivo porque eu te salvava sempre...", 15, 2);

cenario(0);

dialogo("Nossos heróis chegaram à forja do mestre anão Thorin\n", 15, 1);

fala("THORIN, SEU VAGABUNDO, VEM AQUI AGORA", 15, 0);
fala("CALA A BOCA, JOAQUIM!!", 15, 2);
fala("ele se perde, viu", 15, 1);
fala("Cala a boca tu também", 15, 2);
fala("bobona...", 15, 1);

dialogo_continuo("O grande portão se abre, dando um deslubre da grande e majestosa criatura que era ", 15, 1);
dialogo_continuo("THORIN!!", 15, 2);
dialogo_continuo("\n.", 1000, 1);
dialogo_continuo(".", 1000, 1);
dialogo_continuo(".", 1000, 1);
dialogo("um velhinho bem baixinho, na verdade\n", 15, 1);

fala("QUE FOI???", 15, 3);
fala_continua("TIO THORI!! ", 15, 0);
acao("João corre para abraçar o mestre anão, que logo o empurra pra longe", 15);
dialogo("", 0);

fala("Tá, tá, que que vocês querem?", 15, 3);

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

int SomarEquipamentos(int n1, int n2)
{
    return n1 + n2;
}

Console.WriteLine(SomarEquipamentos(lerMoedas(), lerMoedas()));
