using Houseware.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.Components
{
    public class CategoryMenu :ViewComponent
    {
        private readonly ICategoryRepository _cateogryRepostory;
       
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _cateogryRepostory = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _cateogryRepostory.Categories.OrderBy(p => p.CategoryName);
            return View(categories);
        }
    }
}
