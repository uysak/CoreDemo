using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.ViewComponents.CategoryList
{
	public class CategoryList : ViewComponent
	{
		private ICategoryService _categoryService;

		public CategoryList(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IViewComponentResult Invoke()
		{
			var categories = _categoryService.GetList();
			return View(categories);
		}
	}
}
