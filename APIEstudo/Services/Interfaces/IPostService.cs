using SocialMediaAPI.Contracts.Post.Request;
using SocialMediaAPI.Contracts.Post.Response;

namespace SocialMediaAPI.Services.Interfaces
{
    public interface IPostService
    {
        List<PostResponse> GetAllPosts();
        PostResponse GetPost(long id);
        void DeletePost(long id);
        long CreatePost(PostCreateRequest post);
        PostUpdatedResponse UpdatePost(long perfilId, PostUpdateDataRequest updatedPost);
    }
}
