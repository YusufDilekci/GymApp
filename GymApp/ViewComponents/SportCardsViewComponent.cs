using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class SportCardsViewComponent : ViewComponent
    {
        private readonly IBranchService _BranchService;
        private readonly IMemberService _memberService;

        public SportCardsViewComponent(IBranchService BranchService, IMemberService memberService)
        {
            _BranchService = BranchService;
            _memberService = memberService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Branch>> GetItemsAsync()
        {
            var email = User.Identity!.Name;
            var member = _memberService.GetByEmail(email);
            return Task.FromResult(_BranchService!.GetAllByMember(member.MemberId));
        }
    }
}
