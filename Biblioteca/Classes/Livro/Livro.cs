using System;
using Biblioteca.Classes.Biblioteca;
using Biblioteca.Classes.CategoriaLivro;
using Biblioteca.Classes.Emprestimo;

namespace Biblioteca.Classes.Livro
{
    public class Livros
    {
        private static int newID = 1;
        public int LivroID { get; private set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Status { get; set; }
        public int BibliotecaID { get; set; }
        public Bibliotecas Biblioteca { get; set; }
        public int CategoriaLivroID { get; set; }
        public CategoriaLivros CategoriaLivro { get; set; }
        public List<Emprestimos> Emprestimos { get; set; }

        public Livros(string titulo, string autor, int anoPublicacao, string status, Bibliotecas biblioteca, CategoriaLivros categoriaLivro)
        {
            LivroID = newID++;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Status = status;
            Biblioteca = biblioteca;
            BibliotecaID = biblioteca.BibliotecaID;
            CategoriaLivro = categoriaLivro;
            CategoriaLivroID = categoriaLivro.CategoriaLivroID;
            Emprestimos = new List<Emprestimos>();
        }

        public void AtualizarStatus(string novoStatus)
        {
            Status = novoStatus;
        }

        public bool EstaDisponivel()
        {
            return Status.Equals("Disponível", StringComparison.OrdinalIgnoreCase);
        }
    }
}
