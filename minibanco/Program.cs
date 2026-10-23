bool executando = true;

while (executando)
{
    Console.Clear();
    Console.WriteLine("===== MINIBANCO =====");
    Console.WriteLine("1 - Criar conta");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Fechar mês");
    Console.WriteLine("5 - Listar contas");
    Console.WriteLine("6 - Relatório de saúde financeira");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Criar conta (em construção)");
            break;
        case "2":
            Console.WriteLine("Depositar (em construção)");
            break;
        case "3":
            Console.WriteLine("Sacar (em construção)");
            break;
        case "4":
            Console.WriteLine("Fechar mês (em construção)");
            break;
        case "5":
            Console.WriteLine("Listar contas (em construção)");
            break;
        case "6":
            Console.WriteLine("Relatório (em construção)");
            break;
        case "0":
            executando = false;
            Console.WriteLine("Encerrando...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (executando)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}