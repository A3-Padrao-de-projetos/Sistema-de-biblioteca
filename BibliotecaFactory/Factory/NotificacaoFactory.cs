using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class NotificacaoFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
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
    }
}
