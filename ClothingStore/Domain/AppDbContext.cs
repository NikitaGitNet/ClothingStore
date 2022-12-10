using ClothingStore.Domain.Entities;
using ClothingStore.TestData.Brands;
using ClothingStore.TestData.Sizes;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OnlineOrder> OnlineOrders { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Size> Sizes { get; set; }
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
                ManufacturerCountry = NikeTest.ManufacturerCountry
            },
            new Brand
            {
                Id = new Guid(AdidasTest.Id),
                Name = AdidasTest.Name,
                ManufacturerCountry = AdidasTest.ManufacturerCountry
            },
            new Brand
            {
                Id = new Guid(RalphLaurenTest.Id),
                Name = RalphLaurenTest.Name,
                ManufacturerCountry = RalphLaurenTest.ManufacturerCountry
            },
            new Brand
            {
                Id = new Guid(StoneIslandTest.Id),
                Name = StoneIslandTest.Name,
                ManufacturerCountry = StoneIslandTest.ManufacturerCountry
            },
            new Brand
            {
                Id = new Guid(LacosteTest.Id),
                Name = LacosteTest.Name,
                ManufacturerCountry = LacosteTest.ManufacturerCountry
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = new Guid("aef66f8c-f6c5-4f4a-abf2-b31b89c25b51"),
                Count = new Random().Next(10),
                Name = "Хлопковая сорочка",
                BrandId = new Guid(RalphLaurenTest.Id),
                SizeId = new Guid(SizeL.Id),
                Price = 29100
            },
            new Product
            {
                Id = new Guid("93a85753-c130-455f-83ec-6a90d3970d72"),
                Count = new Random().Next(10),
                Name = "Куртка",
                BrandId = new Guid(StoneIslandTest.Id),
                SizeId = new Guid(SizeM.Id),
                Price = 30000
            },
            new Product
            {
                Id = new Guid("80cee191-9b30-4830-9f9f-58cb88057b96"),
                Count = new Random().Next(10),
                Name = "Мужские брюки Sport Fleece Tennis",
                BrandId = new Guid(LacosteTest.Id),
                SizeId = new Guid(SizeXL.Id),
                Price = 12690
            },
            new Product
            {
                Id = new Guid("16179e73-8390-432a-8b7c-be073ab6dc12"),
                Count = new Random().Next(10),
                Name = "Футболка мужская",
                BrandId = new Guid(NikeTest.Id),
                SizeId = new Guid(SizeXL.Id),
                Price = 4470
            },
            new Product
            {
                Id = new Guid("d6d60425-d2fd-4f8b-8e1b-f7c9def4a7ac"),
                Count = new Random().Next(10),
                Name = "Мужская олимпийка Adicolor Classics Beckenbauer Primeblue",
                BrandId = new Guid(AdidasTest.Id),
                SizeId = new Guid(SizeXXL.Id),
                Price = 7690
            });
        }
    }
}
