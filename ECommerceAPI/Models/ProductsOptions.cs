using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models
{
    public partial class ProductsOptions
    {
        public ProductsOptions()
        {
            CartAttributes = new HashSet<CartAttributes>();
            ProductsAttributes = new HashSet<ProductsAttributes>();
            ProductsOptionsValuesMappings = new HashSet<ProductsOptionsValuesMappings>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CartAttributes> CartAttributes { get; set; }
        public virtual ICollection<ProductsAttributes> ProductsAttributes { get; set; }
        public virtual ICollection<ProductsOptionsValuesMappings> ProductsOptionsValuesMappings { get; set; }
    }
}
