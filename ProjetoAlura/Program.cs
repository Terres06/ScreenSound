string mensagemDeBoasVindas = "Bem vindo ao screen sound!";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpccoes()
{
    ExibeBoasVindas();

    Console.WriteLine("\nSelecione uma opção:");
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar todas as bandas ");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir media de uma banda");
    Console.WriteLine("0 - Sair");
    Console.Write("\nDigite sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine($"Você escolheu {opcaoEscolhidaNumerica}!, avaliar uma banda.");
            break;
        case 4:
            Console.WriteLine($"Você escolheu {opcaoEscolhidaNumerica}!, exibir a média de uma banda.");
            break;
        case 0:
            Console.WriteLine("Saindo do programa. Até logo!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            ExibirOpccoes();
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Banda");

    bool continuarResposta;

    do
    {
        Console.WriteLine("\nDigite a banda que deseja registrar:");

        string bandaRegistrada = Console.ReadLine()!;

        bandasRegistradas.Add(bandaRegistrada, new List<int>());
        Console.WriteLine($"Banda '{bandaRegistrada}' registrada com sucesso!");
        Console.WriteLine("Deseja registrar outra banda? (s/n)");

        string resposta = Console.ReadLine();

        continuarResposta = resposta.ToLower() == "s" || resposta.ToLower() == "sim" ;

    } while (continuarResposta == true);

    Console.Clear();

    ExibirOpccoes();
}
void ListarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Bandas Registradas:\n");

    if (bandasRegistradas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada ainda.");
    }
    else
    {
        foreach (var banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"- {banda}");
        }
        Console.WriteLine($"\nTotal de bandas registradas: {bandasRegistradas.Count}");
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();

    ExibirOpccoes();
}

ExibirOpccoes();

