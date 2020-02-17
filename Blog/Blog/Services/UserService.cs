﻿using Blog.Models;
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
    }
}