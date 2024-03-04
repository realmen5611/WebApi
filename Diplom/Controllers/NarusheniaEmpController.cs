using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class NarusheniaEmpController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narusheniaEmp.ToList();
            return Ok(list);
        }

        [HttpGet("{idNarusheniaEmp}")]
        public IActionResult GetById(int idNarusheniaEmp)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narusheniaEmp.FirstOrDefault(x => x.idNarusheniaEmp == idNarusheniaEmp);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(NarusheniaEmpEntity NarusheniaEmpEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narusheniaEmp.Add(NarusheniaEmpEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(NarusheniaEmpEntity NarusheniaEmpEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.narusheniaEmp.Update(NarusheniaEmpEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idNarusheniaEmp}")]
        public IActionResult Delete(int idNarusheniaEmp)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.narusheniaEmp.FirstOrDefault(x => x.idNarusheniaEmp == idNarusheniaEmp);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.narusheniaEmp.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
