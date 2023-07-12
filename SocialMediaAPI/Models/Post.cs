using Dapper.Contrib.Extensions;


namespace SocialMediaAPI.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataP { get; set; }
        public Perfil Perfil { get; set; }
        //public ICollection<Reacao> Reacoes { get; set; }
        //public ICollection<Link> Links { get; set; }
        //public ICollection<Comentario> Comentarios { get; set; }
    }
}
