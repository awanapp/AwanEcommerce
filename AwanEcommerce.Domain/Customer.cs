using AwanEcommerce.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwanEcommerce.Domain
{
    public class Customer: EntityBase
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNo { get; set; }
    }
}
