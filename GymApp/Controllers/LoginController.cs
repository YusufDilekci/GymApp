﻿using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using GymApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace GymApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private IMemberService _memberService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;

        public LoginController(IMemberService memberService, SignInManager<AppUser> signInManager, IUserService userService)
        {
            _memberService = memberService;
            _signInManager = signInManager;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel p)
        {
            if(ModelState.IsValid)
            {
              
                var user = _userService.GetByEmail(p.Email);
                var result = await _signInManager.PasswordSignInAsync(user.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Member");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
           
            return View();
        }

        //[HttpPost]  For HttpContext.SıgnInAsync()

        //public async Task<IActionResult> Index(LoginViewModel model)
        //{
        //    var member = _memberService.GetByEmailAndPassword(model.Email, model.Password);
        //    if (member != null)
        //    {
        //        //HttpContext.Session.SetString("username", model.Email);
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, member.MemberEmail)
        //        };

        //        var userIdentity = new ClaimsIdentity(claims, "a");
        //        ClaimsPrincipal principal= new ClaimsPrincipal(userIdentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "Member");
        //    }
        //    return View();

        //}
    }
}
