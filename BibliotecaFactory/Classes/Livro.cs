namespace Biblioteca.Classes
{
    public class Livros
    {
        private static int newID = 1;
        public int LivroID { get; private set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Status { get; set; }
        public int BibliotecaID { get; set; }
        public Bibliotecas Biblioteca { get; set; }
        public List<Emprestimos> Emprestimos { get; set; }

        public Livros(string titulo, string autor, int anoPublicacao, string status, Bibliotecas biblioteca)
        {
            LivroID = newID++;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Status = status;
            Biblioteca = biblioteca;
            BibliotecaID = biblioteca.BibliotecaID;
            Emprestimos = new List<Emprestimos>();
        }

        public void AtualizarStatus(string novoStatus)
        {
            Status = novoStatus;
        }

        public bool EstaDisponivel()
        {
            return Status.Equals("Disponível", StringComparison.OrdinalIgnoreCase);
        }
    }
}
