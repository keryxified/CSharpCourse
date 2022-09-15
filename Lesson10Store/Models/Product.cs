using System;
using System.Collections.Generic;

namespace Lesson10Store.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public int Ean { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public Guid ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; } = null!;
    }
}
