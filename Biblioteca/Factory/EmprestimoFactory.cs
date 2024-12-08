using System;
using BibliotecaSystem; // Atualizado
using Biblioteca.Classes.EmprestimoNamespace;
using Biblioteca.Classes.ClienteNamespace;
using Biblioteca.Classes.LivroNamespace;

namespace Biblioteca.Factory
{
    public class EmprestimoFactory : IEntidadeFactory
    {
        public void CriarEntidade(Biblioteca biblioteca)
        {
            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            var cliente = biblioteca.Clientes.Find(c => c.Nome.Equals(nomeCliente, StringComparison.OrdinalIgnoreCase));
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");
                return;
            }

            Console.Write("Digite o título do livro: ");
            string tituloLivro = Console.ReadLine();

            var livro = biblioteca.Livros.Find(l => l.Titulo.Equals(tituloLivro, StringComparison.OrdinalIgnoreCase));
            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado!");
                return;
            }

            // Supondo que o funcionário é sempre o primeiro da lista para simplificação.
            var funcionario = biblioteca.Funcionarios.FirstOrDefault();
            if (funcionario != null)
            {
                cliente.RealizarEmprestimo(livro, funcionario);
            }
            else
            {
                Console.WriteLine("Nenhum funcionário disponível para realizar o empréstimo.");
            }
        }
    }
}