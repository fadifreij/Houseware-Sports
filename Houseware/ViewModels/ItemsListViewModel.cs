using Houseware.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<SSItem> Items { get; set; }
        public string CurrentCategory { get; set; }
    }
}
