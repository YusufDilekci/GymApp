using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;

//Comment Eklendiğinde Ürünün StarRateinin eş zamanlı olarak değişeceği TRIGGER OLUŞTURULACAK!! 

namespace GymApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICommentService _commentService;
        public ProductController(IProductService productService, ICommentService commentService)
        {
            _productService = productService;
            _commentService = commentService;
        }

        //[Route("/Product/{id?}")]
        public IActionResult Index(int subcategoryId)
        {
            var products = _productService.GetAllBySubCategory(subcategoryId);

            return View(products);
        }

        public IActionResult Details(int productId)
        {
            var product = _productService.GetById(productId);
            var comments = _commentService.GetAll();


            var model = new ProductCommentViewModel()
            {
                p = product,
                c = new Comment(),
                Comments = comments
            };

            ViewBag.msg = TempData["msg"] as string;

            return View(model);
        }

        [HttpPost]
        public IActionResult Review(ProductCommentViewModel model)
        {
            //NOTE AQ Binding Yapmaya Çalıştık Olmadı. İyi karşılanmadık!!

            if (model.p.ProductId != null && model.c.CommentDate != null && model.c.CommentTitle != null
                && model.c.CommentDescription != null && model.c.CommentStar != null)
            {
                Comment comment = new Comment()
                {
                    ProductId = model.p!.ProductId,
                    CommentDate = model.c!.CommentDate,
                    CommentTitle = model.c.CommentTitle,
                    CommentDescription = model.c.CommentDescription,
                    CommentStar = model.c.CommentStar
                };

                _commentService.Add(comment);

                TempData["msg"] = "true";
            }
            else
            {
                TempData["msg"] = "false";

            }

            return RedirectToAction("Details", "Product", new {productId=model.p.ProductId});
        }


    }
}



// TRIGGERI DECIMAL OLACAK SEKILDE ALTER ET
// KURSA DEVAM ET