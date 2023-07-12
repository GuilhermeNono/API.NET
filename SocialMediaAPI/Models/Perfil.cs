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

        public Perfil(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public Perfil()
        {
            
        }

        //public ICollection<Post> Posts { get; set; }
        //public ICollection<Reacao> Reacoes { get; set; }
        //public ICollection<Comentario> Comentarios { get; set; }

    }
}
