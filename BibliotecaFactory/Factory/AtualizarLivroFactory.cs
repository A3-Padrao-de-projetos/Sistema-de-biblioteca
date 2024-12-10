using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class AtualizarLivroFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Atualizar Informações do Livro ===");

            Console.Write("Informe o ID do livro que deseja atualizar: ");
            int livroID = int.Parse(Console.ReadLine());

            var livro = biblioteca.Livros.Find(l => l.LivroID == livroID);

            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return;
            }

            Console.WriteLine($"Atualizando o livro: {livro.Titulo}");
            Console.WriteLine("Deixe o campo vazio para manter as informações atuais.");

            Console.Write("Novo Título: ");
            string novoTitulo = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(novoTitulo))
                livro.Titulo = novoTitulo;

            Console.Write("Novo Autor: ");
            string novoAutor = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(novoAutor))
                livro.Autor = novoAutor;

            Console.Write("Novo Ano de Publicação: ");
            string novoAno = Console.ReadLine();
            if (int.TryParse(novoAno, out int anoPublicacao))
                livro.AnoPublicacao = anoPublicacao;

            Console.WriteLine("Informações atualizadas com sucesso!");
        }
    }
}
