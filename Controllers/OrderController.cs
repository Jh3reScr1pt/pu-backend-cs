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
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("placeOrder")]
        public async Task<IActionResult> PlaceOrder([FromBody] Order orderModel)
        {
            try
            {
                _context.Orders.Add(orderModel);
                await _context.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok"});
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message});
            }
        }

    }
}