namespace Biblioteca.Classes
{
    public class Notificacoes
    {
        private static int newID = 1;
        public int NotificacaoID { get; private set; }
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
        public int ClienteID { get; set; }
        public Clientes Cliente { get; set; }
        public int? FuncionarioID { get; set; }
        public Funcionarios Funcionario { get; set; }

        public Notificacoes(string mensagem, DateTime dataEnvio, Clientes cliente, Funcionarios funcionario)
        {
            NotificacaoID = newID++;
            Mensagem = mensagem;
            DataEnvio = dataEnvio;
            Cliente = cliente;
            ClienteID = cliente.ClienteID;
            Funcionario = funcionario;
            FuncionarioID = funcionario?.FuncionarioID;
        }

        public void Enviar()
        {
            Console.WriteLine($"Notificação enviada para o Cliente {Cliente.Nome} com a mensagem: {Mensagem}");
            Cliente.ReceberNotificacao(this);
        }

    }
}