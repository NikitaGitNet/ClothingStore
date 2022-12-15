using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClothingStore.Domain;
using ClothingStore.Domain.Entities;
using ClothingStore.Model.Products;
using ClothingStore.Models.Price;

namespace ClothingStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = _context.Products.ToList();
            List<ProductViewModel> viewModels = new();
            foreach (Product product in products)
            {
                ProductViewModel model = new()
                { 
                    Id = product.Id,
                    Count = product.Count,
                    Name = product.Name,
                    TitleImagePath = product.TitleImagePath,
                    Brand = product.BrandName,
                    ClothingType = product.ClothingTypeName,
                    Price = product.Price
                };
                viewModels.Add(model);
            }
            return View(new ProductListViewModel {Products = viewModels});
        }
        public async Task<IActionResult> SortByBrand(Guid brandId)
        {
            List<Product>? products = await _context.Products.ToListAsync();
            var sortProducts = from product in products where product.BrandId == brandId select product;
            List<ProductViewModel> viewModels = new();
            foreach (var model in sortProducts)
            {
                ProductViewModel viewModel = new()
                { 
                    Id = model.Id,
                    Name = model.Name,
                    Price = model.Price,
                    Brand = model.BrandName,
                    Count = model.Count,
                    TitleImagePath = model.TitleImagePath,
                    ClothingType = model.ClothingTypeName,
                    SizeName = model.SizeName
                };
                viewModels.Add(viewModel);
            }
            return View(new ProductListViewModel {Products = viewModels });
        }
        public async Task<IActionResult> SortBySize(Guid sizeId)
        {
            List<Product>? products = await _context.Products.ToListAsync();
            var sortProducts = from product in products where product.SizeId == sizeId select product;
            List<ProductViewModel> viewModels = new();
            foreach (var model in sortProducts)
            {
                ProductViewModel viewModel = new()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Price = model.Price,
                    Brand = model.BrandName,
                    Count = model.Count,
                    TitleImagePath = model.TitleImagePath,
                    ClothingType = model.ClothingTypeName,
                    SizeName = model.SizeName
                };
                viewModels.Add(viewModel);
            }
            return View(new ProductListViewModel { Products = viewModels });
        }
        public async Task<IActionResult> SortByPrise(PriceViewModel price)
        {
            List<Product>? products = await _context.Products.ToListAsync();
            var sortProducts = from product in products where product.Price > price.MinPrice && product.Price < price.MaxPrice orderby product.Price select product;
            List<ProductViewModel> viewModels = new();
            foreach (var model in sortProducts)
            {
                ProductViewModel viewModel = new()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Price = model.Price,
                    Brand = model.BrandName,
                    Count = model.Count,
                    TitleImagePath = model.TitleImagePath,
                    ClothingType = model.ClothingTypeName,
                    SizeName = model.SizeName
                };
                viewModels.Add(viewModel);
            }
            return View(new ProductListViewModel { Products = viewModels });
        }
        public async Task<IActionResult> SortByCoutn(int count)
        {
            List<Product>? products = await _context.Products.ToListAsync();
            var sortProducts = from product in products where product.Count > count select product;
            List<ProductViewModel> viewModels = new();
            foreach (var model in sortProducts)
            {
                ProductViewModel viewModel = new()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Price = model.Price,
                    Brand = model.BrandName,
                    Count = model.Count,
                    TitleImagePath = model.TitleImagePath,
                    ClothingType = model.ClothingTypeName,
                    SizeName = model.SizeName
                };
                viewModels.Add(viewModel);
            }
            return View(new ProductListViewModel { Products = viewModels });
        }
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }
            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SizeId,BrandId,Count,Price,TitleImagePath")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = Guid.NewGuid();
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,SizeId,BrandId,Count,Price,TitleImagePath")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
          return _context.Products.Any(e => e.Id == id);
        }
    }
}
