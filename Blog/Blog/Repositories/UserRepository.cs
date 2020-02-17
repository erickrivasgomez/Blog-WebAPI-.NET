using Blog.Models;
using System.Collections.Generic;
using System.Linq;

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
                messages: new List<string>() { "User list" },
                content: Users
                );
        }

        public UserDTO AddUser(User newUser)
        {
            UserDTO response = new UserDTO();

            User user = Users.FirstOrDefault(u => u.Id == newUser.Id);

            if (user == null)
            {
                Users.Add(newUser);
                response.Error = false;
                response.Messages = new List<string>() { "User added successfully!" };
            }
            else
            {
                response.Error = true;
                response.Messages = new List<string>() { "Error: Id already in use." };
            }

            return response;
        }

        public UserDTO EditUser(int id, User newUser)
        {
            UserDTO response = new UserDTO();

            User user = Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                Users.Remove(user);
                Users.Add(newUser);
                response.Error = false;
                response.Messages = new List<string>() { "User updated successfully!" };
            }
            else
            {
                response.Error = true;
                response.Messages = new List<string>() { "Error: user not found" };
            }
            
            return response;
        }

        public UserDTO DeleteUser(int id)
        {
            UserDTO response = new UserDTO();

            User user = Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                Users.Remove(user);
                response.Error = false;
                response.Messages = new List<string>() { "User deleted successfully!" };
            }
            else
            {
                response.Error = true;
                response.Messages = new List<string>() { "Error: user not found" };
            }

            return response;
        }

    }
}
