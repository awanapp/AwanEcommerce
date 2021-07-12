using AwanEcommerce.Infrastructure;
using System;

namespace AwanEcommerce.Domain
{
    public class Product : EntityBase
    {
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
