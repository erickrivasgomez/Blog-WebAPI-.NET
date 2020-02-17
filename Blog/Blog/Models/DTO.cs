using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class DTO
    {
        public bool Error { get; set; }

        public string Message { get; set; }

        public List<Model> Content { get; set; }

#nullable enable
        public DTO(bool error, string message, List<Model> content)
        {
            this.Error = error;
            this.Message = message;
            this.Content = content;
        }
#nullable disable
    }
}
