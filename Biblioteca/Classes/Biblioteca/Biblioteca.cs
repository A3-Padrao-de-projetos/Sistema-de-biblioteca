using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Classes.Cliente;
using Biblioteca.Classes.Funcionario;
using Biblioteca.Classes.Livro;

namespace Biblioteca.Classes.Biblioteca
{
    public class Bibliotecas
    {
        public int BibliotecaID { get; private set; } = 1;
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public List<Livros> Livros { get; private set; }
        public List<Clientes> Clientes { get;  set; }
        public List<Funcionarios> Funcionarios { get; private set; }

        public Bibliotecas(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Livros = new List<Livros>();
            Funcionarios = new List<Funcionarios>();
            Clientes = new List<Clientes>();
        }

        public void AdicionarLivro(Livros livro)
        {
            Livros.Add(livro);
        }

        public void AdicionarFuncionario(Funcionarios funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void AdicionarCliente(Clientes cliente)
        {
            Clientes.Add(cliente);
        }

        public Livros ProcurarLivroPorTitulo(string titulo)
        {
            return Livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}