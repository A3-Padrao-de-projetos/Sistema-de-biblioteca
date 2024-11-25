using System;
using Biblioteca.Classes.Livro.Livro;
using Biblioteca.Classes.Funcionario.Funcionario;
using Biblioteca.Classes.Cliente.Cliente;

namespace Biblioteca.Classes.Emprestimo.Emprestimo
{
    public class Emprestimo
    {
        private static int newID = 1;
        private int EmprestimoID { get; private set; }
        private DateTime DataEmprestimo { get; set; }
        private DateTime DataDevolucao { get; set; }
        private int LivroID { get; set; }
        private Livro Livro { get; set; }
        private int ClienteID { get; set; }
        private Cliente cliente { get; set; }
        private int? FuncionarioID { get; set; }
        private Funcionario Funcionario { get; set; }

        public Emprestimo(int emprestimoID, DateTime dataEmprestimo, DateTime dataDevolucao, Livro livro, Cliente cliente, Funcionario funcionario = null)
        {
            this.EmprestimoID = newID++;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucao = dataDevolucao;
            this.Livro = livro;
            this.LivroID = livro.LivroID;
            this.Cliente = cliente;
            this.ClienteID = cliente.ClienteID;
            this.Funcionario = funcionario;
            this.FuncionarioID = funcionario?.FuncionarioID;
        }
    }
}
