string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
Dictionary<string, List<double>> bandasRegistradas = new Dictionary<string, List<double>>();

void ExibirLogo()
{
    Console.WriteLine(@"Ｓｃｒｅｅｎ Ｓｏｕｎｄ");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("-----------------------------------\n");
}

void ExibirOpcoesDeMenu()
{
    ExibirLogo();
    Console.WriteLine("Escolha uma opção: \n");
    Console.WriteLine("[1] Registrar uma banda.");
    Console.WriteLine("[2] Mostrar todas as bandas.");
    Console.WriteLine("[3] Avaliar uma banda.");
    Console.WriteLine("[4] Exibir a média de uma banda.");
    Console.WriteLine("[0] SAIR.");
    EscolherOpçao();
}

void EscolherOpçao()
{
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaDeAvalicaoDaBanda();
            break;
        case 0:
            Console.WriteLine("Saindo do Sreen Sound...");
            Thread.Sleep(2000);
            break;
        default:
            Console.WriteLine("Opção Inválida. Tente novamente.");
            Thread.Sleep(2000);
            VoltarAoMenu();
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao(@"Ｒｅｇｉｓｔｒｏ ｄｅ Ｂａｎｄａ");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<double>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    VoltarAoMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao(@"Ｂａｎｄａｓ Ｒｅｇｉｓｔｒａｄａｓ");
    int i = 1;
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"{i} - {banda}");
        i++;
    }
    Console.WriteLine("\nPressione qualquer tecla para sair.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDeMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string tracejado = string.Empty.PadLeft(quantidadeLetras * 2, '-');
    Console.WriteLine(tracejado);
    Console.WriteLine(titulo);
    Console.WriteLine(tracejado + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao(@"Ａｖａｌｉａｒ Ｂａｎｄａ");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A banda {nomeDaBanda} foi avaliada com sucesso com nota {nota}.");
        Thread.Sleep(4000);
        VoltarAoMenu();
    }
    else
    {
        ExibirMensagemBandaNaoEncontrada(nomeDaBanda);
    }
}

void ExibirMediaDeAvalicaoDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao(@"Ｍｅｄｉａ ｄｅ Ａｖａｌｉａｃａｏ ｄａ Ｂａｎｄａ");
    Console.Write("Digite o nome da banda para exibir a média de avaliação: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<double> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A banda {nomeDaBanda} tem uma média de avaliações de {notasDaBanda.Average()}.");
    }
    else
    {
        ExibirMensagemBandaNaoEncontrada(nomeDaBanda);
    }
}

void VoltarAoMenu()
{
    Console.Clear();
    ExibirOpcoesDeMenu();
}

void ExibirMensagemBandaNaoEncontrada(string nomeDaBanda) {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nPressione qualquer tecla para sair.");
        Console.ReadKey();
        VoltarAoMenu();
}



ExibirOpcoesDeMenu();