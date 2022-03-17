using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using pizza_mama.Models;
using pizza_mama.Data;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.controllers
{
    [Route("[controller]")]
    [ApiController]
    public class APIController : Controller
    {
        DataContext dataContext;
       public APIController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        
        [HttpGet]
        [Route("GetPizzas")]

        public IActionResult GetPizzas()
        {
           var pizzas = dataContext.Pizzas.ToList();

            return Json(pizzas);
        }
    }
}
