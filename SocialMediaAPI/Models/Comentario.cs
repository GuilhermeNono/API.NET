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

        public Perfil Perfil { get; set; }

        public Post Post { get; set; }
    }
}
