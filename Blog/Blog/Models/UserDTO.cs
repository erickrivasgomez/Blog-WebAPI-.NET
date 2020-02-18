using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class UserDTO
    {
        public bool Error { get; set; }

        public IEnumerable<string> Messages { get; set; }

        public IEnumerable<User> Content { get; set; }

        public UserDTO()
        {
            this.Messages = new List<string>();
            this.Content = new List<User>();
        }

        public UserDTO(bool error, List<string> messages, List<User> content)
        {
            this.Error = error;
            this.Messages = messages;
            this.Content = content;
        }
    }
}
