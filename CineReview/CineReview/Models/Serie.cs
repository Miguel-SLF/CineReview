
namespace CineReview.Models
{
    public class Serie : Midia
    {
        public override double NotaMediaGeral { get; }

        public override double NotaMediaNarrativa { get; }

        public override double NotaMediaExecucao { get; }

        public override double NotaMediaVisual { get; }

        public override double NotaMediaAuditiva { get; }

        //Construtor
        public Serie(string titulo, string genero, string sinopse, TimeSpan duracao, string classificacaoIndicativa, DateOnly dataLancamento) : base(titulo, genero, sinopse, duracao, classificacaoIndicativa, dataLancamento)
        {
        }
    }
}
