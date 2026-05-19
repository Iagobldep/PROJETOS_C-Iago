using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;

#region Definições

string[] personagens = { "Joaquim", "João Macarrão", "Alex", "Thorin" };
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

// Diálogos padrões: 0/vazio - Normal, 1 - Itálico, 2 - Negrito
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

/*
Diálogos de personagens: 0/vazio - Normal, 1 - Itálico, 2 - Negrito
0 - Joaquim
1 - João Macarrão
2 - Alex
3 - Thorin
*/
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

// Descrições de ações
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

// Exibição de cenários
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
fala("TU QUE SE LASQUE, OLHA, EU SOU O ROBIN HOOD!!", 15, 1);
fala("Pelo amor, eu tô cuidando de 2 goblins...", 15, 2);

dialogo_continuo("...", 1000, 1);
dialogo("esses são os caras que vão salvar todo mundo?", 15, 1);
dialogo("Beleza, né? Eles mataram um Golem agora a pouco, eu acho que posso confiar...\n", 15, 1);

Console.WriteLine(@"
--------------------------------------------------------------------------------------------------------------------------
 _______    ___      _______  __    _  ______   _______    ______   _______    __   __  _______  ______    _______  ___  
|   _   |  |   |    |       ||  |  | ||      | |   _   |  |      | |       |  |  | |  ||       ||    _ |  |       ||   | 
|  |_|  |  |   |    |    ___||   |_| ||  _    ||  |_|  |  |  _    ||   _   |  |  |_|  ||    ___||   | ||  |   _   ||   | 
|       |  |   |    |   |___ |       || | |   ||       |  | | |   ||  | |  |  |       ||   |___ |   |_||_ |  | |  ||   | 
|       |  |   |___ |    ___||  _    || |_|   ||       |  | |_|   ||  |_|  |  |       ||    ___||    __  ||  |_|  ||   | 
|   _   |  |       ||   |___ | | |   ||       ||   _   |  |       ||       |  |   _   ||   |___ |   |  | ||       ||   | 
|__| |__|  |_______||_______||_|  |__||______| |__| |__|  |______| |_______|  |__| |__||_______||___|  |_||_______||___|                                                                                                    
                                                                                                   
- esse nome ainda é provisório.                                                                                                                                                  
--------------------------------------------------------------------------------------------------------------------------
");

Thread.Sleep(1000);

fala("Certeza que o Thorin tá em casa? O vagabundo tá sempre numa taverna", 15, 0);
fala("É bom que esteja, a gente marcou horário", 15, 2);
fala("Pra que marcar horário pra falar com o tio?", 15, 1);
fala("Ele não é nosso tio, só era amigo do nosso pai. Na verdade, ele odeia a gente", 15, 2);
fala("Mas ele deixava eu jogar no joguinho da fogueira dele...", 15, 1);
fala("Aquilo não era jogo, ele só deixava você brincar com o fogo na esperança de você se queimar e parar de encher o saco. O jogo que tu via é porque você esquecia de tomar seus remédios mesmo", 15, 0);
fala("E você só tá vivo porque eu te salvava sempre...", 15, 2);

Forja:
cenario(0);

dialogo("Nossos heróis chegaram à forja do mestre anão Thorin\n", 15, 1);

fala("THORIN, SEU VAGABUNDO, VEM AQUI AGORA", 15, 0);
fala("CALA A BOCA, JOAQUIM!!", 15, 2);
fala("ele se perde, viu", 15, 1);
fala("Cala a boca tu também", 15, 2);
fala("bobona...", 15, 1);

dialogo_continuo("O grande portão se abre, dando um deslumbre da grande e majestosa criatura que era ", 15, 1);
dialogo_continuo("THORIN!!", 15, 2);
dialogo_continuo("\n.", 1000, 1);
dialogo_continuo(".", 1000, 1);
dialogo_continuo(".", 1000, 1);
dialogo("um velhinho bem baixinho, na verdade\n", 15, 1);

fala("QUE FOI???", 15, 3);
fala("TIO THORI!! ", 15, 1);

dialogo("João corre para abraçar o mestre anão, que logo o empurra pra longe\n", 15, 1);

fala("Tá, tá, o que que vocês querem?", 15, 3);
fala("A gente precisa de ajuda pra consertar nossas armaduras, sem enrolação", 15, 2);
fala("Marcaram horário?", 15, 3);
fala_continua("Ah-", 15, 2);
dialogo_continuo(" ", 500, 2);
dialogo("A gente marcou há 20 minutos! Como você já não lembra??\n", 15);
fala("Quem é que marca horário 20 minutos antes do compromisso??", 15, 3);
fala("QUE TIPO DE FORJA PRECISA MARCAR HORÁRIO???", 15, 2);
fala("Ô GENTE, PELO AMOR DE ODIN, CALEM A BOCA!!", 15, 0);

dialogo("Os dois ficam de cara fechada", 15, 1);
dialogo("Thorin e os 3 heróis entram na forja\n", 15, 1);

fala("Beleza, cadê as armas e armaduras?", 15, 3);

dialogo("As armas e armaduras são jogadas na mesa\n", 15, 1);

fala("TAPEGA, TAVAM LUTANDO CONTRA UM GOLEM DE PEDRA OU ALGO ASSIM????", 15, 3);
fala_continua("...", 500, 2);
dialogo("sim?\n", 15);

fala("Deu pra notar, né? Tudo lascado", 15, 3);
fala("Vai consertar ou não??", 15, 0);
fala("Ah, claro, claro, mas isso vai custar um pouco", 15, 3);
fala("Fala logo o preço", 15, 2);
fala_continua("Beleza, deve estar saindo por uns", 15, 3);
dialogo_continuo("... ", 500);
dialogo("quanto valem suas armaduras?\n", 15);
fala("Ué, você que devia saber", 15, 2);
fala("Aaaaah, não tô com saco pra calcular agora, tem que ver material, data de fabricação, qualidade atual, digam o valor vocês", 15, 3);

dialogo("Joaquim puxa Alex para um canto enquanto João fica enxendo o saco do anão\n", 15, 1);

fala("Ô Alex, quanto que a gente tem em moedas?", 15, 0);

dialogo("Alex olha o saquinho de moedas e conta rapidamente\n", 15, 1);

fala("Depois da luta, ganhamos umas 100 moedas", 15, 2);
fala("Ele é folgado demais pra definir um preço sozinho", 15, 0);
dialogo("- Então podemos tirar um tiquinho de vantagem, hehehe\n", 15);
dialogo("- Quero gastar menos de 40 moedas!\n", 15);
fala("Querendo passar a perna em velho??", 15, 2);
dialogo("- Gostei\n", 15);

dialogo("Os dois voltam para frente de Thorin\n", 15, 1);

fala("Beleza, acho que decidimos os valores", 15, 2);
fala("Ótimo, falem logo", 15, 3);
fala_continua("Tá, elas valem:\n\n", 15, 2);

Interativo:
int resultado = 0;
List<int> moedas = new List<int>();
int lerMoedas()
{
    Console.WriteLine($"Digite quantas moedas valem o {moedas.Count + 1}º equipamento:");
    if (int.TryParse(Console.ReadLine(), out int valor))
    {
        moedas.Add(valor);

        Console.WriteLine("\n");
        fala_continua("Tá bom, mais algum equipamento? (S/N)\n", 15, 3);
        string resposta = Console.ReadLine();
        Console.WriteLine("\n");

        while (resposta.ToLower() != "s" && resposta.ToLower() != "n")
        {
            Console.WriteLine("\n");
            fala("S OU N!!", 15, 3);
            resposta = Console.ReadLine();
            Console.WriteLine("\n");
        }

        switch(resposta.ToLower())
        {
            case "s":
                return lerMoedas();
            case "n":
                return valor;
        }

        return valor;
    }
    else
    {
        Console.WriteLine("\n");
        fala("ISSO É TENTATIVA DE GOBLIN!! DÊ UM NÚMERO VÁLIDO!!", 15, 3);
        return lerMoedas();
    }
}

int SomarEquipamentos(List<int> Lista)
{
    return Lista.Sum();
}

lerMoedas();

resultado = SomarEquipamentos(moedas);

fala($"Então, o total dá {resultado} moedas", 15, 2);

if (resultado <= 20)
{
    fala_continua("Tá achando que eu sou ótario?", 15, 3);
    dialogo_continuo("...", 500, 3);
    dialogo("Por acaso eu tenho pinta de otário?", 15, 3);
    dialogo("- Ou você me dá os valores certos ou mete o pé!!\n", 15, 3);

    fala("Mandou bem, gênio...", 15, 2);
    if (moedas.Count == 1)
    {
        fala($"Tu foi meter que {moedas.Count} equipamento tem preço de bala! aí fica difícil também, né?", 15, 0);
    }
    else
    {
        fala($"Tu foi meter que {moedas.Count} equipamentos tem preço de bala! aí fica difícil também, né?", 15, 0);
    }

    fala("Dá o preço certo, pra ele\n", 15, 0);
    goto Interativo;
}
else if  (resultado < 40)
{
    fala_continua("Perfeito, devo terminar até o fim", 15, 3);
    dialogo_continuo("...", 500, 3);
    dialogo("dos próximos 3 segundos\n", 15);

    fala("pera, que?", 15, 2);

    dialogo_continuo("TIM TIM TIM ", 15, 2);
    dialogo("e todos os equipamentos estavam consertados como se fosse mágica\n", 15, 1);

    fala("que rápido, tio!!", 15, 1);
    fala("Pronto, agora VAZEM DAQUI!!", 15, 3);
}
else if (resultado <= 80)
{
    fala("Perfeito! Termino rapidinho", 15, 3);
    fala("Eu disse pra você gastar menos de 40 moedas...", 15, 0);
    fala("Cala a boca, o dinheiro é meu e eu gasto o quanto eu quiser", 15, 2);
    fala("O dinheiro é do grupo!! Não é porque você é mais velha que pode ficar com tudo!", 15, 0);
    fala("Licença, mas quem foi que matou aquele Golem?", 15, 2);
    fala_continua("...", 500, 0);
    dialogo("Você, mas a gente ajudou!\n", 15);
    fala("Ajudou muito com seu arco e flecha num monstro de PEDRA!", 15, 2);
    fala("CÊS QUEREM CALAR A BOCA, EU TÔ TENTANDO ME CONCENTRAR AQUI!!", 15, 3);
    
    dialogo("Thorin então termina de consertar os equipamentos em menos de 3 segundos\n", 15, 1);

    fala("que rápido, tio!!", 15, 1);
    fala("Pronto, agora VAZEM DAQUI!!", 15, 3);
}
else if (resultado < 100)
{
    fala("ETA! TÁ VALENDO MESMO, HEIN", 15, 3);
    fala("Eu disse pra gastar menos de 40 moedas! Tá louca?? A gente vai ficar pobre assim!", 15, 0);
    fala("NÃO SEI O QUE ME DEU!!", 15, 2);
    fala("TARDE DEMAIS, TÁ PAGO E JÁ CONSERTEI SEUS EQUIPAMENTOS, AGORA VAZEM DAQUI!!", 15, 3);
    fala("que rápido, tio!!", 15, 1);
}
else
{
    fala("O QUE CÊ TÁ FAZENDO?? A GENTE NEM TEM TODO ESSE DINHEIRO!!", 15, 0);
    fala_continua("...", 500, 2);
    dialogo("e é, né?\n", 15);
    goto Interativo;
}

dialogo("Thorin então chuta os 3 heróis para fora da forja\n", 15, 1);

fala("Continua um mala...", 15, 2);
fala("Eu gostei de rever o tio!", 15, 1);
fala("Só você", 15, 0);
fala("VAMOS!! TEMOS MUITAS AVENTURAS PELA FRENTE!!", 15, 1);

dialogo("E então, os nossos heróis partem em busca da próxima aventura\n", 15, 1);
dialogo("CONTINUA...", 100, 2);