namespace Blog.Models
{
    public class Post
    {
        public int id { get; set; }

        public string title { get; set; }

        public string content { get; set; }
        
        public string publishedat { get; set; }
        
        public int userid { get; set; }
    }
}
