using Blog.Models;
using Blog.Repositories;

namespace Blog.Services
{
    public class PostService
    {
        private PostRepository _postRepository;

        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public PostDTO GetPosts()
        {
            return _postRepository.GetPosts();
        }

        public PostDTO AddPost(Post post)
        {
            return _postRepository.AddPost(post);
        }

        public PostDTO EditPost(int id, Post post)
        {
            return _postRepository.EditPost(id, post);
        }

        public PostDTO DeletePost(int id)
        {
            return _postRepository.DeletePost(id);
        }
    }
}
