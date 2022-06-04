using CofeShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofeShop.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasAlternateKey(c => c.Email);

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product{Id= 1, Name = "Scone with jam & cream cheese", Description= "Scones with organic Swedish blackberry jam.", ImageUrl="Scone with jam _ cream cheese.jpg", Price = 45},
                new Product{Id= 2, Name = "Breakfast roll with cheddar", Description= "Breakfast roll with cheddar, butter, green salad & tomato.", ImageUrl="Breakfast roll with cheddar.jpg", Price = 40},
                new Product{Id= 3, Name = "Breakfast roll cheddar turkey", Description= "Breakfast roll with cheddar, turkey pastrami, butter, green salad", ImageUrl="Breakfast roll cheddar _ turkey pastrami.jpg", Price = 43},
                new Product{Id= 4, Name = "Americano", Description= "A long black coffee with 2 shots of espresso for regular and 3 for grande.", ImageUrl="Americano.jpg", Price = 35},
                new Product{Id= 5, Name = "Caffè latte", Description= "Espresso topped with steamed milk and a thin layer of micro-foam.", ImageUrl="Caffe latte.jpg", Price = 32},
                new Product{Id= 6, Name = "Cappuccino", Description= "Espresso with steamed milk, microfoam  and dusted with chocolate powder.", ImageUrl="Cappuccino.jpg", Price = 35},
                new Product{Id= 7, Name = "Butter Croissant", Description= "An all butter  flaky French pastry rolled into a croissant.", ImageUrl="Butter Croissant.jpg", Price =32 },
                new Product{Id= 8, Name = "Cardamom bun premium", Description= "Hand-knotted cardamom bun with real butter.", ImageUrl="Cardamom bun premium.jpg", Price =34 },
                new Product{Id= 9, Name = "Spandau lemoncurd & blueberries", Description= "Danish pastry with sour and fresh lemoncurd blueberries and icing sugar.", ImageUrl="Spandau lemoncurd _ blueberries.jpg", Price = 33},
                new Product{Id= 10, Name = "Yoghurt honey walnut", Description= "Lactose free yoghurt 10% with honey and walnuts.", ImageUrl="Yoghurt honey walnut.jpg", Price = 40},
                new Product{Id= 11, Name = "Croissant prosciutto egg", Description= "Stuffed premium butter croissant with prosciutto crudo & scrambled egg.", ImageUrl="Croissant prosciutto _ egg.jpg", Price = 35},
                new Product{Id= 12, Name = "Salad  Turkey bacon & egg", Description= "Swedish turkey bacon  pesto calabrese farro & boiled egg.", ImageUrl="Salad, Chicken, Turkey bacon, Farro Calabrese _ egg.jpg", Price =65 },
                new Product{Id= 13, Name = "Salad tabboulhe with pomegranate spicy hummus", Description= "Housemade tabboulhe with spicy hummus pomegranate  olive oil & limepepper.", ImageUrl="Salad tabboulhe with pomegranate _ spicy hummus.jpg", Price = 62},
                new Product{Id= 14, Name = "Grilled pinsa tonno piccante", Description= "Italian light bread with pesto  hot tuna in mayonaise jalapenos  tomatoes. Grilled and heated in the oven.", ImageUrl="Grilled pinsa tonno piccante.jpg", Price = 60},
                new Product{Id= 15, Name = "Grilled pinsa pesto prosciutto", Description= "Italian light bread with pesto, grated mozzarella, fresh tomatoes, prosciutto crudo. Grilled and heated in the oven.", ImageUrl="Grilled pinsa pesto prosciutto.jpg", Price =60 },
                new Product{Id= 16, Name = "Classic Frappe Latte", Description= "Classic Frappe Latte on our award winning espresso.", ImageUrl="Classic Frappe Latte.jpg", Price =35 },
                new Product{Id= 17, Name = "Ice Latte Caramel", Description= "Classic Iced Latte on our award winning espresso and caramel syrup.", ImageUrl="Ice Latte Caramel.jpg", Price =42 },
                new Product{Id= 18, Name = "Ice Latte Vanilla", Description= "Classic Iced Latte on our award winning espresso and vanilla syrup.", ImageUrl="Ice Latte Vanilla.jpg", Price = 42}

            });
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDto> Orders { get; set; }
    }
}
