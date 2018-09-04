using Houseware.Data.Interface;
using Houseware.Data.Models;
using Houseware.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.Data.Repository
{
    public class ItemRepository : IItemsRepository
    {
        private readonly AppDbContext _appDbContext;
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<SSItem> Item => _appDbContext.Item.Include(c => c.Category);

        public IEnumerable<SSItem> PreferredItem => _appDbContext.Item.Where(p => p.IsPreferred).Include(c => c.Category);

      
       

        public SSItem GetItemById(int ItemId) => _appDbContext.Item.FirstOrDefault(p => p.ItemId == ItemId);


    }
}
