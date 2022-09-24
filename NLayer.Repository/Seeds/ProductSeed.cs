﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalem1",
                Price = 100,
                Stock = 20,
                CreateTime = DateTime.Now
            },
                    new Product
                    {
                        Id = 2,
                        CategoryId = 1,
                        Name = "Kalem2",
                        Price = 100,
                        Stock = 20,
                        CreateTime = DateTime.Now
                    },
                    new Product
                    {
                        Id = 3,
                        CategoryId = 1,
                        Name = "Kalem3",
                        Price = 100,
                        Stock = 20,
                        CreateTime = DateTime.Now

                    });
        }
    }
}
