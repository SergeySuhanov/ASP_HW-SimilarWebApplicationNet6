using Microsoft.EntityFrameworkCore;

namespace ASP_HW_SimilarWebApplicationNet6.Models
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Post> Posts { get; set; }
	}
}
