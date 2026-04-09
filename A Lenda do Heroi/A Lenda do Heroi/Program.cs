string nome = "Douglas, o heroi sapequinha";
int ataque_base = 4;
int bonus_arma = 3;
var ataque_total = ataque_base + bonus_arma;

double vida = 150.5;
double vida_restante = vida - 50.5;

float moedas = 20f;
float bonus_vitoria = moedas * 2f;

long xp = 1000;
long media_xp = xp / 2;

bool entendi_materia = true;

Console.WriteLine("Essa é a história de " + nome + ". Seu objetivo é salvar om reino do terrível monstro da Guatareba");
Console.WriteLine(nome + " foi em uma grande aventura em busca desse terrível monstro, mesmo não sendo muito forte, estando apenas no nível 1 e tendo só " + ataque_base + " de ataque e uma média de XP de" + xp);
Console.WriteLine("Mas o que é isso?? Uma espada!! vá heroi! Pegue-a!");
Console.WriteLine("'Espada obtida, ataque aumentado em " + bonus_arma + "! Agora o ataque do heroi é " + ataque_total + "!'");
Console.WriteLine("Depois de andar mais um tequinho, nosso heroi enfim acha o grande monstro Guatareba!!");
Console.WriteLine("HORA DA BATALHA");
Console.WriteLine("vida do inimigo: " + vida);
Console.WriteLine("O heroi dá um primeiro ataque!");
Console.WriteLine("Monstro perde 50.5 de vida!");
Console.WriteLine("vida do inimigo: " + vida_restante);
Console.WriteLine("O monstro tenta atacar de volta, mas o heroi desvia, dando a chance para dar o ataque final perfeito!");
Console.WriteLine("Um ataque crítico!!");
Console.WriteLine("O monstro morre! " + nome + " VENCE!!");
Console.WriteLine(nome + " Está com " + bonus_vitoria + " de moedas!");
Console.WriteLine("SUBIU DE NÍVEL!! Nível 2!!");
Console.WriteLine("Média de XP agora é " + media_xp);
Console.WriteLine("O herói volta para a vila, e todos comemoram o seu sucesso, a vila está salva!!");
Console.WriteLine("Fim");
Console.WriteLine("Entendi a matéria?: " + entendi_materia);