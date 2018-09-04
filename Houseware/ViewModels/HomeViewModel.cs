using Houseware.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<SSItem> PreferredItems { get; set; }
    }
}
