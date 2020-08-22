using BlogAboutIt.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogAboutIt
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public DbSet<Post> BlogPosts { get; set; }
    }
}
