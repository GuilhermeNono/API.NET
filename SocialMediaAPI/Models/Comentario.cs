using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Comentario")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        public string Texto { get; set; }

        public DateTime DataC { get; set; }

        public long IdPerfil { get; set; }

        public long IdPost { get; set; }

        public Comentario(string texto, DateTime dataC, long idPerfil, long idPost)
        {
            Texto = texto;
            DataC = dataC;
            IdPerfil = idPerfil;
            IdPost = idPost;
        }

        public Comentario()
        {
            
        }
    }
}
