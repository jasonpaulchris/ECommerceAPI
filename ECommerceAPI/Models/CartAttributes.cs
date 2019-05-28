using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models
{
    public partial class CartAttributes
    {
        public Guid Id { get; set; }
        public Guid? Customerid { get; set; }
        public Guid? Productid { get; set; }
        public Guid? Productoptionid { get; set; }
        public Guid? Productoptionvalueid { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
        public virtual ProductsOptions Productoption { get; set; }
        public virtual ProductsOptionsValues Productoptionvalue { get; set; }
    }
}
