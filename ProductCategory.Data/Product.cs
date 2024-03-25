using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Data
{
    public class Product
    {
        public string? Name { get; set; }
        public List<string> Categories { get; set; }
    }

}
