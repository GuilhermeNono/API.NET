using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("perfil")]
    public class Perfil
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        //public ICollection<Post> Posts { get; set; }
        //public ICollection<Reacao> Reacoes { get; set; }
        //public ICollection<Comentario> Comentarios { get; set; }

    }
}
