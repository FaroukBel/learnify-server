// Controllers/UserOrderController.cs
using learnify.Data;
using learnify.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UserOrderController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public UserOrderController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserOrder>>> GetUserOrders()
    {
        return await _context.UserOrders.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserOrder>> GetUserOrder(int id)
    {
        var userorder = await _context.UserOrders.FindAsync(id);

        if (userorder == null)
        {
            return NotFound();
        }

        return userorder;
    }

   

    [HttpPost]
    public async Task<ActionResult<UserOrder>> PostUserOrder(UserOrder userorder)
    {
        _context.UserOrders.Add(userorder);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUserOrder", new { id = userorder.id }, userorder);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutUserOrder(int id, UserOrder userorder)
    {
        if (id != userorder.id)
        {
            return BadRequest();
        }

        _context.Entry(userorder).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUserOrder(int id)
    {
        var userorder = await _context.UserOrders.FindAsync(id);

        if (userorder == null)
        {
            return NotFound();
        }

        _context.UserOrders.Remove(userorder);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
