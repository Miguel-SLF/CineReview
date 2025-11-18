namespace CineReview.Models
{
    public class Avaliacao
    {
        public Guid Id { get; private set; }
        public DateTime DataAvaliacao { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

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

        //Construtor
        public Avaliacao(Usuario usuario,
            double notaTrama, double notaRitmo, double notaDevPersonagens, double notaConstrucaoMundo, double notaTematica,
            double notaAtuacao, double notaEdicao, double notaDirecao,
            double notaArte, double notaCinematografia, double notaCenarios, double notaFigurinos, double notaEfeitosVisuais, double notaQualidadeImagem,
            double notaScore, double notaEfeitosSonoros)
        {
            Id = Guid.NewGuid();
            DataAvaliacao = DateTime.UtcNow; // Define a data de agora

            // Vincula o usuário
            Usuario = usuario;
            UsuarioId = usuario.Id;

            NotaTrama = notaTrama;
            NotaRitmo = notaRitmo;
            NotaDevPersonagens = notaDevPersonagens;
            NotaConstrucaoMundo = notaConstrucaoMundo;
            NotaTematica = notaTematica;
            NotaAtuacao = notaAtuacao;
            NotaEdicao = notaEdicao;
            NotaDirecao = notaDirecao;
            NotaArte = notaArte;
            NotaCinematografia = notaCinematografia;
            NotaCenarios = notaCenarios;
            NotaFigurinos = notaFigurinos;
            NotaEfeitosVisuais = notaEfeitosVisuais;
            NotaQualidadeImagem = notaQualidadeImagem;
            NotaScore = notaScore;
            NotaEfeitosSonoros = notaEfeitosSonoros;
        }

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
