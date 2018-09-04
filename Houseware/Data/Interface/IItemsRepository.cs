using Houseware.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.Data.Interface
{
    public interface IItemsRepository
    {
        IEnumerable<SSItem> Item { get; }
        IEnumerable<SSItem> PreferredItem { get; }
        SSItem GetItemById(int ItemId);
    }
}
