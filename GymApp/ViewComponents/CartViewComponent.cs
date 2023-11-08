using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private ICartLineService _cartLineService;
        private IMemberService _memberService;
        private ICartService _cartService;
        private readonly UserManager<AppUser> _userManager;
        public CartViewComponent(ICartLineService cartLineService, IMemberService memberService, ICartService cartService, UserManager<AppUser> userManager) 
        {
            _cartLineService= cartLineService;
            _memberService= memberService;
            _cartService= cartService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }
        
        private async Task<List<CartLine>> GetItemsAsync()
        {
            var username = User.Identity!.Name;
            var user = await _userManager.FindByNameAsync(username);
            var member = _memberService.GetByEmail(user.Email);
            var cart = _cartService.GetByMember(member.MemberId);
            return await Task.FromResult(_cartLineService.GetAllWithProductByCart(cart.CartId));
        }
    }
}
