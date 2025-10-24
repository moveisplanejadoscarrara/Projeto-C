using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moveis_Carrara.Data;
using Moveis_Carrara.Models;

namespace Moveis_Carrara.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginViewModel();
            ViewBag.Title = "Login";
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Buscar usuário no banco
                var usuario = _context.Usuarios
                    .Include(u => u.Pessoa)
                    .FirstOrDefault(u => u.UsuarioNome == model.Email &&
                                        u.UsuarioSenha == model.Senha);

                if (usuario != null)
                {
                    // Login bem-sucedido
                    TempData["Mensagem"] = $"Bem-vindo, {usuario.Pessoa.Nome}!";
                    TempData["UsuarioNome"] = usuario.Pessoa.Nome;
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.Erro = "Usuário ou senha inválidos";
            }

            ViewBag.Title = "Login";
            return View(model);
        }

        public IActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Login");
        }
    }
}