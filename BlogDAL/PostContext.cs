﻿using BlogDAL.Entities;
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
        static PostContext()
        {
            Database.SetInitializer<PostContext>(new BlogInitializer());
        }
        public PostContext() : base(@"Data Source=.\MSSQLSERVER1;Initial Catalog=BlogDB;Integrated Security=True") 
        {

        }

        public DbSet<Category> Categories { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

    }

}
