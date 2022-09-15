using System;
using System.Collections.Generic;

namespace Lesson10Store.Models
{
    public partial class ProductProperty
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; } = null!;
        public short ValueType { get; set; }
        public bool IsActive { get; set; }
    }
}
