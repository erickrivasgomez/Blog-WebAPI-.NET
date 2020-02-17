namespace Blog.Models
{
    public class Post : Model
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        
        public string PublishedAt { get; set; }
        
        public int UserId { get; set; }
    }
}
