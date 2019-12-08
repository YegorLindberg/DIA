namespace WebApplication.Model
{
    public class Like
    {
        public int id { get; set; } //primary key
        public int userId { get; set; }
        public int postId { get; set; }
    }
}