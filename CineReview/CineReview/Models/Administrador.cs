namespace CineReview.Models
{
    public class Administrador : Usuario
    {
        public Administrador(string nomeUsuario, string email, string senhaHash) : base(nomeUsuario, email, senhaHash)
        {
        }

        //Métodos
        /*public bool CadastrarMidia(Midia midia)
        {
        }

        public bool EditarMidia(Midia midia)
        {
        }

        public bool RemoverMidia(Guid midiaId)
        {
        }*/
    }
}
