using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pu_backend_cs.Data;
using pu_backend_cs.Models;

namespace pu_backend_cs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UbicationController : ControllerBase
    {
        private readonly DataContext _context;

        public UbicationController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("placeOrder")]
        public async Task<IActionResult> PlaceOrder([FromBody] Ubication ubicationModel)
        {
            try
            {
                // Crear nueva orden
                var newUbication = new Ubication
                {
                    tower = ubicationModel.tower,
                    floor = ubicationModel.floor,
                };
                _context.Ubications.Add(newUbication);
                await _context.SaveChangesAsync();

                return Ok(new { success = true, message="Wonderfull" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, new { success = false, message = "Error" });
            }
        }
    }
}