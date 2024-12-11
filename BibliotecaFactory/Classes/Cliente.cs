namespace Biblioteca.Classes
{
    public class Clientes
    {
        private static int newID = 1;
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int BibliotecaID { get; set; }
        public Bibliotecas Biblioteca { get; set; }
        public List<Emprestimos> Emprestimos { get; set; }
        public List<Notificacoes> Notificacoes { get; set; }

        public Clientes(string nome, string CPF, string endereco, string telefone, Bibliotecas biblioteca)
        {
            ClienteID = newID++;
            Nome = nome;
            this.CPF = CPF;
            Endereco = endereco;
            Telefone = telefone;
            Biblioteca = biblioteca;
            BibliotecaID = biblioteca.BibliotecaID;
            Emprestimos = new List<Emprestimos>();
            Notificacoes = new List<Notificacoes>();
        }

        
       

        public void RealizarEmprestimo(Livros livro, Funcionarios funcionario)
        {
            if (livro.EstaDisponivel())
            {
                Emprestimos emprestimo = new(DateTime.Now, DateTime.Now.AddDays(14), livro, this, funcionario);
                Emprestimos.Add(emprestimo);
                livro.AtualizarStatus("Emprestado");
            }
        }

        public void ReceberNotificacao(Notificacoes notificacao)
        {
            Notificacoes.Add(notificacao);
        }
    }
}