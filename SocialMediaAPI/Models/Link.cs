using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Link")]
    public class Link
    {
        [Key] public string Id { get; set; }
        public string Texto { get; set; }
        public long IdPost { get; set; }
    }
}
