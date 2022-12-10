using ClothingStore.Domain;
using ClothingStore.Model.Products;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ProductViewModel> productsViewModels = new();
            var products = _context.Products.ToList();
            foreach (var product in products)
            {
                ProductViewModel model = new()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Count = product.Count
                };
                productsViewModels.Add(model);
            }
            return View(new ProductListViewModel { Products = productsViewModels });
        }
    }
}
