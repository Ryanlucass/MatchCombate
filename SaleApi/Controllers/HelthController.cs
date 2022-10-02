using Microsoft.AspNetCore.Mvc;
using System;

namespace SaleApi.Controllers
{
    public class HelthController : Controller
    {

        [HttpGet]
        public IActionResult Helth() => Ok(new { Testing = true, DateTime = DateTime.Now });
        
    }
}
