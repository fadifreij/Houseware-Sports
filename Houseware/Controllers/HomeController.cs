using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Houseware.Data.Interface;
using Houseware.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Houseware.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemsRepository _itemsRepository;
        public HomeController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredItems = _itemsRepository.PreferredItem
            };
            return View(homeViewModel);
        }
    }
}