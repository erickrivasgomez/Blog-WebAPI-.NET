using Blog.Models;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class UserRepository
    {
        public List<User> Users = new List<User>()
        {
            new User{ Id = 1, Name = "Us1", Email = "us1@blog.com", Password = "us1" },
            new User{ Id = 2, Name = "Us2", Email = "us2@blog.com", Password = "us2" },
            new User{ Id = 3, Name = "Us3", Email = "us3@blog.com", Password = "us3" },
            new User{ Id = 4, Name = "Us4", Email = "us4@blog.com", Password = "us4" },
            new User{ Id = 5, Name = "Us5", Email = "us5@blog.com", Password = "us5" }
        };

        public UserDTO GetUsers()
        {
            return new UserDTO
                (
                error: false,
                messages: new List<string>() { "Users" },
                content: Users
                );
        }

        public UserDTO AddUser(User newUser)
        {
            UserDTO response = new UserDTO();

            if (Users.Exists(user => user.Id == newUser.Id))
            {
                response.Error = true;
                response.Messages.Add("Id in use.");
                if (Users.Exists(user => user.Email == newUser.Email))
                {
                    response.Messages.Add("Email already taken.");
                }
            }
            else
            {
                response.Error = false;
                response.Messages.Add("User added successfully");
            }

            return response;
        }

    }
}
