using ClothingStore.Domain;
using ClothingStore.Domain.Entities;
using ClothingStore.Models.Sales;
using ClothingStore.TestData.Employees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Controllers
{
    public class SalesController : Controller
    {
        private readonly AppDbContext _context;

        public SalesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Sale> sales = await _context.Sales.ToListAsync();
            List<SaleViewModel> salesViewModel = new();
            foreach (var sale in sales)
            {
                SaleViewModel model = new()
                { 
                    Id = sale.Id,
                    DateOfSale = sale.DateOfSale,
                    Price = sale.Price,
                    ProductId = sale.ProductId,
                    ProductName = sale.ProductName,
                    TitleImagePath = sale.TitleImagePath,
                    EmpolyeeName = sale.EmployeeName
                };
                salesViewModel.Add(model);
            }
            return View(new SaleListViewModel { Sales = salesViewModel });
        }
        public async Task<IActionResult> Sale(Guid Id)
        {
            Product? product = await _context.Products.FindAsync(Id);
            if (product != null)
            {
                Sale sale = new()
                {
                    ProductId = Id,
                    Price = product.Price,
                    TitleImagePath = product.TitleImagePath,
                    ProductName = product.Name
                };
                _context.Sales.Add(sale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SalesController.Index));
            }
            return View();

        }
        public async Task<IActionResult> Delete(Guid Id)
        {
            Sale sale = await _context.Sales.FindAsync(Id);
            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SalesController.Index));
        }
    }
}
