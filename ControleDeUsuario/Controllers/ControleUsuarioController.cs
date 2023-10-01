using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleDeUsuario.Models;

namespace ControleDeUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //A classe ControleUsuarioController precisa ser linkada o mesmo nome no angular
    public class ControleUsuarioController : ControllerBase
    {
        private readonly ControleUsuarioContext _context;

        public ControleUsuarioController(ControleUsuarioContext context)
        {
            _context = context;
        }

        // GET: api/ControleUsuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ControleUsuario>>> GetControleUsuario()
        {
            if (_context.ControleUsuarios == null)
            {
                return NotFound();
            }
            return await _context.ControleUsuarios.ToListAsync();
        }

        // GET: api/ControleUsuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ControleUsuario>> GetControleUsuario(int id)
        {
            if (_context.ControleUsuarios == null)
            {
                return NotFound();
            }
            var controleUsuario = await _context.ControleUsuarios.FindAsync(id);

            if (controleUsuario == null)
            {
                return NotFound();
            }

            return controleUsuario;
        }

        // PUT: api/ControleUsuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutControleUsuario(int id, ControleUsuario controleUsuario)
        {
            if (id != controleUsuario.pessoaID)
            {
                return BadRequest();
            }

            _context.Entry(controleUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ControleUsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(await _context.ControleUsuarios.ToListAsync());
        }

        // POST: api/ControleUsuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ControleUsuario>> PostControleUsuario(ControleUsuario controleUsuario)
        {
            if (_context.ControleUsuarios == null)
            {
                return Problem("Entity set 'ControleUsuarioContext.ControleUsuario'  is null.");
            }
            _context.ControleUsuarios.Add(controleUsuario);
            await _context.SaveChangesAsync();

            return Ok(await _context.ControleUsuarios.ToListAsync());
        }

        // DELETE: api/ControleUsuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteControleUsuario(int id)
        {
            if (_context.ControleUsuarios == null)
            {
                return NotFound();
            }
            var controleUsuario = await _context.ControleUsuarios.FindAsync(id);
            if (controleUsuario == null)
            {
                return NotFound();
            }

            _context.ControleUsuarios.Remove(controleUsuario);
            await _context.SaveChangesAsync();

            return Ok(await _context.ControleUsuarios.ToListAsync());
        }

        private bool ControleUsuarioExists(int id)
        {
            return (_context.ControleUsuarios?.Any(e => e.pessoaID == id)).GetValueOrDefault();
        }
    }
}
