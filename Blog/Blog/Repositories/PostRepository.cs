using Blog.Models;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class PostRepository
    {
        public List<Model> Posts = new List<Model>()
        {
            new Post{ Id = 1, Title = "Post1", Content = "Post 1 content", PublishedAt = "01/01/2020", UserId = 1 },
            new Post{ Id = 2, Title = "Post2", Content = "Post 2 content", PublishedAt = "02/01/2020", UserId = 2 },
            new Post{ Id = 3, Title = "Post3", Content = "Post 3 content", PublishedAt = "03/01/2020", UserId = 3 },
            new Post{ Id = 4, Title = "Post4", Content = "Post 4 content", PublishedAt = "04/01/2020", UserId = 4 },
            new Post{ Id = 5, Title = "Post5", Content = "Post 5 content", PublishedAt = "05/01/2020", UserId = 5 },
        };

        public DTO GetPosts()
        {
            return new DTO(error: false, message: "Posts obtained successfully", content: Posts);
        }
    }
}
