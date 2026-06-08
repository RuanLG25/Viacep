using Microsoft.AspNetCore.Mvc;
using ViaCep.Models;

namespace ViaCep.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EnderecoViewModel model)
        {
            TempData["NomeCompleto"] = model.NomeCompleto;
            TempData["Cpf"]          = model.Cpf;
            TempData["Cep"]          = model.Cep;
            TempData["Logradouro"]   = model.Logradouro;
            TempData["Bairro"]       = model.Bairro;
            TempData["Cidade"]       = model.Cidade;
            TempData["Uf"]           = model.Uf;

            return RedirectToAction("Detalhes");
        }

        public IActionResult Detalhes()
        {
            var model = new EnderecoViewModel
            {
                NomeCompleto = TempData["NomeCompleto"]?.ToString(),
                Cpf          = TempData["Cpf"]?.ToString(),
                Cep          = TempData["Cep"]?.ToString(),
                Logradouro   = TempData["Logradouro"]?.ToString(),
                Bairro       = TempData["Bairro"]?.ToString(),
                Cidade       = TempData["Cidade"]?.ToString(),
                Uf           = TempData["Uf"]?.ToString()
            };

            return View(model);
        }
    }
}