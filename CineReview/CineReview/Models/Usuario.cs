namespace CineReview.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        private string SenhaHash { get; set; }
        public List<Avaliacao> Avaliacoes { get; private set; }
        public List<Midia> Favoritos { get; private set; }

        //Construtor
        public Usuario(string nomeUsuario, string email, string senhaHash)
        {
            Id = Guid.NewGuid();
            NomeUsuario = nomeUsuario;
            Email = email;
            SenhaHash = senhaHash;
            Avaliacoes = new List<Avaliacao>();
            Favoritos = new List<Midia>();
        }

        //Métodos
        /*public bool ValidarSenha(string senha)
        {
            if (senha == null)
                throw new ArgumentNullException($"O de senha não pode ser vazio");
        }

        public void DefinirSenha(string novaSenha)
        {
        }

        public void FavoritarMidia(Midia midia)
        {
        }

        public void RemoverFavorito(Guid midiaId)
        {
        }*/
    }
}
