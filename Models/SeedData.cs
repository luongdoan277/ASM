using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ASM.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }


            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Pizza",
                        ImageUrl = "https://api.alfrescos.com.vn//uploads/images/dc312d8c-68d8-4ae0-8d2a-c70e367d836f.jpg"
                    },
                    new Category
                    {
                        Name = "Salad",
                        ImageUrl = "https://api.alfrescos.com.vn//uploads/images/4ee9c57c-15c8-45c4-8116-f257c3cdd29c.jpg"
                    },
                    new Category
                    {
                        Name = "Pasta",
                        ImageUrl = "https://api.alfrescos.com.vn//uploads/images/1e1f80cb-80a5-46bb-8f87-fe304049af8d.jpg"
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Sizes.Any())
            {
                context.Sizes.AddRange(
                    new Size
                    {
                        SizeName = "M"
                    },
                    new Size
                    {
                        SizeName = "L"
                    },
                    new Size
                    {
                        SizeName = "XL"
                    }
                    );
                context.SaveChanges();
            }


            if (!context.Products.Any())
            {
                context.Products.AddRange(

                    new Product
                    {
                        Name = "MARGHERITA",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-HN-Pizza-Margherita.jpg",
                        Description = "Pizza với xốt cà chua và phomát.",
                        Price = 150,
                        CategoryID = 1,
                        SizeID = 1,

                    },
                    new Product
                    {
                        Name = "HAWAIIAN",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Hawaiian.jpg",
                        Description = "Jămbông, dứa, xốt cà chua và phomát",
                        Price = 150,
                        CategoryID = 1,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "TROPICANA SEAFOOD",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Tropicana-Seafood.jpg",
                        Description = "Tôm, cá, cua thanh, ngao, dứa, xốt ớt chua ngọt và phomát.",
                        Price = 150,
                        CategoryID = 1,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "BBQ BEEFY",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Hawaiian.jpg",
                        Description = "Thịt ba chỉ bò và heo nướng, hành tây, cà chua với xốt BBQ, khoai tây sợi và...",
                        Price = 150,
                        CategoryID = 1,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = " BBQ BEEFY",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-BBQ-Chicken.jpg",
                        Description = "Thịt gà Mêhicô, xốt BBQ, ớt xanh, nấm, jămbông, thịt ba chỉ và phomát.",
                        Price = 150,
                        CategoryID = 1,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "CHEESY TUNA",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Pizza-Cheesy-Tuna.jpg",
                        Description = "Bò xay nướng xốt BBQ, hành tây xào, cà chua tươi, phomát Cheddar và phomát.",
                        Price = 150,
                        CategoryID = 1,
                        SizeID = 1,
                    },


                    //Salad
                    new Product
                    {
                        Name = "CAESAR SALAD",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Caesar-Salad.jpg",
                        Description = "Salát Ceasar với xà lách thái nhỏ, bánh mỳ nướng, thịt ba chỉ xông khói, trứng chần, trộn....",
                        Price = 150,
                        CategoryID = 2,
                        SizeID = 2,

                    },
                    new Product
                    {
                        Name = "GREEN GARDEN SALAD",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Green-Garden-Salad.jpg",
                        Description = "Salát với xà lách, cà chua, dưa chuột, hành tây, trộn xốt dầu dấm đặc biệt của Al...",
                        Price = 150,
                        CategoryID = 2,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "BEEF SALAD",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Beef-Salad.jpg",
                        Description = "Salát với thịt bò nhập khẩu tẩm xốt ớt cay nướng, khoai tây bi, ớt Đà Lạt ...",
                        Price = 150,
                        CategoryID = 2,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "BBQ BEEFY",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Russian-Salad.jpg",
                        Description = "Salát Nga với cà rốt, khoai tây, đậu hạt, ngô hạt, jămbông, củ cải đỏ, cần tây, trộn...",
                        Price = 150,
                        CategoryID = 2,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "GREEN GARDEN SALAD",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Poached-Salmon-Salad.jpg",
                        Description = "Salát Nga với cà rốt, khoai tây, đậu hạt, ngô hạt, jămbông, củ cải đỏ, cần tây, trộn...",
                        Price = 150,
                        CategoryID = 2,
                        SizeID = 3,
                    }, new Product
                    {
                        Name = "GREEN GARDEN SALAD",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Dalat-Salad.jpg",
                        Description = "Salát Nga với cà rốt, khoai tây, đậu hạt, ngô hạt, jămbông, củ cải đỏ, cần tây, trộn...",
                        Price = 150,
                        CategoryID = 2,
                        SizeID = 1,
                    }

                    //Pasta
                    , new Product
                    {
                        Name = "SPAGHETTI BOLOGNAISE",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Spaghetti-Bolognaise.jpg",
                        Description = "Mỳ Ý sợi dài với xốt thịt bò hầm & cà chua.",
                        Price = 150,
                        CategoryID = 3,
                        SizeID = 1,
                    }, new Product
                    {
                        Name = "vSPAGHETTI BOLOGNAISE",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Fettuccine-Carbonara.jpg",
                        Description = "Mỳ Ý sợi dẹt với jămbông & phomát xốt kem.",
                        Price = 150,
                        CategoryID = 3,
                        SizeID = 3,
                    }, new Product
                    {
                        Name = "GSTEAK & MUSHROOM SPAGHETTI",
                        ImageProduct = "https://api.alfrescos.com.vn//uploads/images/Alfrescos-Hanoi-Steak-&-Mushroom-Spaghetti.jpg",
                        Description = "Mỳ Ý sợi dài với thịt bò Úc, nấm & xốt kem đậu đen.",
                        Price = 150,
                        CategoryID = 3,
                        SizeID = 2,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
