using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    [Route("Prod")]
    public class ProudctControllers:Controller
    {
        public IActionResult ActionJison ()
        {
            return Json("Hello From Json Action ");
        }
    }
}
