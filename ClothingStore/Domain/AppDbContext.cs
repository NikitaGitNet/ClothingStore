using ClothingStore.Domain.Entities;
using ClothingStore.TestData.Brands;
using ClothingStore.TestData.ClothingTypes;
using ClothingStore.TestData.Employees;
using ClothingStore.TestData.Sizes;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<OnlineOrder>? OnlineOrders { get; set; }
        public DbSet<Sale>? Sales { get; set; }
        public DbSet<Size>? Sizes { get; set; }
        public DbSet<ClothingType>? ClothingTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Size>().HasData(new Size
            {
                Id = new Guid(SizeXS.Id),
                Name = SizeXS.Name,
                ChestCircumference = SizeXS.ChestCircumference,
                WaistCircumference = SizeXS.WaistCircumference,
                HipCircumference = SizeXS.HipCircumference
            },
            new Size
            {
                Id = new Guid(SizeS.Id),
                Name = SizeS.Name,
                ChestCircumference = SizeS.ChestCircumference,
                WaistCircumference = SizeS.WaistCircumference,
                HipCircumference = SizeS.HipCircumference
            },
            new Size
            {
                Id = new Guid(SizeM.Id),
                Name = SizeM.Name,
                ChestCircumference = SizeM.ChestCircumference,
                WaistCircumference = SizeM.WaistCircumference,
                HipCircumference = SizeM.HipCircumference
            },
            new Size
            {
                Id = new Guid(SizeL.Id),
                Name = SizeL.Name,
                ChestCircumference = SizeL.ChestCircumference,
                WaistCircumference = SizeL.WaistCircumference,
                HipCircumference = SizeL.HipCircumference
            },
            new Size
            {
                Id = new Guid(SizeXL.Id),
                Name = SizeXL.Name,
                ChestCircumference = SizeXL.ChestCircumference,
                WaistCircumference = SizeXL.WaistCircumference,
                HipCircumference = SizeXL.HipCircumference
            },
            new Size
            {
                Id = new Guid(SizeXXL.Id),
                Name = SizeXXL.Name,
                ChestCircumference = SizeXXL.ChestCircumference,
                WaistCircumference = SizeXXL.WaistCircumference,
                HipCircumference = SizeXXL.HipCircumference
            });

            builder.Entity<Brand>().HasData(new Brand
            {
                Id = new Guid(NikeTest.Id),
                Name = NikeTest.Name,
                ManufacturerCountry = NikeTest.ManufacturerCountry,
                TitleImagePath = "Brands/2.png"
            },
            new Brand
            {
                Id = new Guid(AdidasTest.Id),
                Name = AdidasTest.Name,
                ManufacturerCountry = AdidasTest.ManufacturerCountry,
                TitleImagePath = "Brands/3.png"
            },
            new Brand
            {
                Id = new Guid(RalphLaurenTest.Id),
                Name = RalphLaurenTest.Name,
                ManufacturerCountry = RalphLaurenTest.ManufacturerCountry,
                TitleImagePath = "Brands/1.jpg"
            },
            new Brand
            {
                Id = new Guid(StoneIslandTest.Id),
                Name = StoneIslandTest.Name,
                ManufacturerCountry = StoneIslandTest.ManufacturerCountry,
                TitleImagePath = "Brands/5.png"
            },
            new Brand
            {
                Id = new Guid(LacosteTest.Id),
                Name = LacosteTest.Name,
                ManufacturerCountry = LacosteTest.ManufacturerCountry,
                TitleImagePath = "Brands/4.jpg"
            });

            builder.Entity<ClothingType>().HasData(new ClothingType
            {
                Id = Shirt.Id,
                Name = Shirt.Name
            },
            new ClothingType
            {
                Id = Jacket.Id,
                Name = Jacket.Name,
            },
            new ClothingType
            {
                Id = Pants.Id,
                Name = Pants.Name
            },
            new ClothingType
            {
                Id = Sweater.Id,
                Name = Sweater.Name
            },
            new ClothingType
            {
                Id = Blouse.Id,
                Name = Blouse.Name,
            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = new Guid("aef66f8c-f6c5-4f4a-abf2-b31b89c25b51"),
                Count = new Random().Next(10),
                Name = "Хлопковая сорочка",
                BrandId = new Guid(RalphLaurenTest.Id),
                BrandName = RalphLaurenTest.Name,
                SizeId = new Guid(SizeL.Id),
                SizeName = SizeL.Name,
                Price = 29100,
                TitleImagePath = "Products/Ralph Lauren/Shirt/1.jpg",
                ClothingTypeName = Shirt.Name,
                ClothingTypeId = Shirt.Id,
            },
            new Product
            {
                Id = new Guid("93a85753-c130-455f-83ec-6a90d3970d72"),
                Count = new Random().Next(10),
                Name = "Куртка",
                BrandId = new Guid(StoneIslandTest.Id),
                BrandName = StoneIslandTest.Name,
                SizeId = new Guid(SizeM.Id),
                SizeName = SizeM.Name,
                Price = 30000,
                TitleImagePath = "Products/Stone Island/Jacket/2.jpg",
                ClothingTypeId = Jacket.Id,
                ClothingTypeName = Jacket.Name,
            },
            new Product
            {
                Id = new Guid("80cee191-9b30-4830-9f9f-58cb88057b96"),
                Count = new Random().Next(10),
                Name = "Мужские брюки Sport Fleece Tennis",
                BrandId = new Guid(LacosteTest.Id),
                BrandName = LacosteTest.Name,
                SizeId = new Guid(SizeXL.Id),
                SizeName = SizeXL.Name,
                Price = 12690,
                TitleImagePath = "Products/Lacoste/Pants/3.jpg",
                ClothingTypeId = Pants.Id,
                ClothingTypeName = Pants.Name
            },
            new Product
            {
                Id = new Guid("16179e73-8390-432a-8b7c-be073ab6dc12"),
                Count = new Random().Next(10),
                Name = "Кофта мужская",
                BrandId = new Guid(NikeTest.Id),
                BrandName = NikeTest.Name,
                SizeId = new Guid(SizeXL.Id),
                SizeName = SizeXL.Name,
                Price = 4470,
                ClothingTypeId = Blouse.Id,
                ClothingTypeName = Blouse.Name,
                TitleImagePath = "Products/Nike/Blouse/4.jpeg"
            },
            new Product
            {
                Id = new Guid("d6d60425-d2fd-4f8b-8e1b-f7c9def4a7ac"),
                Count = new Random().Next(10),
                Name = "Cвитер Adicolor Classics Beckenbauer Primeblue",
                BrandId = new Guid(AdidasTest.Id),
                BrandName = AdidasTest.Name,
                SizeId = new Guid(SizeXXL.Id),
                SizeName = SizeXXL.Name,
                Price = 7690,
                ClothingTypeId = Sweater.Id,
                ClothingTypeName = Sweater.Name,
                TitleImagePath = "Products/Adidas/Sweater/5.jpeg"
            },
            new Product
            {
                Id = new Guid("6998cd87-b0b3-43af-918e-a20e9c3a1b8d"),
                Count = new Random().Next(10),
                Name = "Adidas Classics Beckenbauer Primeblue",
                BrandId = new Guid(AdidasTest.Id),
                BrandName = AdidasTest.Name,
                SizeId = new Guid(SizeXS.Id),
                SizeName = SizeXS.Name,
                Price = 7990,
                ClothingTypeId = Pants.Id,
                ClothingTypeName = Pants.Name,
                TitleImagePath = "Products/Adidas/Pants/adidas_pants.jpg"
            },
            new Product
            {
                Id = new Guid("c6312117-bd11-4a7a-afed-42cec57af355"),
                Count = new Random().Next(10),
                Name = "STONE ISLAND Хлопковый джемпер",
                BrandId = new Guid(StoneIslandTest.Id),
                BrandName = StoneIslandTest.Name,
                SizeId = new Guid(SizeS.Id),
                SizeName = SizeS.Name,
                Price = 26600,
                ClothingTypeId = Sweater.Id,
                ClothingTypeName = Sweater.Name,
                TitleImagePath = "Products/Stone Island/Sweater/StoneIsland_Sweater.jpg"
            },
            new Product
            {
                Id = new Guid("6df63604-d3f4-4c52-860c-da5c1f8b6ebc"),
                Count = new Random().Next(10),
                Name = "Рубашка Lacoste",
                BrandId = new Guid(LacosteTest.Id),
                BrandName = LacosteTest.Name,
                SizeId = new Guid(SizeM.Id),
                SizeName = SizeM.Name,
                Price = 14980,
                ClothingTypeId = Blouse.Id,
                ClothingTypeName = Blouse.Name,
                TitleImagePath = "Products/Lacoste/Blouse/Blouse_Lacost.jpg"
            },
            new Product
            {
                Id = new Guid("75b9937a-20c5-4308-8185-4585b5e4adbb"),
                Count = new Random().Next(10),
                Name = "Пуховик Nike NSW DWN Fill Wr Parka Hd Rus AO8915-045 SR",
                BrandId = new Guid(NikeTest.Id),
                BrandName = NikeTest.Name,
                SizeId = new Guid(SizeL.Id),
                SizeName = SizeL.Name,
                Price = 10990,
                ClothingTypeId = Jacket.Id,
                ClothingTypeName = Jacket.Name,
                TitleImagePath = "Products/Lacoste/Blouse/Blouse_Lacost.jpg"
            },
            new Product
            {
                Id = new Guid("1375b596-256b-490a-b21c-cf8f98a3634a"),
                Count = new Random().Next(10),
                Name = "БРЮКИ КОЖАНЫЕ RALPH LAUREN",
                BrandId = new Guid(RalphLaurenTest.Id),
                BrandName = RalphLaurenTest.Name,
                SizeId = new Guid(SizeL.Id),
                SizeName = SizeL.Name,
                Price = 197750,
                ClothingTypeId = Pants.Id,
                ClothingTypeName = Pants.Name,
                TitleImagePath = "Products/Ralph Lauren/Pants/RalphLauren_Pants.jpg"
            });

            builder.Entity<Employee>().HasData(new Employee 
            { 
                Id = new(GenaBukin.Id),
                FirstName = GenaBukin.FirstName,
                LastName = GenaBukin.LastName,
                Bonus = GenaBukin.Bonus,
                DateOfEmployment = GenaBukin.DateOfEmployment,
                MiddleName = GenaBukin.MiddleName,
                Post = GenaBukin.Post,
                Tariff = GenaBukin.Tariff
            });
        }
    }
}
