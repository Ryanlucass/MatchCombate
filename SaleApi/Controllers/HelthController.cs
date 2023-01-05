using Microsoft.AspNetCore.Mvc;
using System;

namespace SaleApi.Controllers
{
    [Route("api/[controller]")]
    public class HelthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Helth() => Ok(new { Testing = true, DateTime = DateTime.Now });
        
    }
}
