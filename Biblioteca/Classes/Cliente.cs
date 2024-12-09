using System;
using System.Collections.Generic;
using Biblioteca.Classes.EmprestimoNamespace;
using Biblioteca.Classes.NotificacaoNamespace;
using Biblioteca.Classes.BibliotecaNamespace;
using Biblioteca.Classes.LivroNamespace;
using Biblioteca.Classes.FuncionarioNamespace;

namespace Biblioteca.Classes.ClienteNamespace
{
    public class Cliente
    {
        private static int newID = 1;
        public int ClienteID { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public List<Emprestimo> Emprestimos { get; private set; }
        public List<Notificacao> Notificacoes { get; private set; }

        public Cliente(string nome, string cpf, string endereco, string telefone)
        {
            ClienteID = newID++;
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Emprestimos = new List<Emprestimo>();
            Notificacoes = new List<Notificacao>();
        }

        public void RealizarEmprestimo(Livro livro, Funcionario funcionario)
        {
            if (livro.EstaDisponivel())
            {
                Emprestimo emprestimo = new Emprestimo(livro, this, DateTime.Now, DateTime.Now.AddDays(14));
                Emprestimos.Add(emprestimo);
                livro.AtualizarStatus("Emprestado");
                Console.WriteLine($"Empréstimo realizado: {livro.Titulo} para {Nome}.");
            }
            else
            {
                Console.WriteLine("Livro não disponível para empréstimo.");
            }
        }

        public void ReceberNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
    }
}