using Microsoft.AspNetCore.Mvc;

namespace lista_de_computadores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComputadorController: ControllerBase
    {

        [HttpGet]
        public IActionResult Get() {
            return Ok("André");
        }

    }
}