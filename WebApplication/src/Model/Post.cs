﻿namespace WebApplication.Model
{
    public class Post
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string imageUri { get; set; }
    }
}