using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class ClienteFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o endereço do cliente: ");
            string endereco = Console.ReadLine();
            Console.Write("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();

            Clientes cliente = new Clientes(nome, cpf, endereco, telefone, biblioteca);
            biblioteca.AdicionarCliente(cliente);
            Console.WriteLine("Cliente adicionado com sucesso!");
        }
    }
}
