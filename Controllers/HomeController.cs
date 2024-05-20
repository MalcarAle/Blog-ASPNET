using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok("Servidor online!");
        }
    }
}
