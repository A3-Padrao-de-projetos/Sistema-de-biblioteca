using System;

public class Main
{
    static void Main(string[] args)
    {
        // Instâncias iniciais
        var biblioteca = new Biblioteca(1, "Biblioteca UNA", "Av. Maria da Glória Rocha, 175");
        // var categoriaLivro = new CategoriaLivro(1, "Ficção Científica");

        // Menu interativo
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Gerenciamento de Biblioteca ===");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Adicionar Membro");
            Console.WriteLine("3. Adicionar Funcionário");
            Console.WriteLine("4. Realizar Empréstimo");
            Console.WriteLine("5. Enviar Notificação");
            Console.WriteLine("6. Listar Livros");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarLivro(biblioteca, categoriaLivro);
                    break;
                case "2":
                    AdicionarMembro(biblioteca);
                    break;
                case "3":
                    AdicionarFuncionario(biblioteca);
                    break;
                case "4":
                    RealizarEmprestimo(biblioteca);
                    break;
                case "5":
                    EnviarNotificacao(biblioteca);
                    break;
                case "6":
                    ListarLivros(biblioteca);
                    break;
                case "7":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
