using minibanco;

bool executando = true;

List<Conta> contas = new List<Conta>();

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
            {
                Console.WriteLine("Tipo: 1-Corrente  2-Poupança  3-Salário");
                string tipo = Console.ReadLine();

                Console.Write("Titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                decimal saldoInicial = decimal.Parse(Console.ReadLine());

                if (tipo == "1")
                {
                    Console.Write("Limite do cheque especial: ");
                    decimal limite = decimal.Parse(Console.ReadLine());

                    contas.Add(new ContaCorrente(titular, saldoInicial, limite));
                    Console.WriteLine("Conta corrente criada!");
                }
                else if (tipo == "2")
                {
                    Console.Write("Taxa de rendimento mensal (%): ");
                    double taxaRendimento = double.Parse(Console.ReadLine());

                    Console.Write("Dia do aniversário: ");
                    int diaAniversario = int.Parse(Console.ReadLine());

                    contas.Add(new ContaPoupanca(titular, saldoInicial, taxaRendimento, diaAniversario));
                    Console.WriteLine("Conta poupança criada!");
                }
                else if (tipo == "3")
                {
                    Console.Write("Empregador: ");
                    string empregador = Console.ReadLine();

                    Console.Write("Limite de saques mensais: ");
                    int limiteSaquesMensais = int.Parse(Console.ReadLine());

                    contas.Add(new ContaSalario(titular, saldoInicial, empregador, limiteSaquesMensais));
                    Console.WriteLine("Conta salário criada!");
                }
                else
                {
                    Console.WriteLine("Tipo de conta inválido!");
                }
                break;
            }
        case "2":
            {
                if (contas.Count == 0)
                {
                    Console.WriteLine("Nenhuma conta cadastrada.");
                    break;
                }

                for (int i = 0; i < contas.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {contas[i].Titular} | Saldo: {contas[i].Saldo:C}");
                }

                Console.Write("Escolha a conta: ");
                if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > contas.Count)
                {
                    Console.WriteLine("Conta inválida!");
                    break;
                }

                Console.Write("Valor do depósito: ");
                decimal valor = decimal.Parse(Console.ReadLine());

                contas[escolha - 1].Depositar(valor);
                Console.WriteLine($"Novo saldo: {contas[escolha - 1].Saldo:C}");
                break;
            }
        case "3":
            {
                if (contas.Count == 0)
                {
                    Console.WriteLine("Nenhuma conta cadastrada.");
                    break;
                }

                for (int i = 0; i < contas.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {contas[i].Titular} | Saldo: {contas[i].Saldo:C}");
                }

                Console.Write("Escolha a conta: ");
                if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > contas.Count)
                {
                    Console.WriteLine("Conta inválida!");
                    break;
                }

                Console.Write("Valor do saque: ");
                decimal valor = decimal.Parse(Console.ReadLine());

                if (contas[escolha - 1].Sacar(valor))
                {
                    Console.WriteLine("Saque realizado com sucesso!");
                    Console.WriteLine($"Novo saldo: {contas[escolha - 1].Saldo:C}");
                }
                break;
            }
        case "4":
            Console.WriteLine("Fechar mês (em construção)");
            break;
        case "5":
            {
                if (contas.Count == 0)
                {
                    Console.WriteLine("Nenhuma conta cadastrada.");
                }
                else
                {
                    foreach (Conta conta in contas)
                    {
                        Console.WriteLine($"{conta.GetType().Name} | Titular: {conta.Titular} | Saldo: {conta.Saldo:C}");
                    }
                }
                break;
            }

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