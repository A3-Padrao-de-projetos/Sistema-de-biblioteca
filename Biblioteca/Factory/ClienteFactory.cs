using System;
using BibliotecaSystem; // Atualizado
using Biblioteca.Classes.ClienteNamespace;

namespace Biblioteca.Factory
{
    public class ClienteFactory : IEntidadeFactory
    {
        public void CriarEntidade(Biblioteca biblioteca)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o endereço do cliente: ");
            string endereco = Console.ReadLine();
            Console.Write("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, cpf, endereco, telefone);
            biblioteca.AdicionarCliente(cliente);
            Console.WriteLine("Cliente adicionado com sucesso!");
        }
    }
}