string mensagemDeBoasVindas = "Bem vindo ao screen sound!";
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
            Console.WriteLine("$Você escolheu {opcaoEscolhidaNumerica}!, registrar uma banda.");
            break;
        case 2:
            Console.WriteLine($"Você escolheu {opcaoEscolhidaNumerica}!, mostrar todas as bandas.");
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

ExibeBoasVindas();
ExibirOpccoes();
