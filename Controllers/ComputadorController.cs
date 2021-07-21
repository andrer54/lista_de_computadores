using Microsoft.AspNetCore.Mvc;
using lista_de_computadores.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using lista_de_computadores.Models;
using Microsoft.EntityFrameworkCore;

namespace lista_de_computadores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComputadorController: ControllerBase
    {
        private readonly DataContext _repo;

        public ComputadorController(DataContext context){
            _repo = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Computador>>> Get() {
            try
            {
               return await _repo.Computador.ToListAsync();
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
            
        }

        //get: api/computador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Computador>> Get(int id) {
            try
            {
                var pc = await _repo.Computador.FindAsync(id);
               return pc;
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
            
        }

    }
}