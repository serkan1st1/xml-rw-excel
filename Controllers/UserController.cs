using Microsoft.AspNetCore.Mvc;
using TaskMvc.Business;
using TaskMvc.Interface;
using TaskMvc.Models.Entities;

namespace TaskMvc.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register model, IFormFile profileImage)
        {
            if (ModelState.IsValid)
            {
                await _userService.RegisterUserAsync(model, profileImage);

                return RedirectToAction("Index", "Home");
            }
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage); // Hangi hata mesajının döndüğünü kontrol edin
                }
            }
            // Model geçersizse, formu yeniden göster
            return View();
        }
    }
}
