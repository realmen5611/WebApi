using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class PolController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.pol.ToList();
            return Ok(list);
        }

        [HttpGet("{idPol}")]
        public IActionResult GetById(int idPol)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.pol.FirstOrDefault(x => x.idPol == idPol);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(PolEntity polEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.pol.Add(polEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(PolEntity polEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.pol.Update(polEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idPol}")]
        public IActionResult Delete(int idPol)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.pol.FirstOrDefault(x => x.idPol == idPol);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.pol.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
