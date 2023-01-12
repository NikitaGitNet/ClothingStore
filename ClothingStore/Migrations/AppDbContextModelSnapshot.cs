﻿// <auto-generated />
using System;
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothingStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClothingStore.Domain.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ManufacturerCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e3927a70-e055-4e6c-a4fa-e10308a78a7d"),
                            ManufacturerCountry = "USA",
                            Name = "Nike",
                            TitleImagePath = "Brands/2.png"
                        },
                        new
                        {
                            Id = new Guid("f0e9fd9d-67fe-4f99-ace4-7b403c57ab46"),
                            ManufacturerCountry = "Germany",
                            Name = "Adidas",
                            TitleImagePath = "Brands/3.png"
                        },
                        new
                        {
                            Id = new Guid("7efc9710-ed9f-460c-b29f-617a4a784269"),
                            ManufacturerCountry = "USA",
                            Name = "Ralph Lauren",
                            TitleImagePath = "Brands/1.jpg"
                        },
                        new
                        {
                            Id = new Guid("4d89fc13-6268-464f-8ecf-57acc7427b64"),
                            ManufacturerCountry = "Italy",
                            Name = "Stone Island",
                            TitleImagePath = "Brands/5.png"
                        },
                        new
                        {
                            Id = new Guid("457966e8-26e4-489b-978a-f903a07d3533"),
                            ManufacturerCountry = "France",
                            Name = "Lacoste",
                            TitleImagePath = "Brands/4.jpg"
                        });
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.ClothingType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClothingTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b748d2f-e012-4150-b163-ad49a9b4c030"),
                            Name = "Shirt"
                        },
                        new
                        {
                            Id = new Guid("301b068b-c740-4f8e-93c9-5f08885dcbe8"),
                            Name = "Jacket"
                        },
                        new
                        {
                            Id = new Guid("726eb9ac-be00-4e75-b328-d732d433d432"),
                            Name = "Pants"
                        },
                        new
                        {
                            Id = new Guid("a8080577-5efb-4339-867a-8ba2129ae766"),
                            Name = "Sweater"
                        },
                        new
                        {
                            Id = new Guid("da3a3156-3593-4f37-a89d-293e126915c6"),
                            Name = "Blouse"
                        });
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Post")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Tariff")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e4bed810-c1f5-40d3-bf6f-cf537eddcfe9"),
                            Bonus = 1000,
                            DateOfEmployment = new DateTime(2015, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Генадий",
                            LastName = "Букин",
                            MiddleName = "Валентинович",
                            Post = "Продавец обуви",
                            Tariff = 1f
                        });
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.OnlineOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("OnlineOrders");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClothingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClothingTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OnlineOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SizeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ClothingTypeId");

                    b.HasIndex("OnlineOrderId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aef66f8c-f6c5-4f4a-abf2-b31b89c25b51"),
                            BrandId = new Guid("7efc9710-ed9f-460c-b29f-617a4a784269"),
                            BrandName = "Ralph Lauren",
                            ClothingTypeId = new Guid("5b748d2f-e012-4150-b163-ad49a9b4c030"),
                            ClothingTypeName = "Shirt",
                            Count = 7,
                            Name = "Хлопковая сорочка",
                            Price = 29100f,
                            SizeId = new Guid("74923a8e-621d-4d5a-8980-5985a3983d31"),
                            SizeName = "50 (L)",
                            TitleImagePath = "Products/Ralph Lauren/Shirt/1.jpg"
                        },
                        new
                        {
                            Id = new Guid("93a85753-c130-455f-83ec-6a90d3970d72"),
                            BrandId = new Guid("4d89fc13-6268-464f-8ecf-57acc7427b64"),
                            BrandName = "Stone Island",
                            ClothingTypeId = new Guid("301b068b-c740-4f8e-93c9-5f08885dcbe8"),
                            ClothingTypeName = "Jacket",
                            Count = 4,
                            Name = "Куртка",
                            Price = 30000f,
                            SizeId = new Guid("eecfb6cb-4f7f-4ca8-9dbc-ad18a0fbc7ff"),
                            SizeName = "48 (M)",
                            TitleImagePath = "Products/Stone Island/Jacket/2.jpg"
                        },
                        new
                        {
                            Id = new Guid("80cee191-9b30-4830-9f9f-58cb88057b96"),
                            BrandId = new Guid("457966e8-26e4-489b-978a-f903a07d3533"),
                            BrandName = "Lacoste",
                            ClothingTypeId = new Guid("726eb9ac-be00-4e75-b328-d732d433d432"),
                            ClothingTypeName = "Pants",
                            Count = 5,
                            Name = "Мужские брюки Sport Fleece Tennis",
                            Price = 12690f,
                            SizeId = new Guid("6650614b-a9ca-4d75-9407-1aa69a826ec1"),
                            SizeName = "52 (XL)",
                            TitleImagePath = "Products/Lacoste/Pants/3.jpg"
                        },
                        new
                        {
                            Id = new Guid("16179e73-8390-432a-8b7c-be073ab6dc12"),
                            BrandId = new Guid("e3927a70-e055-4e6c-a4fa-e10308a78a7d"),
                            BrandName = "Nike",
                            ClothingTypeId = new Guid("da3a3156-3593-4f37-a89d-293e126915c6"),
                            ClothingTypeName = "Blouse",
                            Count = 1,
                            Name = "Кофта мужская",
                            Price = 4470f,
                            SizeId = new Guid("6650614b-a9ca-4d75-9407-1aa69a826ec1"),
                            SizeName = "52 (XL)",
                            TitleImagePath = "Products/Nike/Blouse/4.jpeg"
                        },
                        new
                        {
                            Id = new Guid("d6d60425-d2fd-4f8b-8e1b-f7c9def4a7ac"),
                            BrandId = new Guid("f0e9fd9d-67fe-4f99-ace4-7b403c57ab46"),
                            BrandName = "Adidas",
                            ClothingTypeId = new Guid("a8080577-5efb-4339-867a-8ba2129ae766"),
                            ClothingTypeName = "Sweater",
                            Count = 1,
                            Name = "Cвитер Adicolor Classics Beckenbauer Primeblue",
                            Price = 7690f,
                            SizeId = new Guid("e3437214-5c5c-411b-84ca-9015f4804e74"),
                            SizeName = "54 (XXL)",
                            TitleImagePath = "Products/Adidas/Sweater/5.jpeg"
                        },
                        new
                        {
                            Id = new Guid("6998cd87-b0b3-43af-918e-a20e9c3a1b8d"),
                            BrandId = new Guid("f0e9fd9d-67fe-4f99-ace4-7b403c57ab46"),
                            BrandName = "Adidas",
                            ClothingTypeId = new Guid("726eb9ac-be00-4e75-b328-d732d433d432"),
                            ClothingTypeName = "Pants",
                            Count = 7,
                            Name = "Adidas Classics Beckenbauer Primeblue",
                            Price = 7990f,
                            SizeId = new Guid("152d81c0-363c-4f6c-9a17-5a4edd969fd6"),
                            SizeName = "44 (XS)",
                            TitleImagePath = "Products/Adidas/Sweater/adidas_pants.jpg"
                        },
                        new
                        {
                            Id = new Guid("c6312117-bd11-4a7a-afed-42cec57af355"),
                            BrandId = new Guid("4d89fc13-6268-464f-8ecf-57acc7427b64"),
                            BrandName = "Stone Island",
                            ClothingTypeId = new Guid("a8080577-5efb-4339-867a-8ba2129ae766"),
                            ClothingTypeName = "Sweater",
                            Count = 6,
                            Name = "STONE ISLAND Хлопковый джемпер",
                            Price = 26600f,
                            SizeId = new Guid("6b4b71e1-ca7f-463e-ac67-16d32e00b0a7"),
                            SizeName = "46 (S)",
                            TitleImagePath = "Products/Stone Island/Sweater/StoneIsland_Sweater.jpg"
                        },
                        new
                        {
                            Id = new Guid("6df63604-d3f4-4c52-860c-da5c1f8b6ebc"),
                            BrandId = new Guid("457966e8-26e4-489b-978a-f903a07d3533"),
                            BrandName = "Lacoste",
                            ClothingTypeId = new Guid("da3a3156-3593-4f37-a89d-293e126915c6"),
                            ClothingTypeName = "Blouse",
                            Count = 6,
                            Name = "Рубашка Lacoste",
                            Price = 14980f,
                            SizeId = new Guid("eecfb6cb-4f7f-4ca8-9dbc-ad18a0fbc7ff"),
                            SizeName = "48 (M)",
                            TitleImagePath = "Products/Lacoste/Blouse/Blouse_Lacost.jpg"
                        },
                        new
                        {
                            Id = new Guid("75b9937a-20c5-4308-8185-4585b5e4adbb"),
                            BrandId = new Guid("e3927a70-e055-4e6c-a4fa-e10308a78a7d"),
                            BrandName = "Nike",
                            ClothingTypeId = new Guid("301b068b-c740-4f8e-93c9-5f08885dcbe8"),
                            ClothingTypeName = "Jacket",
                            Count = 6,
                            Name = "Пуховик Nike NSW DWN Fill Wr Parka Hd Rus AO8915-045 SR",
                            Price = 10990f,
                            SizeId = new Guid("74923a8e-621d-4d5a-8980-5985a3983d31"),
                            SizeName = "50 (L)",
                            TitleImagePath = "Products/Lacoste/Blouse/Blouse_Lacost.jpg"
                        },
                        new
                        {
                            Id = new Guid("1375b596-256b-490a-b21c-cf8f98a3634a"),
                            BrandId = new Guid("7efc9710-ed9f-460c-b29f-617a4a784269"),
                            BrandName = "Ralph Lauren",
                            ClothingTypeId = new Guid("726eb9ac-be00-4e75-b328-d732d433d432"),
                            ClothingTypeName = "Pants",
                            Count = 2,
                            Name = "БРЮКИ КОЖАНЫЕ RALPH LAUREN",
                            Price = 197750f,
                            SizeId = new Guid("74923a8e-621d-4d5a-8980-5985a3983d31"),
                            SizeName = "50 (L)",
                            TitleImagePath = "Products/Ralph Lauren/Pants/RalphLauren_Pants.jpg"
                        });
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChestCircumference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HipCircumference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaistCircumference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("152d81c0-363c-4f6c-9a17-5a4edd969fd6"),
                            ChestCircumference = "84-88",
                            HipCircumference = "82-86",
                            Name = "44 (XS)",
                            WaistCircumference = "74-78"
                        },
                        new
                        {
                            Id = new Guid("6b4b71e1-ca7f-463e-ac67-16d32e00b0a7"),
                            ChestCircumference = "88-96",
                            HipCircumference = "86-92",
                            Name = "46 (S)",
                            WaistCircumference = "76-84"
                        },
                        new
                        {
                            Id = new Guid("eecfb6cb-4f7f-4ca8-9dbc-ad18a0fbc7ff"),
                            ChestCircumference = "96-102",
                            HipCircumference = "92-98",
                            Name = "48 (M)",
                            WaistCircumference = "82-90"
                        },
                        new
                        {
                            Id = new Guid("74923a8e-621d-4d5a-8980-5985a3983d31"),
                            ChestCircumference = "102-108",
                            HipCircumference = "98-104",
                            Name = "50 (L)",
                            WaistCircumference = "88-96"
                        },
                        new
                        {
                            Id = new Guid("6650614b-a9ca-4d75-9407-1aa69a826ec1"),
                            ChestCircumference = "108-114",
                            HipCircumference = "104-110",
                            Name = "52 (XL)",
                            WaistCircumference = "97-102"
                        },
                        new
                        {
                            Id = new Guid("e3437214-5c5c-411b-84ca-9015f4804e74"),
                            ChestCircumference = "114-120",
                            HipCircumference = "110-116",
                            Name = "54 (XXL)",
                            WaistCircumference = "100-108"
                        });
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Product", b =>
                {
                    b.HasOne("ClothingStore.Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothingStore.Domain.Entities.ClothingType", "ClothingType")
                        .WithMany("Products")
                        .HasForeignKey("ClothingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothingStore.Domain.Entities.OnlineOrder", null)
                        .WithMany("Products")
                        .HasForeignKey("OnlineOrderId");

                    b.HasOne("ClothingStore.Domain.Entities.Size", "Size")
                        .WithMany("Products")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("ClothingType");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.ClothingType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.OnlineOrder", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClothingStore.Domain.Entities.Size", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
