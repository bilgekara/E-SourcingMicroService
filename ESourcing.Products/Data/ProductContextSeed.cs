using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name = "Iphone X",
                    Summary= "Summary 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum quam ut posuere tincidunt. Aenean quis dolor vitae mi pulvinar commodo. Aliquam erat volutpat. Curabitur id leo viverra ante euismod maximus. Quisque facilisis ex lacus. Duis sed condimentum odio. Aliquam erat volutpat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse id feugiat dui, scelerisque facilisis metus. Praesent sit amet quam vel ex sagittis suscipit.",
                    ImageFile  = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product
                {
                    Name = "Xiaomi Mi 9",
                    Summary= "Summary 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum quam ut posuere tincidunt. Aenean quis dolor vitae mi pulvinar commodo. Aliquam erat volutpat. Curabitur id leo viverra ante euismod maximus. Quisque facilisis ex lacus. Duis sed condimentum odio. Aliquam erat volutpat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse id feugiat dui, scelerisque facilisis metus. Praesent sit amet quam vel ex sagittis suscipit.",
                    ImageFile  = "product-2.png",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new Product
                {
                    Name = "Huawei Plus",
                    Summary= "Summary 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum quam ut posuere tincidunt. Aenean quis dolor vitae mi pulvinar commodo. Aliquam erat volutpat. Curabitur id leo viverra ante euismod maximus. Quisque facilisis ex lacus. Duis sed condimentum odio. Aliquam erat volutpat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse id feugiat dui, scelerisque facilisis metus. Praesent sit amet quam vel ex sagittis suscipit.",
                    ImageFile  = "product-3.png",
                    Price = 650.00M,
                    Category = "White Appliance"
                },
                new Product
                {
                    Name = "Xiaomi Mi 9",
                    Summary= "Summary 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum quam ut posuere tincidunt. Aenean quis dolor vitae mi pulvinar commodo. Aliquam erat volutpat. Curabitur id leo viverra ante euismod maximus. Quisque facilisis ex lacus. Duis sed condimentum odio. Aliquam erat volutpat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse id feugiat dui, scelerisque facilisis metus. Praesent sit amet quam vel ex sagittis suscipit.",
                    ImageFile  = "product-4.png",
                    Price = 470.00M,
                    Category = "White Appliance"
                },
                new Product
                {
                    Name = "HTC UI + Plus",
                    Summary= "Summary 5",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum quam ut posuere tincidunt. Aenean quis dolor vitae mi pulvinar commodo. Aliquam erat volutpat. Curabitur id leo viverra ante euismod maximus. Quisque facilisis ex lacus. Duis sed condimentum odio. Aliquam erat volutpat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse id feugiat dui, scelerisque facilisis metus. Praesent sit amet quam vel ex sagittis suscipit.",
                    ImageFile  = "product-5.png",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new Product
                {
                    Name = "LG G7 ThinQ",
                    Summary= "Summary 6",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum quam ut posuere tincidunt. Aenean quis dolor vitae mi pulvinar commodo. Aliquam erat volutpat. Curabitur id leo viverra ante euismod maximus. Quisque facilisis ex lacus. Duis sed condimentum odio. Aliquam erat volutpat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse id feugiat dui, scelerisque facilisis metus. Praesent sit amet quam vel ex sagittis suscipit.",
                    ImageFile  = "product-6.png",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                },
            };
        }
    }
}
