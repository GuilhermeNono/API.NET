using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Reacao")]
    public class Reacao
    {
        [Key]
        public int Id { get; private set; }
        public string Reacoes { get; set; }
        public long IdPerfil { get; set; }
        public long IdPost { get; set; }

        public Reacao(string reacoes, long idPerfil, long idPost)
        {
            Reacoes = reacoes;
            IdPerfil = idPerfil;
            IdPost = idPost;
        }

        public Reacao()
        {

        }
    }
}
