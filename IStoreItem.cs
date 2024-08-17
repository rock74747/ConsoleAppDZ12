using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ12
{
    public interface IStoreItem
    {
       long ItemId { get; set; }
        double Price { get; set; }
    }
}
