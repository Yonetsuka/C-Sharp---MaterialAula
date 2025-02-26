using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
bool primeiraVez = true;
bool replay = true;
Random rnd = new Random();

void ppt(String escolha1,String escolha2)
{
    switch (escolha1)
    {
        case "Pedra":
            switch (escolha2)
            {
                case "Pedra":
                    Console.WriteLine("✊(pedra) X ✊(pedra)");
                    Console.WriteLine("Deu empate");
                    break;
                case "Papel":
                    Console.WriteLine("✊(pedra) X ✋(papel)");
                    Console.WriteLine("Ganhei!!!");
                    break;
                case "Tesoura":
                    Console.WriteLine("✊(pedra) X ✌(tesoura)");
                    Console.WriteLine("Você ganhou!");
                    break;
            }
            break;
        case "Papel":
            switch (escolha2)
            {
                case "Pedra":
                    Console.WriteLine("✋(papel) X ✊(pedra)");
                    Console.WriteLine("Você ganhou!");
                    break;
                case "Papel":
                    Console.WriteLine("✋(papel) X ✋(papel)");
                    Console.WriteLine("Deu empate");
                    break;
                case "Tesoura":
                    Console.WriteLine("✋(papel) X ✌(tesoura)");
                    Console.WriteLine("Ganhei!!!");
                    break;
            }
            break;
        case "Tesoura":
            switch (escolha2)
            {
                case "Pedra":
                    Console.WriteLine("✌(tesoura) X ✊(pedra)");
                    Console.WriteLine("Ganhei!!!");
                    break;
                case "Papel":
                    Console.WriteLine("✌(tesoura) X ✋(papel)");
                    Console.WriteLine("Você ganhou!");
                    break;
                case "Tesoura":
                    Console.WriteLine("✌(tesoura) X ✌(tesoura)");
                    Console.WriteLine("Deu empate");
                    break;
            }
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("1 - Sim ou 0 - Não");
if(Console.ReadKey().KeyChar == '1' && primeiraVez == true)
{
    while(replay == true)
    {
        Console.WriteLine("Então vamos começar...");
        Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
        var opcao = Console.ReadKey().KeyChar;
        int escolha = rnd.Next(0, 2);
        List<string> opcoes = ["Pedra", "Papel", "Tesoura"];
        String opcaoFinalUser = opcoes[Convert.ToInt32(opcao.ToString())];
        String opcaoFinalCPU = opcoes[escolha];
        ppt(opcaoFinalUser, opcaoFinalCPU);
        Console.WriteLine("Gostaria de jogar de novo (Sim ou não)?");
        replay = (Console.ReadLine().ToUpper() == "SIM");
    }

    //Console.WriteLine("Desculpa! Acabei de lembrar que ainda não sei jogar. 😕");
}
Console.WriteLine("👋 Tchau! Até a próxima");
