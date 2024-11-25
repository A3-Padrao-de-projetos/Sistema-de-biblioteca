using System;
using Biblioteca.Classes.Cliente.Cliente;
using Biblioteca.Classes.Funcionario.Funcionario;

namespace Biblioteca.Classes.Notificacao.Notificacao
{
    public class Notificacao
    {
        private static int newID = 1;
        private int NotificacaoID { get; private set; }
        private string Mensagem { get; set; }
        private DateTime DataEnvio { get; set; }
        private int ClienteID { get; set; }
        private Cliente cliente { get; set; }
        private int? FuncionarioID { get; set; }
        private Funcionario Funcionario { get; set; }

        public Notificacao(string mensagem, DateTime dataEnvio, Cliente cliente, Funcionario funcionario = null)
        {
            this.NotificacaoID = newID++;
            this.Mensagem = mensagem;
            this.DataEnvio = dataEnvio;
            this.Cliente = cliente;
            this.ClienteID = cliente.ClienteID;
            this.Funcionario = funcionario;
            this.FuncionarioID = funcionario?.FuncionarioID;
        }

        public void Enviar()
        {
            Console.WriteLine($"Notificação enviada para o Cliente {Cliente.Nome} com a mensagem: {Mensagem}");
            Cliente.ReceberNotificacao(this);
        }

    }
}