using System;
using System.Collections.Generic;

namespace ECommerceAPI.Models
{
    public partial class Manufacturers
    {
        public Manufacturers()
        {
            ManufacturersInfo = new HashSet<ManufacturersInfo>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<ManufacturersInfo> ManufacturersInfo { get; set; }
    }
}
