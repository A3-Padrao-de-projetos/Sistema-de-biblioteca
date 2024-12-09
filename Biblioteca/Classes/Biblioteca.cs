using System;
using System.Collections.Generic;
using Biblioteca.Classes.LivroNamespace;
using Biblioteca.Classes.ClienteNamespace;
using Biblioteca.Classes.FuncionarioNamespace;

namespace BibliotecaSystem // Renomeado para evitar conflitos
{
    public class Biblioteca
    {
        public int BibliotecaID { get; private set; } = 1;
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public List<Livro> Livros { get; private set; }
        public List<Cliente> Clientes { get; private set; }
        public List<Funcionario> Funcionarios { get; private set; }

        public Biblioteca(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Livros = new List<Livro>();
            Clientes = new List<Cliente>();
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarLivro(Livro livro) => Livros.Add(livro);
        public void AdicionarFuncionario(Funcionario funcionario) => Funcionarios.Add(funcionario);
        public void AdicionarCliente(Cliente cliente) => Clientes.Add(cliente);
    }
}