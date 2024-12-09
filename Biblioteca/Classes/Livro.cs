using System;
using System.Collections.Generic;
using Biblioteca.Classes.BibliotecaNamespace;
using Biblioteca.Classes.CategoriaLivrosNamespace;
using Biblioteca.Classes.EmprestimoNamespace;

namespace Biblioteca.Classes.LivroNamespace
{
    public class Livro
    {
        private static int newID = 1;
        public int LivroID { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoPublicacao { get; private set; }
        public string Status { get; private set; }
        public CategoriaLivros CategoriaLivro { get; private set; }
        public List<Emprestimo> Emprestimos { get; private set; }

        public Livro(string titulo, string autor, int anoPublicacao, string status, CategoriaLivros categoriaLivro)
        {
            LivroID = newID++;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Status = status;
            CategoriaLivro = categoriaLivro;
            Emprestimos = new List<Emprestimo>();
        }

        public void AtualizarStatus(string status)
        {
            Status = status;
        }

        public bool EstaDisponivel()
        {
            return Status == "Disponível";
        }
    }
}