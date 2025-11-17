namespace CineReview.Models
{
    public interface IAvaliavel
    {
        //Por que as propriedades são abstratas? Não são apenas métodos que fariam isso?
        public List<Avaliacao> Avaliacoes { get; set; }
        abstract double NotaMediaGeral { get; }
        abstract double NotaMediaNarrativa { get; }
        abstract double NotaMediaExecucao { get; }
        abstract double NotaMediaVisual { get; }
        abstract double NotaMediaAuditiva { get; }

        //Construtor???

        //Métodos
        /*public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
        }*/
    }
}
