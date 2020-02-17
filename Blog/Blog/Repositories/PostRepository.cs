using Blog.Models;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Repositories
{
    public class PostRepository
    {
        public List<Post> Posts = new List<Post>()
        {
            new Post{ Id = 1, Title = "Post1", Content = "Post 1 content", PublishedAt = "01/01/2020", UserId = 1 },
            new Post{ Id = 2, Title = "Post2", Content = "Post 2 content", PublishedAt = "02/01/2020", UserId = 2 },
            new Post{ Id = 3, Title = "Post3", Content = "Post 3 content", PublishedAt = "03/01/2020", UserId = 3 },
            new Post{ Id = 4, Title = "Post4", Content = "Post 4 content", PublishedAt = "04/01/2020", UserId = 4 },
            new Post{ Id = 5, Title = "Post5", Content = "Post 5 content", PublishedAt = "05/01/2020", UserId = 5 },
        };

        public PostDTO GetPosts()
        {
            return new PostDTO
                (
                error: false,
                messages: new List<string>() { "Post list" },
                content: Posts
                );
        }

        public PostDTO AddPost(Post newPost)
        {
            PostDTO response = new PostDTO();

            Post post = Posts.FirstOrDefault(u => u.Id == newPost.Id);

            if (post == null)
            {
                Posts.Add(newPost);
                response.Error = false;
                response.Messages = new List<string>() { "Post added successfully!" };
            }
            else
            {
                response.Error = true;
                response.Messages = new List<string>() { "Error: Id already in use." };
            }

            return response;
        }

        public PostDTO EditPost(int id, Post newPost)
        {
            PostDTO response = new PostDTO();

            Post post = Posts.FirstOrDefault(u => u.Id == id);

            if (post != null)
            {
                Posts.Remove(post);
                Posts.Add(newPost);
                response.Error = false;
                response.Messages = new List<string>() { "Post updated successfully!" };
            }
            else
            {
                response.Error = true;
                response.Messages = new List<string>() { "Error: post not found" };
            }

            return response;
        }

        public PostDTO DeletePost(int id)
        {
            PostDTO response = new PostDTO();

            Post post = Posts.FirstOrDefault(u => u.Id == id);

            if (post != null)
            {
                Posts.Remove(post);
                response.Error = false;
                response.Messages = new List<string>() { "Post deleted successfully!" };
            }
            else
            {
                response.Error = true;
                response.Messages = new List<string>() { "Error: post not found" };
            }

            return response;
        }
    }
}
