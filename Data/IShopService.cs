using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectDemo.Data
{
    interface IShopService
    {
        List<Shop> GetShops();
        Shop Getshop(Guid Id);
        void UpdateShop(Shop model);
        void AddShop(Shop model);
        void DeleteShop(Guid Id);
    }
}
