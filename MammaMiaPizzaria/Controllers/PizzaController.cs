using Microsoft.AspNetCore.Mvc;

namespace MammaMiaPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]                                                   //dichiariamo che questo metodo vuole fare una GET
        [Route("/ListinoPizze")]                                    //Dichiariamo qual'è il path da seguire per questo metodo
        public IActionResult ListinoPizze()
        {
            return View("Listino-Pizze");
        }
    }
}
