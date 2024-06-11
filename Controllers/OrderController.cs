using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

                return StatusCode(StatusCodes.Status200OK, new { message = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpGet("listOrders")]
        public async Task<IActionResult> ListOrders()
        {
            try
            {
                var orders = await _context.Orders
                    .Include(o => o.items) // Incluir los items relacionados
                    .ToListAsync();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
        [HttpPost("updateOrderStatus")]
        public async Task<IActionResult> UpdateOrderStatus(int id, string status)
        {
            try
            {
                var order = await _context.Orders.FindAsync(id);
                if (order == null)
                {
                    return NotFound(new { message = "Order not found" });
                }

                order.status = status;
                await _context.SaveChangesAsync();

                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
        [HttpGet("userOrders/{userId}")]
        public async Task<IActionResult> GetUserOrders(string userId)
        {
            try
            {
                var orders = await _context.Orders
                    .Include(o => o.items) // Incluir los items relacionados
                    .Where(o => o.userId == userId)
                    .ToListAsync();

                if (orders == null || orders.Count == 0)
                {
                    return NotFound(new { message = "No orders found for this user" });
                }

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
