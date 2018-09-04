using Houseware.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.Data.Interface
{
  public  interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
