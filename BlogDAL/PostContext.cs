using BlogDAL.Entities;
using BlogDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class PostContext : DbContext
    {

        public PostContext() : base(@"Data Source=.\MSSQLSERVER1;Initial Catalog=BlogDataD;Integrated Security=True") 
        {
            //Database.SetInitializer<PostContext>(new BlogInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
               .HasMany(p => p.Posts)
               .WithRequired(p => p.User);

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Posts)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<Tag>()
                .HasMany(x => x.Posts);

        }

    }

}
