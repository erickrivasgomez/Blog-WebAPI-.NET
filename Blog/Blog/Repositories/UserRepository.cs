using Blog.Models;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class UserRepository
    {
        public List<Model> Users = new List<Model>()
        {
            new User{ Id = 1, Name = "Us1", Email = "us1@blog.com", Password = "us1" },
            new User{ Id = 2, Name = "Us2", Email = "us2@blog.com", Password = "us2" },
            new User{ Id = 3, Name = "Us3", Email = "us3@blog.com", Password = "us3" },
            new User{ Id = 4, Name = "Us4", Email = "us4@blog.com", Password = "us4" },
            new User{ Id = 5, Name = "Us5", Email = "us5@blog.com", Password = "us5" }
        };

        public DTO GetUsers()
        {
            return new DTO(error: false, message: "Users obtained successfully", content: Users);
        }
    }
}
