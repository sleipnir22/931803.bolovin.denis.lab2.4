using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Lab4.Models;
using Lab4.Utils;
using Lab4.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Controllers {
    public class AccountController : Controller {
        private UserContext _userContext;

        public AccountController(UserContext context) {
            _userContext = context;
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model) {
            if (ModelState.IsValid) {
                var user = await _userContext.Users.FirstOrDefaultAsync(u =>
                    u.Email == model.Email && u.Password == model.Password);

                if (user != null) {
                    await Authenticate(model.Email);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Incorrect email or password");
            }

            return View();
        }

        [HttpGet]
        public IActionResult SignUp() {
            return View(new SignUpStep1Model());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpStep1Model model) {
            if (ModelState.IsValid) {
                HttpContext.Session.Set("SignUpStep1", model);

                return View("SignUpStep2");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUpStep2(SignUpStep2Model model) {
            if (ModelState.IsValid) {
                var step1Model = HttpContext.Session.Get<SignUpStep1Model>("SignUpStep1");

                var user = await _userContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user is null) {
                    _userContext.Users.Add(new User {
                        FirstName = step1Model.FirstName,
                        LastName = step1Model.LastName,
                        Email = model.Email,
                        BirthDay = step1Model.BirthDay,
                        Gender = step1Model.Gender,
                        Password = model.Password
                    });
                    await _userContext.SaveChangesAsync();

                    await Authenticate(model.Email);

                    return RedirectToAction("Profile", "Account");
                }

                ModelState.AddModelError("Email", "Email is already registered");
            }

            return View(model);
        }

        private async Task Authenticate(string userName) {
            var claims = new List<Claim> {
                new (ClaimsIdentity.DefaultNameClaimType, userName)
            };

            var id = new ClaimsIdentity(claims,"ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [Authorize]
        public async Task<IActionResult> Profile() {
            var user = await _userContext.Users.FirstOrDefaultAsync(u => u.Email == HttpContext.User.Identity.Name);
            if (user is null) {
                return RedirectToAction("Logout");
            }
            else {

                return View(new Profile {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    BirthDay = user.BirthDay,
                    Password = user.Password,
                    Gender = user.Gender
                });
            }
        }

        [HttpGet]
        public IActionResult Reset() {
            return View();
        }

        public async Task<IActionResult> Reset(ResetStep1Model model, string action) {
            if (ModelState.IsValid) {
                if (action == "Send me a code")
                {
                    var user = await _userContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                    if (user is null) {
                        ModelState.AddModelError("Email", "Email was not found");
                    }
                    else {
                        var code = new Random().Next(0, 10000);
                        HttpContext.Session.Set("ResetCode", code);
                        ModelState.AddModelError("Email", $"Code: {code:D4}");
                    }
                }
                else
                {
                    return View("ResetStep2");
                }
                
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetStep2(ResetStep2Model model)
        {
            if (ModelState.IsValid)
            {
                int code = HttpContext.Session.Get<int>("ResetCode");

                if (code == int.Parse(model.Code))
                {
                    ModelState.AddModelError("Code", "Code verified");
                }
                else
                {
                    ModelState.AddModelError("Code", "Invalid code");
                }
            }

            return View(model);
        }
    }
}
