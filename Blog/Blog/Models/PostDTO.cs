using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostDTO
    {
        public bool Error { get; set; }

        public IEnumerable<string> Messages { get; set; }

        public IEnumerable<Post> Content { get; set; }

        public PostDTO()
        {
            this.Messages = new List<string>();
            this.Content = new List<Post>();
        }

        public PostDTO(bool error, List<string> messages, List<Post> content)
        {
            this.Error = error;
            this.Messages = messages;
            this.Content = content;
        }
    }
}
