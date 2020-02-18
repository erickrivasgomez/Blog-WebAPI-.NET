using Blog.Models;
using Blog.Repositories;

namespace Blog.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public UserDTO AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public UserDTO EditUser(int id, User user)
        {
            return _userRepository.EditUser(id, user);
        }

        public UserDTO DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }
    }
}
