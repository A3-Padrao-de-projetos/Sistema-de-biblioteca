using System;
using Biblioteca.Classes.Livro.Livro;

namespace Biblioteca.Classes.CategoriaLivro.CategoriaLivro
{
    public class CategoriaLivro
    {
        private static int newID = 1;
        private int CategoriaLivroID { get; private set; }
        private string Nome { get; set; }
        private List<Livro> Livros { get; set; }

        public CategoriaLivro(string nome)
        {
            this.CategoriaLivroID = newID++;
            this.Nome = nome;
            this.Livros = new List<Livro>();
        }
    }
}