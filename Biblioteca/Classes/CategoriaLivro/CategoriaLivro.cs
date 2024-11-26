using System;
using Biblioteca.Classes.Livro;

namespace Biblioteca.Classes.CategoriaLivro
{
    public class CategoriaLivros
    {
        private static int newID = 1;
        public int CategoriaLivroID { get; private set; }
        public string Nome { get; set; }
        public List<Livros> Livros { get; set; }

        public CategoriaLivros(string nome)
        {
            CategoriaLivroID = newID++;
            Nome = nome;
            Livros = new List<Livros>();
        }
    }
}