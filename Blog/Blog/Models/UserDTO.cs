using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class UserDTO
    {
        public bool Error { get; set; }

        public string Message { get; set; }

        public List<User> Content { get; set; }

#nullable enable
        public UserDTO(bool error, string message, List<User> content)
        {
            this.Error = error;
            this.Message = message;
            this.Content = content;
        }
#nullable disable
    }
}
