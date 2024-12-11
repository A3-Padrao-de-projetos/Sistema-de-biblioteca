using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class FuncionarioFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do funcionário: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o cargo do funcionário: ");
            string cargo = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            decimal salario = decimal.Parse(Console.ReadLine() ?? "0");

            Funcionarios funcionario = new Funcionarios(nome, cpf, cargo, salario, biblioteca);
            biblioteca.AdicionarFuncionario(funcionario);
            Console.WriteLine("Funcionário adicionado com sucesso!");
        }
    }
}
