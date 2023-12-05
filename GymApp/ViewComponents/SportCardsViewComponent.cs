using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class SportCardsViewComponent : ViewComponent
    {
        private readonly IBranchService _BranchService;
        private readonly IMemberService _memberService;
        private readonly UserManager<AppUser> _userManager;

        public SportCardsViewComponent(IBranchService BranchService, IMemberService memberService, UserManager<AppUser> userManager)
        {
            _BranchService = BranchService;
            _memberService = memberService;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<List<Branch>> GetItemsAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity!.Name);
            var member = _memberService.GetByEmail(user.Email);

            return await Task.FromResult(_BranchService!.GetAllByMember(member.MemberId));
        }
    }
}
