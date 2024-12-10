using Biblioteca.Classes;

namespace Biblioteca.Factory
{
    public class RemoverLivroFactory : IEntidadeFactory
    {
        public void CriarEntidade(Bibliotecas biblioteca)
        {
            Console.WriteLine("=== Remover Livro ===");

            Console.Write("Informe o ID do livro que deseja remover: ");
            int livroID = int.Parse(Console.ReadLine());

            var livro = biblioteca.Livros.Find(l => l.LivroID == livroID);

            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return;
            }

            biblioteca.Livros.Remove(livro);
            Console.WriteLine($"Livro '{livro.Titulo}' removido com sucesso!");
        }
    }
}
