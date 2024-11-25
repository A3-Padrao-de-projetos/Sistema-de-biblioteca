using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Classes.Cliente.Cliente;
using Biblioteca.Classes.Livro.Livro;
using Biblioteca.Classes.Funcionario.Funcionario;

namespace Biblioteca.Classes.Biblioteca.Biblioteca
{
    public class Biblioteca
    {
        private const int BibliotecaID = 1;   
        public string Nome { get; private set; } 
        public string Endereco { get; private set; } 
        public List<Livro> Livros { get; private set; } 
        public List<Cliente> Clientes { get; private set; } 
        public List<Funcionario> Funcionarios { get; private set; }

        public Biblioteca(string nome, string endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            Livros = new List<Livro>();
            Funcionarios = new List<Funcionario>();
            Clientes = new List<Cliente>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public Livro ProcurarLivroPorTitulo(string titulo)
        {
            return Livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}