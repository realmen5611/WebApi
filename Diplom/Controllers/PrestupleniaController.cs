using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class PrestupleniaController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prestuplenia.ToList();
            return Ok(list);
        }

        [HttpGet("{idPrestuplenia}")]
        public IActionResult GetById(int idPrestuplenia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prestuplenia.FirstOrDefault(x => x.idPrestuplenia == idPrestuplenia);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(PrestupleniaEntity prestupleniaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prestuplenia.Add(prestupleniaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(PrestupleniaEntity prestupleniaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prestuplenia.Update(prestupleniaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idPrestuplenia}")]
        public IActionResult Delete(int idPrestuplenia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.prestuplenia.FirstOrDefault(x => x.idPrestuplenia == idPrestuplenia);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.prestuplenia.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
