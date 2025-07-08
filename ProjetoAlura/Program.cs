string mensagemDeBoasVindas = "Bem vindo ao screen sound!";
List<string> bandasRegistradas = new List<string>();
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
        Console.WriteLine("Digite a banda que deseja registrar:");

        string bandaRegistrada = Console.ReadLine()!;

        bandasRegistradas.Add(bandaRegistrada);
        Console.WriteLine($"Banda '{bandaRegistrada}' registrada com sucesso!");
        Console.WriteLine($"Total de bandas registradas: {bandasRegistradas.Count}");
        Console.WriteLine("Deseja registrar outra banda? (s/n)");

        string resposta = Console.ReadLine();

        continuarResposta = resposta.ToLower() == "s";

    } while (continuarResposta == true);
    
}

ExibeBoasVindas();
ExibirOpccoes();
