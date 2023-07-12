using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Reacao")]
    public class Reacao
    {
        [Key]
        public int Id { get; set; }
        public string Reacoes { get; set; }
        public Perfil Perfil { get; set; }
        public Post Post { get; set; }
    }
}
