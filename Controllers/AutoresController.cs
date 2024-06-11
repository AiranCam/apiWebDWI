using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi92.Services;

namespace WebApi92.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoresController : Controller
    {
        private readonly IAutorServices _autorServices;
        public AutoresController(IAutorServices autorServices)
        {
            _autorServices = autorServices;

        }
        [HttpGet]
        public async Task<IActionResult> GetAutores()
        {
            return Ok(await _autorServices.GetAutores());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AutorById(int id)
        {
            return Ok(await _autorServices.GetAutorById(id));
        }


        [HttpPost]
        public async Task<IActionResult> CrearAutor([FromBody]Autor autor)
        {
            return Ok(await _autorServices.CreateAutor(autor));
        }


        [HttpPut("{id}")]

        public async Task<IActionResult> EditAutor([FromBody] Autor autor, int id)
        {
            return Ok(await _autorServices.EditarAutor(autor, id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarAutor(int id)
        {
            return Ok(await _autorServices.EliminarAutor(id));
        }
    }
}