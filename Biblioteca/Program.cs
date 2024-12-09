using System;
using Biblioteca.Classes.BibliotecaNamespace;
using Biblioteca.Factory;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome da biblioteca: ");
            string nomeBiblioteca = Console.ReadLine() ?? "Biblioteca Padrão";
            Console.Write("Digite o endereço da biblioteca: ");
            string enderecoBiblioteca = Console.ReadLine() ?? "Endereço Padrão";

            Biblioteca biblioteca = new Biblioteca(nomeBiblioteca, enderecoBiblioteca);

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("=== Sistema da Biblioteca ===");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Adicionar Livro");
                Console.WriteLine("3. Adicionar Funcionário");
                Console.WriteLine("4. Realizar Empréstimo");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        IEntidadeFactory clienteFactory = new ClienteFactory();
                        clienteFactory.CriarEntidade(biblioteca);
                        break;

                    case "2":
                        IEntidadeFactory livroFactory = new LivroFactory();
                        livroFactory.CriarEntidade(biblioteca);
                        break;

                    case "3":
                        IEntidadeFactory funcionarioFactory = new FuncionarioFactory();
                        funcionarioFactory.CriarEntidade(biblioteca);
                        break;

                    case "4":
                        IEntidadeFactory emprestimoFactory = new EmprestimoFactory();
                        emprestimoFactory.CriarEntidade(biblioteca);
                        break;

                    case "0":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }

            Console.WriteLine("Saindo do sistema. Até logo!");
        }
    }
}