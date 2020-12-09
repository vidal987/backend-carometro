using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers

{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OcorrenciasController : ControllerBase
    {
        private readonly DataContext _context;

        public OcorrenciasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Ocorrencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ocorrencia>>> GetOcorrencias()
        {
            return await _context.Ocorrencias.ToListAsync();
        }

        // GET: api/Ocorrencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ocorrencia>> GetOcorrencia(int id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);

            if (ocorrencia == null)
            {
                return NotFound();
            }

            return ocorrencia;
        }

        // PUT: api/Ocorrencias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOcorrencia(int id, Ocorrencia ocorrencia)
        {
            if (id != ocorrencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(ocorrencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcorrenciaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ocorrencias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ocorrencia>> PostOcorrencia(Ocorrencia ocorrencia)
        {
            _context.Ocorrencias.Add(ocorrencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOcorrencia", new { id = ocorrencia.Id }, ocorrencia);
        }

        // DELETE: api/Ocorrencias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ocorrencia>> DeleteOcorrencia(int id)
        {
            var ocorrencia = await _context.Ocorrencias.FindAsync(id);
            if (ocorrencia == null)
            {
                return NotFound();
            }

            _context.Ocorrencias.Remove(ocorrencia);
            await _context.SaveChangesAsync();

            return ocorrencia;
        }

        private bool OcorrenciaExists(int id)
        {
            return _context.Ocorrencias.Any(e => e.Id == id);
        }
    }
}
