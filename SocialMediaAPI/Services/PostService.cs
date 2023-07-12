using Dapper.Contrib.Extensions;
using SocialMediaAPI.Contracts.Post.Request;
using SocialMediaAPI.Contracts.Post.Response;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services.Interfaces;

namespace SocialMediaAPI.Services
{
    public class PostService : BaseService, IPostService
    {
        public long CreatePost(PostCreateRequest post)
        {
            Post newPost = new Post(post.Titulo, post.Descricao, post.DataPost, post.idPerfil);

            return _connection.Insert<Post>(newPost);
        }

        public void DeletePost(long id)
        {
            Post post = _connection.Get<Post>(id);

            _connection.Delete<Post>(post); 
        }

        public List<PostResponse> GetAllPosts()
        {
            List<PostResponse> postResponses = new List<PostResponse>();
            IEnumerable<Post> posts = _connection.GetAll<Post>();

            foreach (var post in posts)
            {
                postResponses.Add(new PostResponse(post.Titulo, post.Descricao, post.DataP));
            }

            return postResponses;
        }

        public PostResponse GetPost(int id)
        {
            Post post = _connection.Get<Post>(id);

            PostResponse response = new PostResponse(post.Titulo, post.Descricao, post.DataP);

            return response;
        }

        public PostUpdatedResponse UpdatePost(long postId, PostUpdateDataRequest updatedPost)
        {
            Post post = _connection.Get<Post>(postId) ?? throw new Exception($"O usuario de id {postId}, não existe.");

            if (updatedPost.Titulo != null)
                post.Titulo = updatedPost.Titulo;

            if (updatedPost.Descricao != null)
                post.Descricao = updatedPost.Descricao;

            bool postUpdated = _connection.Update<Post>(post);

            var response = new PostUpdatedResponse(post.Id, post.Titulo, post.Descricao, postUpdated, DateTime.Now);

            return response;
        }
    }
}
