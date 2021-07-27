using Microsoft.AspNetCore.Mvc;
using lista_de_computadores.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using lista_de_computadores.Models;
using Microsoft.EntityFrameworkCore;

using System;


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
                
                return BadRequest();
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
                
                return BadRequest(ex);
            }
            return BadRequest();
        }

        //CRIAR REGISTRO
        [HttpPost]
        public async Task<ActionResult<Computador>> PostComputador(Computador computador)
        {
            _repo.Computador.Add(computador);
            await _repo.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(Get), new { id = computador.id }, computador);
        }

        //UPDATE REGISTRO
                [HttpPost("{id}")]
        public async Task<ActionResult<Computador>> updateComputador(Computador computador) {
            try
            {
                _repo.Computador.Update(computador);
                await _repo.SaveChangesAsync();

                
                return Ok();


            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex);
            }
           // return BadRequest();
        }

        //DELETE COMPUTADOR
        [HttpPost("delete/{id}")]
        public async Task<ActionResult<Computador>> DeleteComputador(int id) {
            try
            {
                var pc = await _repo.Computador.FindAsync(id);
                _repo.Computador.Remove(pc);
            
                await _repo.SaveChangesAsync();

               return Ok();
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex);
            }
            return BadRequest();
        }
        

    }
}