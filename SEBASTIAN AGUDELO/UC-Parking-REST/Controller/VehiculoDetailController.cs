using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UC_Parking_REST.Models;

namespace UC_Parking_REST.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoDetailController : ControllerBase
    {
        private readonly VehiculoDetailContext _context;

        public VehiculoDetailController(VehiculoDetailContext context)
        {
            _context = context;
        }

        // GET: api/VehiculoDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehiculoDetail>>> GetVehiculoDetails()
        {
            return await _context.VehiculoDetails.ToListAsync();
        }

        // GET: api/VehiculoDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehiculoDetail>> GetVehiculoDetail(int id)
        {
            var vehiculoDetail = await _context.VehiculoDetails.FindAsync(id);

            if (vehiculoDetail == null)
            {
                return NotFound();
            }

            return vehiculoDetail;
        }

        // PUT: api/VehiculoDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculoDetail(int id, VehiculoDetail vehiculoDetail)
        {
            if (id != vehiculoDetail.VHid)
            {
                return BadRequest();
            }

            _context.Entry(vehiculoDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoDetailExists(id))
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

        // POST: api/VehiculoDetail
        [HttpPost]
        public async Task<ActionResult<VehiculoDetail>> PostVehiculoDetail(VehiculoDetail vehiculoDetail)
        {
            _context.VehiculoDetails.Add(vehiculoDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculoDetail", new { id = vehiculoDetail.VHid }, vehiculoDetail);
        }

        // DELETE: api/VehiculoDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VehiculoDetail>> DeleteVehiculoDetail(int id)
        {
            var vehiculoDetail = await _context.VehiculoDetails.FindAsync(id);
            if (vehiculoDetail == null)
            {
                return NotFound();
            }

            _context.VehiculoDetails.Remove(vehiculoDetail);
            await _context.SaveChangesAsync();

            return vehiculoDetail;
        }

        private bool VehiculoDetailExists(int id)
        {
            return _context.VehiculoDetails.Any(e => e.VHid == id);
        }
    }
}
