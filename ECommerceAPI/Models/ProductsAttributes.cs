using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models
{
    public partial class ProductsAttributes
    {
        public Guid Id { get; set; }
        public Guid? Productsid { get; set; }
        public Guid? Optionsid { get; set; }
        public Guid? Optionvaluesid { get; set; }
        public decimal Price { get; set; }
        public string PricePrefix { get; set; }

        public virtual ProductsOptions Options { get; set; }
        public virtual ProductsOptionsValues Optionvalues { get; set; }
        public virtual Products Products { get; set; }
    }
}
