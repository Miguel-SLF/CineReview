namespace CineReview.Models
{
    public class Avaliacao
    {
        public Guid Id { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public Guid UsuarioId { get; } //foreign key

        //Notas de Narrativa (0-10)
        public double NotaTrama { get; set; }
        public double NotaRitmo { get; set; }
        public double NotaDevPersonagens { get; set; }
        public double NotaConstrucaoMundo { get; set; }
        public double NotaTematica { get; set; }

        //Notas de Execução (0-10)
        public double NotaAtuacao { get; set; }
        public double NotaEdicao { get; set; }
        public double NotaDirecao { get; set; }

        //Notas Visuais (0-10)
        public double NotaArte { get; set; }
        public double NotaCinematografia { get; set; }
        public double NotaCenarios { get; set; }
        public double NotaFigurinos { get; set; }
        public double NotaEfeitosVisuais { get; set; }
        public double NotaQualidadeImagem { get; set; }

        //Notas Auditivas (0-10)
        public double NotaScore { get; set; }
        public double NotaEfeitosSonoros { get; set; }

        //Métodos
        /*public double GetMediaNarrativa()
        {

        }
        public double GetMediaExecucao()
        {

        }
        public double GetMediaVisual()
        {

        }
        public double GetMediaAuditiva()
        {

        }
        public double GetMediaGeral()
        {

        }*/

    }
}
