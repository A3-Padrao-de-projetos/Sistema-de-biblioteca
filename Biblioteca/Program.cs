using System;
using System.Collections.Generic;
using Biblioteca.Classes.Livro;
using Biblioteca.Classes.Funcionario;
using Biblioteca.Classes.Cliente;
using Biblioteca.Classes.Notificacao;
using Biblioteca.Classes.Emprestimo;
using Biblioteca.Info;
using Biblioteca.Classes.CategoriaLivro;
using Biblioteca.Classes.Biblioteca;

namespace Biblioteca.Program
{
    public class Program
    {

        Bibliotecas biblioteca = new Bibliotecas("Biblioteca UNA", "Av. Maria da Glória Rocha, 175");
        Infos infos = new Infos();


        public  void AdicionarLivro(Bibliotecas biblioteca, CategoriaLivros categoriaLivro)
        {
            Console.WriteLine("=== Adicionar Livro ===");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Ano de Publicação: ");
            int anoPublicacao = int.Parse(Console.ReadLine());

            Livros livro = new Livros(titulo, autor, anoPublicacao, "Disponível", biblioteca, categoriaLivro);
            biblioteca.AdicionarLivro(livro);

            Console.WriteLine("Livro adicionado com sucesso!");
        }

        public void AdicionarCliente(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Adicionar Cliente ===");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string CPF = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Clientes cliente = new Clientes(nome, CPF, endereco, telefone, biblioteca);
            biblioteca.AdicionarCliente(cliente);

            Console.WriteLine("Cliente adicionado com sucesso!");
        }

        public void AdicionarFuncionario(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Adicionar Funcionário ===");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string CPF = Console.ReadLine();
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Funcionarios funcionario = new Funcionarios(nome, CPF, cargo, salario, biblioteca);
            biblioteca.AdicionarFuncionario(funcionario);

            Console.WriteLine("Funcionário adicionado com sucesso!");
        }

        public void RealizarEmprestimo(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Realizar Empréstimo ===");

            Console.Write("ID do Livro: ");
            int livroID = int.Parse(Console.ReadLine());
            var livro = biblioteca.Livros.Find(l => l.LivroID == livroID);

            if (livro == null || !livro.EstaDisponivel())
            {
                Console.WriteLine("Livro não encontrado ou indisponível.");
                return;
            }

            Console.Write("ID do Cliente: ");
            int clienteID = int.Parse(Console.ReadLine());
            var cliente = biblioteca.Clientes.Find(c => c.ClienteID == clienteID);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Console.Write("ID do Funcionário: ");
            int funcionarioID = int.Parse(Console.ReadLine());
            var funcionario = biblioteca.Funcionarios.Find(f => f.FuncionarioID == funcionarioID);

            if (funcionario == null)
            {
                Console.WriteLine("Funcionário não encontrado.");
                return;
            }

            cliente.RealizarEmprestimo(livro, funcionario);
            Console.WriteLine("Empréstimo realizado com sucesso!");
        }

        public void EnviarNotificacao(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Enviar Notificação ===");

            Console.Write("ID do Funcionário (opcional, digite 0 para sistema): ");
            int funcionarioID = int.Parse(Console.ReadLine());
            Funcionarios funcionario = null;
            if (funcionarioID != 0)
            {
                funcionario = biblioteca.Funcionarios.Find(f => f.FuncionarioID == funcionarioID);
                if (funcionario == null)
                {
                    Console.WriteLine("Funcionário não encontrado.");
                    return;
                }
            }

            Console.Write("ID do Cliente: ");
            int clienteID = int.Parse(Console.ReadLine());
            var cliente = biblioteca.Clientes.Find(c => c.ClienteID == clienteID);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Console.Write("Mensagem: ");
            string mensagem = Console.ReadLine();

            Notificacoes notificacao = new Notificacoes(mensagem, DateTime.Now, cliente, funcionario);
            notificacao.Enviar();
            Console.WriteLine("Notificação enviada com sucesso!");
        }

        public void ListarLivros(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Livros na Biblioteca ===");

            if (biblioteca.Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro disponível.");
                return;
            }

            foreach (var livro in biblioteca.Livros)
            {
                Console.WriteLine($"ID: {livro.LivroID}, Título: {livro.Titulo}, Autor: {livro.Autor}, Status: {livro.Status}");
            }
        }
    }
}