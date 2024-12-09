using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class EmprestimoFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
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
    }
}
