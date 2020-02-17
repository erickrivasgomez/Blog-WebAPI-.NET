using Blog.Models;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository blogRepository)
        {
            _userRepository = blogRepository;
        }

        public DTO GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
