using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class VidPrestupleniaController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.sanction.ToList();
            return Ok(list);
        }

        [HttpGet("{idVidPrestuplenia}")]
        public IActionResult GetById(int idVidPrestuplenia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.vidPrestuplenia.FirstOrDefault(x => x.idVidPrestuplenia == idVidPrestuplenia);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(VidPrestupleniaEntity vidPrestupleniaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.vidPrestuplenia.Add(vidPrestupleniaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(VidPrestupleniaEntity vidPrestupleniaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.vidPrestuplenia.Update(vidPrestupleniaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idVidPrestuplenia}")]
        public IActionResult Delete(int idVidPrestuplenia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.vidPrestuplenia.FirstOrDefault(x => x.idVidPrestuplenia == idVidPrestuplenia);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.vidPrestuplenia.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
