namespace Biblioteca.Classes
{
    public class Emprestimos
    {
        private static int newID = 1;
        public int EmprestimoID { get; private set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int LivroID { get; set; }
        public Livros Livro { get; set; }
        public int ClienteID { get; set; }
        public Clientes Cliente { get; set; }
        public int? FuncionarioID { get; set; }
        public Funcionarios Funcionario { get; set; }

        public Emprestimos(DateTime dataEmprestimo, DateTime dataDevolucao, Livros livro, Clientes cliente, Funcionarios funcionario = null)
        {
            EmprestimoID = newID++;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            Livro = livro;
            LivroID = livro.LivroID;
            Cliente = cliente;
            ClienteID = cliente.ClienteID;
            Funcionario = funcionario;
            FuncionarioID = funcionario?.FuncionarioID;
        }
    }
}
