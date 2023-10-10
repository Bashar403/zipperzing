using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using zipperzing.Data;
using System;
using System.Linq;

namespace zipperzing.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new zipperzingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<zipperzingContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Sparkling Zirconium Zipper",
                        Price = 9.99M,
                        Length = 10,
                        Material = "Zirconium",
                        Color = "Shimmering Silver",
                        Type = "Luxury",
                        AverageRating = 4.5
                    },
                new Product
                {
                    Name = "Ninja Stealth Zipper",
                    Price = 12.99M,
                    Length = 12,
                    Material = "Nanofiber",
                    Color = "Midnight Black",
                    Type = "Stealth",
                    AverageRating = 4.0
                },
                new Product
                {
                    Name = "Golden Elegance Zipper",
                    Price = 8.49M,
                    Length = 8,
                    Material = "Gold-Plated",
                    Color = "Golden Shine",
                    Type = "Elegant",
                    AverageRating = 4.2
                },
                new Product
                {
                    Name = "AquaGuard Xtreme Zipper",
                    Price = 11.99M,
                    Length = 15,
                    Material = "AquaFlex",
                    Color = "Ocean Blue",
                    Type = "Waterproof",
                    AverageRating = 4.7
                },
                new Product
                {
                    Name = "Sapphire Serenity Zipper",
                    Price = 6.99M,
                    Length = 6,
                    Material = "Sapphire-Infused",
                    Color = "Royal Blue",
                    Type = "Serenity",
                    AverageRating = 4.8
                },
                new Product
                {
                    Name = "FireDragon Blaze Zipper",
                    Price = 14.99M,
                    Length = 14,
                    Material = "Dragonhide",
                    Color = "Flaming Red",
                    Type = "Mythical",
                    AverageRating = 4.9
                },
                new Product
                {
                    Name = "SilentShadow Stealth Zipper",
                    Price = 7.49M,
                    Length = 9,
                    Material = "Carbon Stealth",
                    Color = "Shadow Black",
                    Type = "Silent",
                    AverageRating = 4.6
                },
                new Product
                {
                    Name = "Emerald Enigma Zipper",
                    Price = 10.99M,
                    Length = 11,
                    Material = "Emerald-Inlaid",
                    Color = "Mystic Green",
                    Type = "Enigma",
                    AverageRating = 4.3
                },
                new Product
                {
                    Name = "Platinum Prestige Zipper",
                    Price = 8.99M,
                    Length = 7,
                    Material = "Platinum-Coated",
                    Color = "Platinum Silver",
                    Type = "Prestige",
                    AverageRating = 4.4
                },
                new Product
                {
                    Name = "Sunrise Sunshine Zipper",
                    Price = 13.49M,
                    Length = 13,
                    Material = "Solar Fabric",
                    Color = "Radiant Yellow",
                    Type = "Sunshine",
                    AverageRating = 4.1
                }
                );
                context.SaveChanges();
            }
        }
    }
}