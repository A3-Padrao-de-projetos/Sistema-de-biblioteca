using System;
using Biblioteca.Classes.ClienteNamespace;
using Biblioteca.Classes.FuncionarioNamespace;

namespace Biblioteca.Classes.NotificacaoNamespace
{
    public class Notificacao
    {
        public string Mensagem { get; private set; }
        public DateTime Data { get; private set; }
        public Cliente Cliente { get; private set; }
        public Funcionario Funcionario { get; private set; }

        public Notificacao(string mensagem, DateTime data, Cliente cliente, Funcionario funcionario)
        {
            Mensagem = mensagem;
            Data = data;
            Cliente = cliente;
            Funcionario = funcionario;
        }
    }
}