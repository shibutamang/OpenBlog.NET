
using System.Data.Entity;

namespace OpenBlog.Model
{
    public class OpenBlogContext : DbContext
    {
        public OpenBlogContext() : base("OpenBlog")
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
