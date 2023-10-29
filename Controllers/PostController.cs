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
        public IActionResult Index()
        {
			var posts = blogDbContext.Posts;
            return View(posts);
        }

        [HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(Post post)
		{
			if (ModelState.IsValid)
			{
				TempData["status"] = "New Post added!";
                post.Date = DateTime.Now;
                await blogDbContext.Posts.AddAsync(post);
                await blogDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
			return View(post);
		}
	}
}
