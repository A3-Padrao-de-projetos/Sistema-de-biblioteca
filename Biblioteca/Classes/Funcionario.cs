using System;
using System.Collections.Generic;
using Biblioteca.Classes.BibliotecaNamespace;
using Biblioteca.Classes.NotificacaoNamespace;
using Biblioteca.Classes.ClienteNamespace;

namespace Biblioteca.Classes.FuncionarioNamespace
{
    public class Funcionario
    {
        private static int newID = 1;
        public int FuncionarioID { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Cargo { get; private set; }
        public decimal Salario { get; private set; }
        public List<Notificacao> Notificacoes { get; private set; }

        public Funcionario(string nome, string cpf, string cargo, decimal salario)
        {
            FuncionarioID = newID++;
            Nome = nome;
            CPF = cpf;
            Cargo = cargo;
            Salario = salario;
            Notificacoes = new List<Notificacao>();
        }

        public void EnviarNotificacao(Cliente cliente, string mensagem)
        {
            Notificacao notificacao = new Notificacao(mensagem, DateTime.Now, cliente, this);
            Notificacoes.Add(notificacao);
            cliente.ReceberNotificacao(notificacao);
        }
    }
}