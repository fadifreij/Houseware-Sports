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
    public class ItemDataController : Controller
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemDataController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet]
        public IEnumerable<ItemViewModel> LoadMoreDrinks()
        {
            IEnumerable<SSItem> dbItems = null;

            dbItems = _itemsRepository.Item.OrderBy(p => p.ItemId).Take(10);

            List<ItemViewModel> drinks = new List<ItemViewModel>();

            foreach (var dbItem in dbItems)
            {
                drinks.Add(MapDbDrinkToDrinkViewModel(dbItem));
            }
            return drinks;
        }

        private ItemViewModel MapDbDrinkToDrinkViewModel(SSItem dbItem) => new ItemViewModel()
        {
            ItemId = dbItem.ItemId,
            Name = dbItem.Name,
            Price = dbItem.Price,
            ShortDescription = dbItem.ShortDescription,
            ImageThumbnailUrl = dbItem.ImageThumbnailUrl
        };
    }
}