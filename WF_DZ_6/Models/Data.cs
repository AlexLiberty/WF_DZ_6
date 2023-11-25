using System.Collections.ObjectModel;

namespace HM6_ElectronicsStore.Models
{
    public class Data
    {
        public static Category[] InitializeCategories()
        {
            return new[]
            {
                new Category{ Name = "Всі"},
                new Category{ Name = "Ноутбуки" },
                new Category{ Name = "Смартфони"},
                new Category{ Name = "TV"}
            };
        }
        public static ObservableCollection<Product> InitializeProducts(Category[] categories)
        {
            return new ObservableCollection<Product>()
            {
        new Product { Name = "Dell Inspiron 14 5402", Category = categories[1], Price = 28_499, Available = 18 },
        new Product { Name = "HP Pavilion 15-eg0103TX", Category = categories[1], Price = 34_999, Available = 15 },
        new Product { Name = "Lenovo Legion 5 15ACH6", Category = categories[1], Price = 29_999, Available = 25 },
        new Product { Name = "Microsoft Surface Laptop 4", Category = categories[1], Price = 45_999, Available = 12 },
        new Product { Name = "Acer Nitro 5 AN515-45", Category = categories[1], Price = 31_999, Available = 20 },

        new Product { Name = "Apple iPhone 16 256GB", Category = categories[2], Price = 45_499, Available = 27 },
        new Product { Name = "Google Pixel 7 8/256GB", Category = categories[2], Price = 38_499, Available = 20 },
        new Product { Name = "OnePlus 10 Pro 8/256 GB", Category = categories[2], Price = 27_999, Available = 35 },
        new Product { Name = "Sony Xperia 5 III", Category = categories[2], Price = 25_499, Available = 30 },
        new Product { Name = "Huawei P50 5G", Category = categories[2], Price = 11_999, Available = 38 },

        new Product { Name = "Sony Bravia KD-55X80J", Category = categories[3], Price = 19_999, Available = 25 },
        new Product { Name = "TCL 55C725", Category = categories[3], Price = 23_499, Available = 17 },
        new Product { Name = "Samsung QN85A Neo QLED", Category = categories[3], Price = 78_999, Available = 10 },
        new Product { Name = "Hisense 50A6G", Category = categories[3], Price = 19_499, Available = 18 },
        new Product { Name = "Panasonic TX-65JX800E", Category = categories[3], Price = 26_499, Available = 30 }
            };
        }
    }
}
