using System;
using Biblioteca.Classes.Biblioteca;
using Biblioteca.Classes.Notificacao;
using Biblioteca.Classes.Cliente;

namespace Biblioteca.Classes.Funcionario
{
    public class Funcionarios
    {
        private static int newID = 1;
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public int BibliotecaID { get; set; }
        public Bibliotecas Biblioteca { get; set; }
        public List<Notificacoes> Notificacoes { get; set; }

        public Funcionarios(string nome, string CPF, string cargo, decimal salario, Bibliotecas biblioteca)
        {
            FuncionarioID = newID++;
            Nome = nome;
            this.CPF = CPF;
            Cargo = cargo;
            Salario = salario;
            Biblioteca = biblioteca;
            BibliotecaID = biblioteca.BibliotecaID;
            Notificacoes = new List<Notificacoes>();
        }

        public void EnviarNotificacao(Clientes cliente, string mensagem)
        {
            Notificacoes notificacao = new(mensagem, DateTime.Now, cliente, this);

            Notificacoes.Add(notificacao);

            cliente.ReceberNotificacao(notificacao);
        }
    }
}