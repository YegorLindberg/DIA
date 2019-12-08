namespace WebApplication.Model
{
    public class Comment
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int postId { get; set; }
        public string text { get; set; }
    }
}