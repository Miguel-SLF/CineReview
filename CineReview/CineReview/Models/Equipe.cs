namespace CineReview.Models
{
    public abstract class Equipe
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public List<string> Funcoes { get; set; }
    }
}
