﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class SportCardsViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IMemberService _memberService;

        public SportCardsViewComponent(ICategoryService categoryService, IMemberService memberService)
        {
            _categoryService = categoryService;
            _memberService = memberService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Category>> GetItemsAsync()
        {
            var email = User.Identity!.Name;
            var member = _memberService.GetByEmail(email);
            return Task.FromResult(_categoryService!.GetAllByMember(member.MemberId));
        }
    }
}