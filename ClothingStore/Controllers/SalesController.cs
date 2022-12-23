using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClothingStore.Domain;
using ClothingStore.Domain.Entities;
using ClothingStore.Models.Sales;

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
            if (sales != null)
            {
                List<SaleViewModel> salesList = new();
                foreach (var sale in sales)
                {
                    SaleViewModel model = new()
                    {
                        Id = sale.Id,
                        EmployeeId = sale.EmployeeId,
                        DateOfSale = sale.DateOfSale,
                        EmployeeName = sale.EmployeeName,
                        Products = sale.Products,
                        Price = sale.Price
                    };
                    salesList.Add(model);
                }
                return View(new SaleListViewModel { Sales = salesList });
            }
            return View();
        }
        public async Task<IActionResult> Sale(Guid id)
        {
            Product product = await _context.Products.FindAsync(id);
            Employee Genadiy = await _context.Employees.FirstOrDefaultAsync();
            Sale sale = new();
            sale.Id = Guid.NewGuid();
            product.SaleId = sale.Id;
            _context.Add(product);
            await _context.SaveChangesAsync();
            sale.EmployeeId = Genadiy.Id;
            sale.EmployeeName = Genadiy.FirstName + " " + Genadiy.LastName;
            sale.Price = product.Price;
            _context.Add(sale);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
