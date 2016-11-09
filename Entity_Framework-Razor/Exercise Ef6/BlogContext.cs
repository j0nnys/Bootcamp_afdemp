using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_Ef6.Model;
using System.Data.Entity;


namespace Exercise_Ef6
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContextConStringName")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        //To access the fluent API you override the OnModelCreating method in DbContext
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {

        }
    }
}

