using System;

class Program
{
    // Constantes
    const int QUANTIDADE_NOTAS = 3;
    const double NOTA_MINIMA = 0.0;
    const double NOTA_MAXIMA = 10.0;
    const double MEDIA_APROVACAO = 7.0;
    const double MEDIA_RECUPERACAO = 5.0;

    // Dados do programa
    static string nomeAluno = "";
    static double[] notas = new double[QUANTIDADE_NOTAS];
    static bool notasLancadas = false;

    static void Main()
    {
        int opcao;

        do
        {
            ExibirMenu();
            opcao = LerOpcaoMenu();

            switch (opcao)
            {
                case 1:
                    CadastrarAluno();
                    break;
                case 2:
                    Console.WriteLine("\n(Lançar notas: ainda não implementado)");
                    break;
                case 3:
                    Console.WriteLine("\n(Calcular média: ainda não implementado)");
                    break;
                case 4:
                    Console.WriteLine("\nEncerrando o programa!");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Digite um número de 1 a 4.");
                    break;
            }
        } while (opcao != 4);
    }

    static void ExibirMenu()
    {
        Console.WriteLine("\n=== CALCULADORA DE NOTAS ===");
        Console.WriteLine("1 - Cadastrar aluno");
        Console.WriteLine("2 - Lançar notas");
        Console.WriteLine("3 - Calcular média");
        Console.WriteLine("4 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    static int LerOpcaoMenu()
    {
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int opcao))
        {
            return opcao;
        }

        return 0; // 0 cai no "default" do switch (opção inválida)
    }

    static void CadastrarAluno()
    {
        while (true)
        {
            Console.Write("\nDigite o nome do aluno: ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Nome inválido! O nome não pode ficar vazio.");
                continue;
            }

            nomeAluno = entrada.Trim();
            Console.WriteLine($"Aluno \"{nomeAluno}\" cadastrado com sucesso!");
            break;
        }
    }











}



