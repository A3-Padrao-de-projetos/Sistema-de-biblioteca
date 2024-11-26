using System;
using Biblioteca.Classes.Biblioteca;
using Biblioteca.Classes.CategoriaLivro;
using Biblioteca.Program;

public class Tela
{
    static void Main(string[] args)
    {
        Bibliotecas biblioteca = new Bibliotecas("Biblioteca UNA", "Av. Maria da Glória Rocha, 175");
        CategoriaLivros categoriaLivro = new CategoriaLivros("Ficção Científica");
        Program program = new Program();

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
                    program.AdicionarLivro(biblioteca, categoriaLivro);
                    break;
                case "2":
                    program.AdicionarCliente(biblioteca);
                    break;
                case "3":
                    program.AdicionarFuncionario(biblioteca);
                    break;
                case "4":
                    program.RealizarEmprestimo(biblioteca);
                    break;
                case "5":
                    program.EnviarNotificacao(biblioteca);
                    break;
                case "6":
                    program.ListarLivros(biblioteca);
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
