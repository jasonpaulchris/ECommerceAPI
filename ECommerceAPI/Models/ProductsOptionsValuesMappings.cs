using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models
{
    public partial class ProductsOptionsValuesMappings
    {
        public Guid Id { get; set; }
        public Guid? Optionsid { get; set; }
        public Guid? Valuesid { get; set; }

        public virtual ProductsOptions Options { get; set; }
        public virtual ProductsOptionsValues Values { get; set; }
    }
}
