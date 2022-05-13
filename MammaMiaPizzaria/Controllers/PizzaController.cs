using MammaMiaPizzaria.Models;
using MammaMiaPizzaria.Utils;
using Microsoft.AspNetCore.Mvc;

namespace MammaMiaPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]                                                   //dichiariamo che questo metodo vuole fare una GET                                   
        public IActionResult ListinoPizze()
        {
            List<Pizza> Pizze = PizzaData.GetPizze();
            return View("ListinoPizze", Pizze);
        }
    }
}
