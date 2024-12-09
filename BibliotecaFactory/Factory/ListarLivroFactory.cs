using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class ListarLivroFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Livros na Biblioteca ===");

            if (biblioteca.Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro disponível.");
                return;
            }

            foreach (var livro in biblioteca.Livros)
            {
                Console.WriteLine($"ID: {livro.LivroID}\nTítulo: {livro.Titulo}\nAutor: {livro.Autor}\nAno de publicação: {livro.AnoPublicacao} \nStatus: {livro.Status}\n");
            }
        }
    }
}
