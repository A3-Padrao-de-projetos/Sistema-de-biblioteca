using System;
using BibliotecaSystem; // Atualizado
using Biblioteca.Classes.LivroNamespace;
using Biblioteca.Classes.CategoriaLivrosNamespace;

namespace Biblioteca.Factory
{
    public class LivroFactory : IEntidadeFactory
    {
        public void CriarEntidade(Biblioteca biblioteca)
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int anoPublicacao = int.Parse(Console.ReadLine() ?? "0");
            string status = "Disponível";

            Livro livro = new Livro(titulo, autor, anoPublicacao, status, null);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }
    }
}