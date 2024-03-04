using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class NarushiteliController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narushiteli.ToList();
            return Ok(list);
        }

        [HttpGet("{idNarushiteli}")]
        public IActionResult GetById(int idNarushiteli)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narushiteli.FirstOrDefault(x => x.idNarushiteli == idNarushiteli);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(NarushiteliEntity narushiteliEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narushiteli.Add(narushiteliEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(NarushiteliEntity narushiteliEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narushiteli.Update(narushiteliEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idNarushiteli}")]
        public IActionResult Delete(int idNarushiteli)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.narushiteli.FirstOrDefault(x => x.idNarushiteli == idNarushiteli);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.narushiteli.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
