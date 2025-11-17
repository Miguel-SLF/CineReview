namespace CineReview.Models
{
    public class Temporada : IAvaliavel
    {
        //Propriedades próprias:
        public Guid Id { get; set; }
        public int NumeroTemporada { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }

        //Propriedade de interface:
        public List<Avaliacao> Avaliacoes { get; private set; }
        public double NotaMediaGeral { get; }
        public double NotaMediaNarrativa { get; }
        public double NotaMediaExecucao { get; }
        public double NotaMediaVisual { get; }
        public double NotaMediaAuditiva { get; }

        //Construtor
        public Temporada(int numeroTemporada, string titulo, string sinopse)
        {
            Id = Guid.NewGuid();
            NumeroTemporada = numeroTemporada;
            Titulo = titulo;
            Sinopse = sinopse;
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
