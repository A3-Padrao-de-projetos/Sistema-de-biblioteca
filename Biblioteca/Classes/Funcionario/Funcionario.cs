using System;
using Biblioteca.Classes.Biblioteca.Biblioteca;
using Biblioteca.Classes.Notificacao.Notificacao;
using Biblioteca.Classes.Cliente.Cliente;

namespace Biblioteca.Classes.Funcionario.Funcionario
{
    public class Funcionario
    {
        private static int newID = 1;
        private int FuncionarioID { get; private set }
        private string Nome { get; set; }
        private string CPF { get; set; }
        private string Cargo { get; set; }
        private decimal Salario { get; set; }
        private int BibliotecaID { get; set; }
        private Biblioteca Biblioteca { get; set; }
        private List<Notificacao> Notificacoes { get; set; }

        public Funcionario(string nome, string CPF, string cargo, decimal salario, Biblioteca biblioteca)
        {
            this.FuncionarioID = newID++;
            this.Nome = nome;
            this.CPF = CPF;
            this.Cargo = cargo;
            this.Salario = salario;
            this.Biblioteca = biblioteca;
            this.BibliotecaID = biblioteca.BibliotecaID;
            this.Notificacoes = new List<Notificacao>();
        }

        public void EnviarNotificacao(Cliente cliente, string mensagem)
        {
            Notificacao notificacao = new Notificacao(Notificacoes.Count + 1, mensagem, DateTime.Now, membro, this);

            Notificacoes.Add(notificacao);

            cliente.ReceberNotificacao(notificacao);
        }
    }
}