using System;
using System.Runtime.CompilerServices;

Console.OutputEncoding = System.Text.Encoding.UTF8;

bool primeiraVez = true;
String nome;

Dictionary<String, (int vitorias, int empates, int derrotas)> registro = new Dictionary<String, (int,int,int)>();

Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("1 - Sim ou 0 - Não");

var continuar = Console.ReadKey().KeyChar;

while (continuar == '1')
{
    if(primeiraVez = true)
    {
        Console.WriteLine("Então vamos começar...");
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        if (!registro.ContainsKey(nome))
        {
            registro[nome] = (0, 0, 0);
        }
        primeiraVez = false;
    }
    else
    {
        Console.WriteLine("Deseja mudar de jogador ? 1 - Sim,0 - Não");
        var escolha = Console.ReadKey().KeyChar;
        switch (escolha)
        {
            case '1':
                Console.WriteLine("Digite o novo nome de jogador");
                break;
            case '0':
                break;
        }
    }
    (int vitorias, int empates, int derrotas) placar = registro[nome];
    Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
    var opcao = Console.ReadKey().KeyChar;

    var opcaoPC = new Random().Next(3);

    bool vitoria = false;

    switch (opcao)
    {
        case '0':
            Console.WriteLine("\nVocê escoheu Pedra ✊!");
            vitoria = (opcaoPC == 2);
            break;
        case '1':
            Console.WriteLine("\nVocê escoheu Papel ✋");
            vitoria = (opcaoPC == 0);
            break;
        case '2':
            Console.WriteLine("\nVocê escoheu Tesoura ✌");
            vitoria = (opcaoPC == 1);
            break;
    }

    switch (opcaoPC)
    {
        case 0:
            Console.WriteLine("\nEu escolhi Pedra ✊!");
            break;
        case 1:
            Console.WriteLine("\nEu escolhi Papel ✋");
            break;
        case 2:
            Console.WriteLine("\nEu escolhi Tesoura ✌");
            break;
    }

    if(opcao == 3)
    {

    }
    if (int.Parse(opcao.ToString()) == opcaoPC)
    {
        Console.WriteLine("\n😀 Legal! Nós empatamos!");
        placar.empates++;
    }
    else if (vitoria)
    {
        Console.WriteLine("\n😀 Parabéns! Você venceu.");
        placar.vitorias++;
    }
    else
    {
        Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez. Você pode ter mais sorte na próxima.");
        placar.derrotas++;
    }
    registro[nome] = placar;
    Console.WriteLine("\n=== Placar Final de Todos os Jogadores ===");
    foreach (var jogador in registro)
    {
        Console.WriteLine($"{jogador.Key}: Vitórias={jogador.Value.vitorias}, Derrotas={jogador.Value.derrotas}, Empates={jogador.Value.empates}");
    }
    Console.WriteLine("\nQuer jogar de novo?");
    Console.WriteLine("1 - Sim ou 0 - Não");
    continuar = Console.ReadKey().KeyChar;
}
Console.WriteLine("👋 Tchau! Até a próxima");
