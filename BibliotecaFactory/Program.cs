using Biblioteca.Classes;
using Biblioteca.Factory;

public class Tela
{
    static void Main(string[] args)
    {
        Bibliotecas biblioteca = new Bibliotecas("Biblioteca Central", "Rua Principal, 123");

        biblioteca.Funcionarios.AddRange(new List<Funcionarios>
        {
            new Funcionarios("João Silva","213.342.567-05", "Atendente", 1500m, biblioteca),
            new Funcionarios("Ana Costa","213.342.567-05", "Gerente", 5000m, biblioteca),
            new Funcionarios("Samuel", "213.342.567-05", "Bibliotecario", 1500.00m, biblioteca),
            new Funcionarios("Carolina", "314.456.789-22", "Auxiliar de Biblioteca", 1200.00m, biblioteca),
            new Funcionarios("Roberto", "425.567.891-33", "Atendente", 1400.00m, biblioteca),
            new Funcionarios("Fernanda", "536.678.912-44", "Catalogador", 1400.00m, biblioteca),
            new Funcionarios("Mariana", "758.891.234-66", "Técnico em Conservação de Livros", 1600.00m, biblioteca),
        });

        biblioteca.Livros.AddRange(new List<Livros>
        {
            new Livros("Duna", "Frank Herbert", 1965, "Disponível", biblioteca),
            new Livros("O poder do hábito", "Charles Duhigg", 2012, "Disponível", biblioteca),
            new Livros("A garota no trem", "Paula Hawkins", 2015, "Disponível", biblioteca),
            new Livros("1984", "George Orwell", 1949, "Disponível", biblioteca),
            new Livros("O pequeno príncipe", "Antoine de Saint-Exupéry", 1943, "Disponível", biblioteca),
            new Livros("O código Da Vinci", "Dan Brown", 2003, "Indisponível", biblioteca),
        });


        bool loginSucesso = false;
        while (!loginSucesso)
        {
            Console.WriteLine("Usuário: ");
            string user = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            if (user == "adm" && senha == "adm")
            {
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
            else
            {
                Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
            }

        }
    }
}
