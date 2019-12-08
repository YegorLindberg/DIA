namespace WebApplication.Model
{
    public class User
    {
        public int id { get; set; } // key
        public int roleId { get; set; }
        public string fullName { get; set; }
        public string avatarUri { get; set; }
        public string description { get; set; }
        
        public string email { get; set; }
        public string password { get; set; }
    }
}