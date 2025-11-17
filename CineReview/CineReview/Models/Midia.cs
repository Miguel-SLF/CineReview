namespace CineReview.Models
{
    public abstract class Midia
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public TimeSpan Duracao { get; set; }
        public string ClassificacaoIndicativa { get; set; }
        public DateOnly DataLancamento { get; set; }
        public abstract double NotaMediaGeral { get; }
        public abstract double NotaMediaNarrativa { get; }
        public abstract double NotaMediaExecucao { get; }
        public abstract double NotaMediaVisual { get; }
        public abstract double NotaMediaAuditiva { get; }

        //Construtor ???
        public Midia(string titulo, string genero, string sinopse, TimeSpan duracao, string classificacaoIndicativa, DateOnly dataLancamento) 
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Genero = genero;
            Sinopse = sinopse;
            Duracao = duracao;
            ClassificacaoIndicativa = classificacaoIndicativa;
            DataLancamento = dataLancamento;
        }
    }
}
