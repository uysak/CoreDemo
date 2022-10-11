using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            var blogs = _blogService.GetBlogListWithCategory();
            return View(blogs);
        }
        public IActionResult BlogReadAll(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }
    }
}
