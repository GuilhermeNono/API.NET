using Dapper.Contrib.Extensions;


namespace SocialMediaAPI.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; private set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataP { get; set; }
        public long IdPerfil { get; set; }

        public Post(string titulo, string descricao, DateTime dataP, long idPerfil)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataP = dataP;
            IdPerfil = idPerfil;
        }

        public Post()
        {

        }


        //public ICollection<Reacao> Reacoes { get; set; }
        //public ICollection<Link> Links { get; set; }
        //public ICollection<Comentario> Comentarios { get; set; }
    }
}
