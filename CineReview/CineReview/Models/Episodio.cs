namespace CineReview.Models
{
    public class Episodio
    {
        public Guid Id { get; set; }
        public int NumeroEpisodio { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public TimeSpan Duracao { get; set; }

        public Episodio(int numeroEpisodio, TimeSpan duracao)
        {
            Id = Guid.NewGuid();
            NumeroEpisodio = numeroEpisodio;
            Duracao = duracao;
        }

        public Episodio(int numeroEpisodio, string titulo, string sinopse, TimeSpan duracao) 
        {
            Id= Guid.NewGuid();
            NumeroEpisodio= numeroEpisodio;
            Titulo = titulo;
            Sinopse = sinopse;
            Duracao = duracao;
        }
    }
}
