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

        // GET: Brands
        public async Task<IActionResult> Index()
        {
            List<Sale> sales = await _context.Sales.ToListAsync();
            List<SaleViewModel> salesList = new();
            foreach (var sale in sales)
            {
                SaleViewModel model = new()
                { 
                    Id = sale.Id,
                    EmployeeId = sale.EmployeeId,
                    DateOfSale = sale.DateOfSale,
                    EmployeeName = sale.EmployeeName,
                    Products = sale.Products
                };
                salesList.Add(model);
            }
            return View(new SaleListViewModel { Sales = salesList });
        }
    }
}
