namespace CineReview.Models
{
    public class Temporada : IAvaliavel
    {
        //Propriedades próprias:
        public Guid Id { get; set; }
        public int NumeroTemporada { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string ClassificacaoIndicativa { get; set; }
        public DateOnly DataLancamento { get; set; }
        public List<Episodio> Episodios { get; private set; }
        public List<Equipe> Equipe { get; private set; }

        //Propriedade de interface:
        public List<Avaliacao> Avaliacoes { get; private set; }
        public double NotaMediaGeral { get; }
        public double NotaMediaNarrativa { get; }
        public double NotaMediaExecucao { get; }
        public double NotaMediaVisual { get; }
        public double NotaMediaAuditiva { get; }

        //Construtor
        public Temporada(int numeroTemporada, string titulo, string sinopse, string classificacaoIndicativa, DateOnly dataLancamento)
        {
            Id = Guid.NewGuid();
            NumeroTemporada = numeroTemporada;
            Titulo = titulo;
            Sinopse = sinopse;
            ClassificacaoIndicativa = classificacaoIndicativa;
            DataLancamento = dataLancamento;
            Episodios = new List<Episodio>();
            Equipe = new List<Equipe>();
            Avaliacoes = new List<Avaliacao>();
        }

        //Método da interface
        public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
            if (avaliacao != null)
            {
                this.Avaliacoes.Add(avaliacao);
            }
        }

    }
}
