using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartLineService _cartLineService;
        private IMemberService _memberService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserService _userService;
        public CartController(ICartService cartService, ICartLineService cartLineService, IMemberService memberService, IUserService userService) 
        {
            _cartService = cartService;
            _cartLineService = cartLineService;
            _memberService = memberService;
            _userService = userService;
        }
        public async Task<IActionResult> Index()
        {
            var username = User.Identity!.Name;
  
            var user = _userService.GetByName(username);

            var member = _memberService.GetByEmail(user.Email);
            var cart = _cartService.GetByMember(member.MemberId);
            var cartLines = _cartLineService.GetAllWithProductByCart(cart.CartId);

            ViewBag.TotalPrice = _cartService.TotalPrice(cart.CartId);

            return View(cartLines);
        }
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            CartLine newCartLine = new CartLine();

            var username = User.Identity!.Name;
            var user = _userService.GetByName(username);
            var member = _memberService.GetByEmail(user.Email);
            var cart = _cartService.GetByMember(member.MemberId);
            var cartline = _cartLineService.GetByCartAndProduct(cart.CartId, productId);

            if (cartline == null)
            {
                newCartLine.ProductId = productId;
                newCartLine.CartId = cart.CartId;
                newCartLine.Quantity = quantity;

                _cartLineService.Add(newCartLine);

                return RedirectToAction("Index");
            }

            cartline.Quantity += quantity;
            _cartLineService.Update(cartline);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int cartLineId)
        {
            var cartline = _cartLineService.GetById(cartLineId);
            _cartLineService.Delete(cartline);

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(ShippingDetail s)
        {
            if(ModelState.IsValid)
            {
                return NotFound();
            }
            return View();
        }
    }
}
