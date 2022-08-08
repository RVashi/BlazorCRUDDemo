using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorProjectDemo.Data
{
    public class ShopService : IShopService
    {
        private List<Shop> shops = new List<Shop>
        {
            new Shop
            {
                Id = Guid.NewGuid(),
                ShopName="Kays In",
                Address="xxx",
                ZipCode="xxx",
                Location="xxx",
                CountryName="xxxxxx",
                IsDeleted=false
            },
             new Shop
            {
                Id = Guid.NewGuid(),
                ShopName="Kays Can",
                Address="xxxxxx",
                ZipCode="xxxxxx",
                Location="xxxxxx",
                CountryName="xxxxxx",
                IsDeleted=false
            }
        };

        public void AddShop(Shop model)
        {
            var Id = Guid.NewGuid();
            model.Id = Id;
            shops.Add(model);
        }

        public void DeleteShop(Guid Id)
        {
            var shop = Getshop(Id);
            shops.Remove(shop);
            shops.Remove(shop);
        }

        public Shop Getshop(Guid Id)
        {
            return shops.SingleOrDefault(x => x.Id == Id);
        }

        public List<Shop> GetShops()
        {
            return shops;
        }

        public void UpdateShop(Shop model)
        {
            var getOldShop = Getshop(model.Id);
            getOldShop.ShopName = model.ShopName;
            getOldShop.Address = model.Address;
            getOldShop.ZipCode = model.ZipCode;
            getOldShop.Location = model.Location;
            getOldShop.CountryName = model.CountryName;
        }
    }
}
