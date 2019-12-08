using System;
using Microsoft.EntityFrameworkCore;
using WebApplication.Model;

namespace WebApplication.Connection
 {
     public class DataBase: DbContext
     {
         public DbSet<User> User { get; set; }
         public DbSet<Role> Role { get; set; }
         public DbSet<Like> Like { get; set; }
         public DbSet<Post> Post { get; set; }
         public DbSet<Comment> Comment { get; set; }

         public DataBase()
         {
             Database.EnsureCreated();
         }
         
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql(
                 Environment.GetEnvironmentVariable("DB_CONNECTOR_STRING") ??
                 throw new Exception("Env variable DB_CONNECTOR_STRING not found")
             );
     }
 }