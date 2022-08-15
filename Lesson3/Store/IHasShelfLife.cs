using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Store
{
    internal interface IHasShelfLife
    {
        public DateTime ExpirationDate { get; set; }
    }
}
