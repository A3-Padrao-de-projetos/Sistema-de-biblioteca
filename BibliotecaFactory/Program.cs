using Biblioteca.Classes;
using Biblioteca.Factory;

public class Tela
{
    static void Main(string[] args)
    {
        Bibliotecas biblioteca = new Bibliotecas("Biblioteca Central", "Rua Principal, 123");
        
        biblioteca.Clientes.AddRange(new List<Clientes>
        {
            new Clientes("Carlos Oliveira","213.342.567-05", "Rua A, 123", "99999-1234", biblioteca),
            new Clientes("Maria Silva","213.342.567-05", "Rua B, 456", "88888-5678", biblioteca),
            new Clientes("Arthur", "130.713.766-50", "Rua Otilia Costa Peres, 333", "(31) 98909-8658", biblioteca),
            new Clientes("Beatriz", "152.482.933-22", "Av. Brasil, 1200", "(21) 98563-4567", biblioteca),
            new Clientes("Carlos", "207.394.667-89", "Rua das Flores, 450", "(11) 97845-1234", biblioteca),
            new Clientes("Daniela", "308.567.998-77", "Rua José Bonifácio, 785", "(41) 99674-3245", biblioteca),
            new Clientes("Eduardo", "405.683.221-66", "Av. Sete de Setembro, 1500", "(31) 98765-4321", biblioteca),
            new Clientes("Fernanda", "501.772.889-44", "Praça da Liberdade, 60", "(21) 97654-7890", biblioteca),
            new Clientes("Gabriela", "612.345.789-10", "Rua Nova Esperança, 101", "(41) 99887-6543", biblioteca),
            new Clientes("Lucas", "713.456.890-21", "Av. das Nações, 202", "(21) 99543-2176", biblioteca),
            new Clientes("Isabela", "814.567.901-32", "Praça dos Pioneiros, 303", "(11) 99658-3472", biblioteca),
            new Clientes("Marcos", "915.678.012-43", "Rua do Comércio, 404", "(31) 98764-2198", biblioteca),
            new Clientes("Ana", "016.789.123-54", "Av. Central, 505", "(71) 99321-7845", biblioteca),
            new Clientes("Paulo", "117.890.234-65", "Rua das Laranjeiras, 606", "(51) 98123-0987", biblioteca),
            new Clientes("Clara", "218.901.345-76", "Alameda das Rosas, 707", "(41) 99912-3456", biblioteca),
            new Clientes("João", "319.012.456-87", "Travessa da Harmonia, 808", "(31) 98421-6789", biblioteca),
            new Clientes("Renata", "420.123.567-98", "Rua Primavera, 909", "(21) 99732-5674", biblioteca),
            new Clientes("Felipe", "521.234.678-09", "Av. Rio Branco, 1010", "(11) 99213-4567", biblioteca),
        });

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
            new Livros("A sutil arte de ligar o f*da-se", "Mark Manson", 2016, "Disponível", biblioteca),
            new Livros("O senhor dos anéis", "J.R.R. Tolkien", 1954, "Disponível", biblioteca),
            new Livros("O Hobbit", "J.R.R. Tolkien", 1937, "Indisponível", biblioteca),
            new Livros("Orgulho e preconceito", "Jane Austen", 1813, "Disponível", biblioteca),
            new Livros("Dom Quixote", "Miguel de Cervantes", 1605, "Disponível", biblioteca),
            new Livros("A culpa é das estrelas", "John Green", 2012, "Indisponível", biblioteca),
            new Livros("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 1997, "Disponível", biblioteca),
            new Livros("Cem anos de solidão", "Gabriel García Márquez", 1967, "Disponível", biblioteca),
            new Livros("Moby Dick", "Herman Melville", 1851, "Disponível", biblioteca),
            new Livros("O alquimista", "Paulo Coelho", 1988, "Indisponível", biblioteca),
            new Livros("A revolução dos bichos", "George Orwell", 1945, "Disponível", biblioteca)
        });

        bool loop = true;

        bool loginSucesso = false;

        while (!loginSucesso)
        {
            Console.WriteLine("Usuário: ");
            string user = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            if (user == "adm" && senha == "adm")
            {
                while (loop)
                {
                    Console.Clear();
                    Console.WriteLine("=== Sistema de Gerenciamento de Biblioteca ===");
                    Console.WriteLine("1. Livro");
                    Console.WriteLine("2. Adicionar cliente");
                    Console.WriteLine("3. Adicionar funcionário");
                    Console.WriteLine("4. Enviar Notificação");
                    Console.WriteLine("5. Sair");
                    Console.Write("Escolha uma opção: ");

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            bool loop2 = true;
                            while (loop2)
                            {
                                Console.Clear();
                                Console.WriteLine("=== Livro ===");
                                Console.WriteLine("1. Realizar Empréstimo");
                                Console.WriteLine("2. Adicionar Livro");
                                Console.WriteLine("3. Listar Livros");
                                Console.WriteLine("4. Atualizar Livro");
                                Console.WriteLine("5. Remover Livro");
                                Console.WriteLine("6. Voltar");
                                Console.Write("Escolha uma opção: ");

                                string opcao1 = Console.ReadLine();

                                switch (opcao1)
                                {
                                    case "1":
                                        IEntidadeFactory emprestimoFactory = new EmprestimoFactory();
                                        emprestimoFactory.CriarEntidade(biblioteca);
                                        break;

                                    case "2":
                                        IEntidadeFactory livroFactory = new LivroFactory();
                                        livroFactory.CriarEntidade(biblioteca);
                                        break;

                                    case "3":
                                        IEntidadeFactory listarLivroFactory = new ListarLivroFactory();
                                        listarLivroFactory.CriarEntidade(biblioteca);
                                        break;

                                    case "4":
                                        IEntidadeFactory atualizarLivroFactory = new AtualizarLivroFactory();
                                        atualizarLivroFactory.CriarEntidade(biblioteca);
                                        break;

                                    case "5":
                                        IEntidadeFactory removerLivroFactory = new RemoverLivroFactory();
                                        removerLivroFactory.CriarEntidade(biblioteca);
                                        break;

                                    case "6":
                                        Console.WriteLine("Voltando...");
                                        loop2 = false;
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida. Tente novamente.");
                                        break;
                                }
                                Console.ReadKey();
                            }
                            break;

                        case "2":
                            IEntidadeFactory clienteFactory = new ClienteFactory();
                            clienteFactory.CriarEntidade(biblioteca);
                            break;

                        case "3":
                            IEntidadeFactory funcionarioFactory = new FuncionarioFactory();
                            funcionarioFactory.CriarEntidade(biblioteca);
                            break;

                        case "4":
                            IEntidadeFactory notificacaoFactory = new NotificacaoFactory();
                            notificacaoFactory.CriarEntidade(biblioteca);
                            break;

                        case "5":
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
            else
            {
                Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
            }
        }
    }
}
