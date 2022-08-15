using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Store
{
    internal class Equipment : StoreItem
    {
        public Equipment(string name, string id, string isbn, decimal price) : base(name, id, isbn, price)
        {
        }
    }
}
