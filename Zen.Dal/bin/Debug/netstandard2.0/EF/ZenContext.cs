using Microsoft.EntityFrameworkCore;


namespace Zen.Dal.EF
{
    public class ZenContext : DbContext
    {

        protected override OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSql("");

        public DbSet<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }
}