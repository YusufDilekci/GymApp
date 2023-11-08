using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        [Route("/Product/{id?}")]
        public IActionResult Index(int subcategoryId)
        {
            var products = _productService.GetAllBySubCategory(subcategoryId);
            
            return View(products);
        }
        
        public IActionResult Details(int productId)
        {
            var product = _productService.GetById(productId);
            return View(product);
        }
    }
}
