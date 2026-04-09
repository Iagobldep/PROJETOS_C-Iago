using System;
using System.Threading;
Console.OutputEncoding = System.Text.Encoding.UTF8;
void fantasma()
{
    Console.WriteLine(@"      
          ############     
        ##            ##        
      ##                ##      
      ##  ####    ####  ##      
      ##  ####    ####  ##      
      ##  ####    ####  ##      
      ##                ##      
      ##                ##      
      ##                ##      
      ##                ##      
      ##  ##  ####  ##  ##      
        ##  ##    ##  ##        
                                
");
}
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
void dialogo_negrito(string texto, int vel)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(texto[i]);
        Thread.Sleep(vel);
    }
    Console.ResetColor();
}

comecar:
Console.WriteLine("A LENDA DO HERÓI 3: UMA NOVA AJUDA");
Console.WriteLine("-----------------------------------");
Console.WriteLine("Criado por: Iagobldep");
Thread.Sleep(1000);
Console.WriteLine("\n\nPressione Enter para iniciar a aventura\n");
Console.ReadLine();

historia:
Console.WriteLine("""
 -------------------------------------------------------------------------------------
             _                _             _        _                __  _   ____  
     /\     | |              | |           | |      | |              /_/ (_) |___ \ 
    /  \    | | ___ _ __   __| | __ _    __| | ___  | |__   ___ _ __ ___  _    __) |
   / /\ \   | |/ _ \ '_ \ / _` |/ _` |  / _` |/ _ \ | '_ \ / _ \ '__/ _ \| |  |__ < 
  / ____ \  | |  __/ | | | (_| | (_| | | (_| |  __/ | | | |  __/ | | (_) | |  ___) |
 /_/    \_\ |_|\___|_| |_|\__,_|\__,_|  \__,_|\___| |_| |_|\___|_|  \___/|_| |____/ 

                                                                                    
 ------------------------------------------------------------------------------------
 """);

Thread.Sleep(1000);

dialogo("\nVocê é um nobre guerreiro, neto de Douglas: O Herói Sapequinha.", 15);
dialogo("Após a morte de seu pai, filho de Douglas, você decide seguir os passos da família\n", 15);

dialogo_negrito("Dia 19 de Junho de 1306, 09:30\n", 100);
dialogo("Você acaba de chegar a vila onde seu pai fez sua primeira aventura", 15);
dialogo("Ao chegar, nota um pequeno fantasma se aproximando\n", 15);

fantasma();
dialogo("👻 - Bom dia moço", 15);
dialogo("👻 - Tava te olhando e te achei MUITO MANEIRO!!", 15);
dialogo("👻 - Posso me juntar a você??\n", 15);

dialogo("AAAAAAAA, UM FANTASMA!! Você estava se cagando demais pra recusar, então aceitou", 15);
dialogo_negrito("FANTASMINHA ENTROU PRA EQUIPE\n\n", 100);

dialogo_negrito("Dia 19 de Junho de 1306, 12:30\n", 100);
dialogo("Você e Fantasminha seguem caminho, chegando até o lar de um sábio mago\n", 15);
dialogo("Mago: - QUEM SÃO VOCÊS??? O QUE FAZEM EM MINHA MORADIA???", 15);

fantasma();
dialogo("👻 - Boa tarde, senhor, estamos procurando um tal de Mythrandir\n", 15);

dialogo("Mago: - SOU EU!! Mas eu estava esperando Douglas: O Herói Sapequinha", 15);
dialogo("Mago: - Ele me prometeu que viria aqui, mas ele nunca apareceu\n", 15);

dialogo("Você explica pra ele que Douglas morreu há 2 trabalhos atrás, e que você é o neto dele\n", 15);

dialogo("Mago: - Oh... Bom, então vocês terão que me ajudar no lugar dele\n", 15);

dialogo("De repente, o Mago ancião conjura uma grande magia em formato de triângulo\n", 15);

dialogo("Mago: - Eu preciso calcular a área desse triângulo, podem fazer isso por mim? Não consigo me mover enquanto estou conjurando\n", 15);

fantasma();
dialogo("👻 - Tudo bem, senhor, vamos ajudar", 15);
dialogo("👻 - Primeiro, precisamos medir os lados", 15);

minigame1:
Console.WriteLine("Todos os lados são iguais, quais vão ser a medida deles?: ");

var certo = float.TryParse(Console.ReadLine().Replace(".", ","), out float lado);

while (!certo)
{
    Console.WriteLine("Um número, por favor: ");
    certo = float.TryParse(Console.ReadLine().Replace(".", ","), out lado);
}

fantasma();
dialogo("👻 - Ok! Vamos medir a área desse triângulo equilátero com minha incrível calculadora de área de triângulos equiláteros que eu roubei do meu amigo Igor antes de virmos\n", 15);
dialogo("👻 - A área do triângulo equilátero é a medida de sua superfície e equivale a um quarto do produto entre a medida do lado do\ntriângulo ao quadrado e a raiz de três\n", 15);
dialogo("\nVocê não entende nada, mas tu tem medo demais dele pra perguntar\n", 15);

fantasma();
dialogo("👻 - Então, a fórmula é: A = (L² * √3) / 4\n", 15);
dialogo_continuo("\nCalculando", 15);
dialogo_continuo("...", 1000);

float area = (float)(Math.Pow(lado, 2f) * Math.Pow(3, 1/2f)) / 4;
area = (float)(Math.Round(area, 2));

fantasma();
dialogo($"👻 - Pronto!! a área é {area}\n", 15);

dialogo("Mago: - MUITO OBRIGADO, MEUS AMIGOS!!", 15);
dialogo("Mago: - Agora posso finalmente dominar o mundo\n", 200);
dialogo_continuo("O Mago de repente se transforma no poderoso ", 15);
dialogo_negrito("LUX@S", 15);
dialogo(", o rei da maldade e da luxúria", 15);
dialogo("LUX@S: - MUITO OBRIGADO, SEUS PATETAS, MUAHAHAHAHAHA\n", 15);
dialogo("LUX@S sai voando, quebrando o teto da caverna do mago\n", 15);

fantasma();
dialogo("👻 - OH NÃO NÃO NÃO!! A CULPA É TODA NOSSA\n", 15);
dialogo("Você acreditava que a culpa era totalmente do fantasminha, tu só falou a medida e ele fez o resto, mas tu tem medo demais pra falar isso na cara dele\n", 15);

fantasma();
dialogo("👻 - VAMOS ATRÁS DELE!!\n", 15);
dialogo("Vocês saem correndo atrás de LUX@S, que voa cada vez mais rápido", 15);

dialogo("Vocês chegam até o castelo, LUX@S já estava lá, tentando arrombar o portão\n", 15);

dialogo("LUX@S: - HAHAHAHA, ESSE PORTÃOZINHO É TUDO QUE TÊM????", 15);
dialogo("LUX@S: - EU VOU ARROMBAR ELE COM A MINHA INCRÍVEL TECNOLOGIA, A PORRA!!", 15);
dialogo_negrito("Poder Overpower Realmente Ruim AAAAAAAA\n", 15);
dialogo("", 0);

fantasma();
dialogo("👻 - OH NÃO, COMO VAMOS DERROTÁ-LO??!!!\n", 15);
dialogo("Você sabia que ia precisar usar a força bruta...", 15);

minigame2:
Console.WriteLine("\nQual é o seu nível de força?? (escolha um número até 9)");

certo = int.TryParse(Console.ReadLine(), out int forca);

while (!certo || forca > 9)
{
    Console.WriteLine("Um número inteiro e válido, por favor: ");
    certo = int.TryParse(Console.ReadLine(), out forca);
}

double forca_total = Math.Pow(forca, 3);

Console.WriteLine($"\nSua força total é {forca_total}\n");
Thread.Sleep(1000);

if (forca_total < 400)
{
    dialogo("LUX@S: - HAHAHAHAH QUE FORÇA RIDÍCULA!!\n", 15);
    dialogo("LUX@S mata você, e como o Fantasminha já era um fantasma, ele o sequestra e o torna seu escravo", 15);
    dialogo_continuo("FIM DE JOGO\n", 100);
    dialogo_continuo("Aperte ", 15);
    dialogo_negrito("Enter ", 15);
    dialogo_continuo("para tentar novamente\n", 15);
    Console.ReadLine();
    goto minigame2;
}
else if (forca_total >= 700)
{
    dialogo("Sua força é tão alta que não só mata o monstro em uma só porrada, como também destrói o castelo inteiro", 15);
    dialogo("O povo revoltado te queima vivo\n", 15);

    dialogo_continuo("FIM DE JOGO\n", 100);
    dialogo_continuo("Aperte ", 15);
    dialogo_negrito("Enter ", 15);
    dialogo_continuo("para jogar novamente", 15);
    Console.ReadLine();
    goto minigame2;
}
else
{
    dialogo("LUX@S: - NÃAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOOOOOO!!\n", 15);
    dialogo("LUX@S explode em mil pedaços", 15);
}

fantasma();
dialogo("👻 - DERROTAMOS ELE!!\n", 15);
dialogo("Na verdade, você o derrotou sozinho, mas não tem coragem de falar isso na cara dele", 15);
dialogo("O povo da cidade grita alegremente, dando várias recompensas para vocês 2... Você pega tudo pra si mesmo\n", 15);

fantasma();
dialogo("👻 - Vamos comemorar!!\n", 15);

dialogo("Vocês vão para a taverna mais próxima, e lá tinha uma bartender muito bonita", 15);
dialogo("Você decide dar em cima dela", 15);

cantadas:
dialogo_continuo("Que cantada você vai mandar? (1-7)", 0);
string[] cantada = ["1-Programação", "2-Universo", "3-Escola", "4-Física", "5-Jogos", "6-Inteligência", "7-Romântica clássica"];

for (int i = 0; i < cantada.Length; i++)
{
    Console.WriteLine($"- {cantada[i]}\n");
}

certo = int.TryParse(Console.ReadLine(), out int escolha);

while (!certo || escolha < 1 || escolha > 7)
{
    Console.WriteLine("Um número inteiro e válido, por favor: ");
    certo = int.TryParse(Console.ReadLine(), out escolha);
}

bool deu_certo = false;
switch(escolha)
{
    case 1:
        dialogo("Você manda: Você não é um while, mas eu ficaria preso em você pra sempre.\n", 15);
        dialogo("Ela odiou, te deu um return null e saiu do seu código pra sempre.", 15);
        break;
    case 2:
        dialogo("Você manda: Se o universo tá em expansão, é porque ainda não mediram o tamanho do que eu sinto por você.\n", 15);
        dialogo("Ela odiou, disse que o universo é grande demais pra te aguentar e foi pra outra galáxia.", 15);
        break;
    case 3:
        dialogo("Você manda: Você não é prova, mas me deixa completamente sem resposta.\n", 15);
        dialogo("Ela odiou, te reprovou direto sem nem olhar sua resposta.", 15);
        break;
    case 4:
        dialogo("Você manda: Você é tipo gravidade… porque me atrai sem nem tentar.\n", 15);
        dialogo("Ela odiou, anulou sua força e te jogou pra longe com uma reação contrária.", 15);
        break;
    case 5:
        dialogo("Você manda: Você não é checkpoint, mas é o único lugar onde eu quero salvar minha vida.\n", 15);
        dialogo("Ela odiou, quitou da conversa e deletou teu save.", 15);
        break;
    case 6:
        dialogo("Você manda: Você não é Wi-Fi, mas quando chega perto minha conexão com o mundo melhora.\n", 15);
        dialogo("Ela odiou, desligou o Wi-Fi e bloqueou sua conexão com a vida dela.", 15);
        break;
    case 7:
        dialogo("Você manda: Não sei explicar, mas qualquer lugar vira casa quando você tá.\n", 15);
        dialogo("Ela odiou, disse que não é casa de ninguém e bateu a porta na tua cara.", 15);
        break;
    default:
        dialogo("Você manda...nada...ela amou, agora quer se casar com você.\n", 15);
        deu_certo = true;
        break;
}

if (deu_certo == true)
{
    dialogo("Enfim, vocês saem num carro de recém casados...existia carro nessa época?", 15);
    dialogo("FIM", 100);
}
else
{
    dialogo("Enfim, você sai de lá humilhado, mas ainda é um herói rico", 15);
    dialogo("FIM", 100);
    dialogo("\nQuer tentar outra cantada?", 15);
    goto cantadas;
}

//LEMBRA DE TIRAR O GOTO