using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models
{
    public partial class ManufacturersInfo
    {
        public Guid Id { get; set; }
        public Guid? Manufacturerid { get; set; }
        public string Url { get; set; }
        public DateTime Addedon { get; set; }

        public virtual Manufacturers Manufacturer { get; set; }
    }
}
