using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; } // objeto
        public IEnumerable <ProductCategory> ProductCategories { get; set; }
        //lista que podemos iterar a través de nuestra product category

    }
}
