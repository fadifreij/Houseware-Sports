using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Houseware.Data.Interface;
using Houseware.Data.Models;
using Houseware.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Houseware.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemsRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemsRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<SSItem> Items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                Items = _itemRepository.Item.OrderBy(p => p.ItemId);
                currentCategory = "All Items";
            }
            else
            {
                if (string.Equals("Houseware Items", _category, StringComparison.OrdinalIgnoreCase))
                    Items = _itemRepository.Item.Where(p => p.Category.CategoryName.Equals("Houseware Items")).OrderBy(p => p.Name);
                else
                    Items = _itemRepository.Item.Where(p => p.Category.CategoryName.Equals("Sports Items")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new ItemsListViewModel
            {
                Items = Items,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<SSItem> Items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                Items = _itemRepository.Item.OrderBy(p => p.ItemId);
            }
            else
            {
               Items = _itemRepository.Item.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Item/List.cshtml", new ItemsListViewModel { Items = Items, CurrentCategory = "All Items" });
        }

        public ViewResult Details(int ItemId)
        {
            var Item = _itemRepository.Item.FirstOrDefault(d => d.ItemId == ItemId);
            if (Item == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(Item);
        }
    }
}