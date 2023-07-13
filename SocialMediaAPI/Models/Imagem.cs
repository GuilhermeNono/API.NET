using Dapper.Contrib.Extensions;

namespace SocialMediaAPI.Models
{
    [Table("Imagem")]
    public class Imagem
    {
        [Key] public long Id { get; private set; }
        public string Caminho { get; set; }
        public long IdPost { get; set; }

        public Imagem(string caminhos, long idPost)
        {
            Caminho = caminhos;
            IdPost = idPost;
        }

        public Imagem()
        {
            
        }
    }
}
