using MarvelHeroes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarvelHeroes.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class HeroesController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public HeroesController(ApplicationDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Hero>>> Get()
            {
                return await _context.Heroes.ToListAsync();
            }


            [HttpPost]
            public async Task<IActionResult> Post([FromBody] Hero hero)
            {
                _context.Heroes.Add(hero);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { id = hero.Id }, hero);
            }

        }
}
