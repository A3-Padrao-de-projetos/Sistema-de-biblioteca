using System.Collections.Generic;
using Biblioteca.Classes.LivroNamespace;

namespace Biblioteca.Classes.CategoriaLivrosNamespace
{
    public class CategoriaLivros
    {
        private static int newID = 1;
        public int CategoriaLivroID { get; private set; }
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }

        public CategoriaLivros(string nome)
        {
            CategoriaLivroID = newID++;
            Nome = nome;
            Livros = new List<Livro>();
        }
    }
}