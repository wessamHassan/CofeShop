﻿// <auto-generated />
using CofeShop.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CofeShop.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CofeShop.Shared.Models.OrderDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountPerItem")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPricePerItem")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CofeShop.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Scones with organic Swedish blackberry jam.",
                            ImageUrl = "Scone with jam _ cream cheese.jpg",
                            Name = "Scone with jam & cream cheese",
                            Price = 45m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Breakfast roll with cheddar, butter, green salad & tomato.",
                            ImageUrl = "Breakfast roll with cheddar.jpg",
                            Name = "Breakfast roll with cheddar",
                            Price = 40m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Breakfast roll with cheddar, turkey pastrami, butter, green salad",
                            ImageUrl = "Breakfast roll cheddar _ turkey pastrami.jpg",
                            Name = "Breakfast roll cheddar turkey",
                            Price = 43m
                        },
                        new
                        {
                            Id = 4,
                            Description = "A long black coffee with 2 shots of espresso for regular and 3 for grande.",
                            ImageUrl = "Americano.jpg",
                            Name = "Americano",
                            Price = 35m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Espresso topped with steamed milk and a thin layer of micro-foam.",
                            ImageUrl = "Caffe latte.jpg",
                            Name = "Caffè latte",
                            Price = 32m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Espresso with steamed milk, microfoam  and dusted with chocolate powder.",
                            ImageUrl = "Cappuccino.jpg",
                            Name = "Cappuccino",
                            Price = 35m
                        },
                        new
                        {
                            Id = 7,
                            Description = "An all butter  flaky French pastry rolled into a croissant.",
                            ImageUrl = "Butter Croissant.jpg",
                            Name = "Butter Croissant",
                            Price = 32m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Hand-knotted cardamom bun with real butter.",
                            ImageUrl = "Cardamom bun premium.jpg",
                            Name = "Cardamom bun premium",
                            Price = 34m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Danish pastry with sour and fresh lemoncurd blueberries and icing sugar.",
                            ImageUrl = "Spandau lemoncurd _ blueberries.jpg",
                            Name = "Spandau lemoncurd & blueberries",
                            Price = 33m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Lactose free yoghurt 10% with honey and walnuts.",
                            ImageUrl = "Yoghurt honey walnut.jpg",
                            Name = "Yoghurt honey walnut",
                            Price = 40m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Stuffed premium butter croissant with prosciutto crudo & scrambled egg.",
                            ImageUrl = "Croissant prosciutto _ egg.jpg",
                            Name = "Croissant prosciutto egg",
                            Price = 35m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Swedish turkey bacon  pesto calabrese farro & boiled egg.",
                            ImageUrl = "Salad, Chicken, Turkey bacon, Farro Calabrese _ egg.jpg",
                            Name = "Salad  Turkey bacon & egg",
                            Price = 65m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Housemade tabboulhe with spicy hummus pomegranate  olive oil & limepepper.",
                            ImageUrl = "Salad tabboulhe with pomegranate _ spicy hummus.jpg",
                            Name = "Salad tabboulhe with pomegranate spicy hummus",
                            Price = 62m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Italian light bread with pesto  hot tuna in mayonaise jalapenos  tomatoes. Grilled and heated in the oven.",
                            ImageUrl = "Grilled pinsa tonno piccante.jpg",
                            Name = "Grilled pinsa tonno piccante",
                            Price = 60m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Italian light bread with pesto, grated mozzarella, fresh tomatoes, prosciutto crudo. Grilled and heated in the oven.",
                            ImageUrl = "Grilled pinsa pesto prosciutto.jpg",
                            Name = "Grilled pinsa pesto prosciutto",
                            Price = 60m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Classic Frappe Latte on our award winning espresso.",
                            ImageUrl = "Classic Frappe Latte.jpg",
                            Name = "Classic Frappe Latte",
                            Price = 35m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Classic Iced Latte on our award winning espresso and caramel syrup.",
                            ImageUrl = "Ice Latte Caramel.jpg",
                            Name = "Ice Latte Caramel",
                            Price = 42m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Classic Iced Latte on our award winning espresso and vanilla syrup.",
                            ImageUrl = "Ice Latte Vanilla.jpg",
                            Name = "Ice Latte Vanilla",
                            Price = 42m
                        });
                });

            modelBuilder.Entity("CofeShop.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
