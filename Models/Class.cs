using System.ComponentModel.DataAnnotations;

namespace ASP_HW_SimilarWebApplicationNet6.Models
{
	public class Post
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Verni Title")]
		[MaxLength(50)]
		public string Title { get; set; }

		[Required(ErrorMessage = "Verni Content")]
		public string Content { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[Required(ErrorMessage = "Verni Cartinku")]
		[Display(Name = "Picture Url:")]
		public string ImageUrl { get; set; }

	}
}
