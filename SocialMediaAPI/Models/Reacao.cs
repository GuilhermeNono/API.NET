using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Reacao")]
    public class Reacao
    {
        [Key]
        public int Id { get; set; }
        public string Reacoes { get; set; }
        public long IdPerfil { get; set; }
        public long IdPost { get; set; }
    }
}
