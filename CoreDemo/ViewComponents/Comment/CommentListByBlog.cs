using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		ICommentService _commentService;

		public CommentListByBlog(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IViewComponentResult Invoke(int blogId)
		{
			var values = _commentService.GetCommentsByBlogId(blogId);
			return View(values);
		}	
	}
}
