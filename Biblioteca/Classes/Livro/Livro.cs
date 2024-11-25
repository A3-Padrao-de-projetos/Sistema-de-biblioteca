using System;
using Biblioteca.Classes.Biblioteca.Biblioteca;
using Biblioteca.Classes.CategoriaLivro.CategoriaLivro;
using Biblioteca.Classes.Emprestimo.Emprestimo;

namespace Biblioteca.Classes.Livro.Livro
{
    public class Livro
    {
        private static int newID = 1;
        private int LivroID { get; private set; }
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private int AnoPublicacao { get; set; }
        private string Status { get; set; }
        private int BibliotecaID { get; set; }
        private Biblioteca Biblioteca { get; set; }
        private int CategoriaLivroID { get; set; }
        private CategoriaLivro CategoriaLivro { get; set; }
        private List<Emprestimo> Emprestimos { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao, string status, Biblioteca biblioteca, CategoriaLivro categoriaLivro)
        {
            this.LivroID = newID++;
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPublicacao = anoPublicacao;
            this.Status = status;
            this.Biblioteca = biblioteca;
            this.BibliotecaID = biblioteca.BibliotecaID;
            this.CategoriaLivro = categoriaLivro;
            this.CategoriaLivroID = categoriaLivro.CategoriaLivroID;
            this.Emprestimos = new List<Emprestimo>();
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
