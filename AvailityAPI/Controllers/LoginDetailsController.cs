using AvailityAPI.Domain.Entities;
using AvailityAPI.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvailityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginDetailsController : ControllerBase
    {
        private readonly LoginDetailContext _context;

        public LoginDetailsController(LoginDetailContext context)
        {
            _context = context;
        }

        // GET: api/LoginDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginDetail>>> GetLoginDetails()
        {
            return await _context.LoginDetails.ToListAsync();
        }

        // GET: api/LoginDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoginDetail>> GetLoginDetail(int id)
        {
            var loginDetail = await _context.LoginDetails.FindAsync(id);

            if (loginDetail == null)
            {
                return NotFound();
            }

            return loginDetail;
        }

        // PUT: api/LoginDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoginDetail(int id, LoginDetail loginDetail)
        {
            if (id != loginDetail.UserId)
            {
                return BadRequest();
            }

            _context.Entry(loginDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginDetailExists(id))
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

        // POST: api/LoginDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoginDetail>> PostLoginDetail(LoginDetail loginDetail)
        {
            _context.LoginDetails.Add(loginDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoginDetail", new { id = loginDetail.UserId }, loginDetail);
        }

        // DELETE: api/LoginDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoginDetail(int id)
        {
            var loginDetail = await _context.LoginDetails.FindAsync(id);
            if (loginDetail == null)
            {
                return NotFound();
            }

            _context.LoginDetails.Remove(loginDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoginDetailExists(int id)
        {
            return _context.LoginDetails.Any(e => e.UserId == id);
        }
    }
}
