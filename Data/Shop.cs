using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectDemo.Data
{
    public class Shop
    {
        public Guid Id { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Location { get; set; }
        public string CountryName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
