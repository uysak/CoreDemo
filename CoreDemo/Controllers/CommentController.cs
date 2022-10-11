using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class CommentController : Controller
	{
		private ICommentService _commentService;

		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var comments = _commentService.GetCommentsByBlogId(id);
            return PartialView(comments);
		}
	}
}
