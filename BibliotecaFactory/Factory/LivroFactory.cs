using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class LivroFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int anoPublicacao = int.Parse(Console.ReadLine() ?? "0");
            string status = "Disponível";

            Livros livro = new Livros(titulo, autor, anoPublicacao, status, biblioteca);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }
    }
}
