using ASP_HW_SimilarWebApplicationNet6.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW_SimilarWebApplicationNet6.Controllers
{
	public class PostController : Controller
	{
		private readonly BlogDbContext blogDbContext;

		public PostController(BlogDbContext blogDbContext)
        {
			this.blogDbContext = blogDbContext;
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(Post post)
		{
			post.Date = DateTime.Now;
			blogDbContext.Posts.Add(post);
			blogDbContext.SaveChanges();
			return RedirectToAction("Add");
		}
	}
}
