using System;
using BibliotecaSystem; // Atualizado
using Biblioteca.Classes.FuncionarioNamespace;

namespace Biblioteca.Factory
{
    public class FuncionarioFactory : IEntidadeFactory
    {
        public void CriarEntidade(Biblioteca biblioteca)
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do funcionário: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o cargo do funcionário: ");
            string cargo = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            decimal salario = decimal.Parse(Console.ReadLine() ?? "0");

            Funcionario funcionario = new Funcionario(nome, cpf, cargo, salario);
            biblioteca.AdicionarFuncionario(funcionario);
            Console.WriteLine("Funcionário adicionado com sucesso!");
        }
    }
}