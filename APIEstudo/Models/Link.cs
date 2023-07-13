using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Link")]
    public class Link
    {
        [Key] public long Id { get; private set; }
        public string Texto { get; set; }
        public long IdPost { get; set; }

        public Link(string texto, long idPost)
        {
            Texto = texto;
            IdPost = idPost;
        }

        public Link()
        {
            
        }
    }
}
