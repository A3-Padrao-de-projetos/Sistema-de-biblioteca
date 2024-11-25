using System;
using Biblioteca.Classes.Biblioteca.Biblioteca;
using Biblioteca.Classes.Emprestimo.Emprestimo;
using Biblioteca.Classes.Notificacao.Notificacao;


namespace Biblioteca.Classes.Cliente.Cliente
{
    public class Cliente
    {
        private static int newID = 1;
        private int ClienteID { get; private set }
        private string Nome { get; set; }
        private string CPF { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }
        private int BibliotecaID { get; set; }
        private Biblioteca Biblioteca { get; set; }
        private List<Emprestimo> Emprestimos { get; set; }
        private List<Notificacao> Notificacoes { get; set; }

        public Cliente(string nome, string CPF, string endereco, string telefone, Biblioteca biblioteca)
        {
            this.ClienteID = newID++;
            this.Nome = nome;
            this.CPF = CPF;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Biblioteca = biblioteca;
            this.BibliotecaID = biblioteca.BibliotecaID;
            this.Emprestimos = new List<Emprestimo>();
            this.Notificacoes = new List<Notificacao>();
        }

        public void RealizarEmprestimo(Livro livro, Funcionario funcionario)
        {
            if (livro.EstaDisponivel())
            {
                Emprestimo emprestimo = new Emprestimo(Emprestimos.Count + 1, DateTime.Now, DateTime.Now.AddDays(14), livro, this, funcionario);
                Emprestimos.Add(emprestimo);
                livro.AtualizarStatus("Emprestado");
            }
        }

        public void ReceberNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
    }
}