using System;
using Biblioteca.Classes.LivroNamespace;
using Biblioteca.Classes.ClienteNamespace;

namespace Biblioteca.Classes.EmprestimoNamespace
{
    public class Emprestimo
    {
        public Livro Livro { get; }
        public Cliente Cliente { get; }
        public DateTime DataEmprestimo { get; }
        public DateTime DataDevolucao { get; }

        public Emprestimo(Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            Livro = livro;
            Cliente = cliente;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }
    }
}