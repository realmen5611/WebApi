using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class SanctionController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.sanction.ToList();
            return Ok(list);
        }

        [HttpGet("{idSanction}")]
        public IActionResult GetById(int idSanction)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.sanction.FirstOrDefault(x => x.idSanction == idSanction);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(SanctionEntity sanctionEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.sanction.Add(sanctionEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(SanctionEntity sanctionEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.sanction.Update(sanctionEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idSanction}")]
        public IActionResult Delete(int idSanction)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.sanction.FirstOrDefault(x => x.idSanction == idSanction);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.sanction.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
