
namespace CineReview.Models
{
    public class Filme : Midia, IAvaliavel
    {

        //Implementação da classe pai:
        public override double NotaMediaGeral { get; }
        public override double NotaMediaNarrativa { get; }
        public override double NotaMediaExecucao { get; }
        public override double NotaMediaVisual { get; }
        public override double NotaMediaAuditiva { get; }

        //Implementação da interface:
        public List<Avaliacao> Avaliacoes { get; private set; }

        //Construtor
        public Filme(string titulo, string genero, string sinopse, TimeSpan duracao, string classificacaoIndicativa, DateOnly dataLancamento) : base(titulo, genero, sinopse, duracao, classificacaoIndicativa, dataLancamento)
        {
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
