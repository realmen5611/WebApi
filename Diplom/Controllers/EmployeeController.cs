using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.employee.ToList();
            return Ok(list);
        }

        [HttpGet("{idEmployee}")]
        public IActionResult GetById(int idEmp)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.employee.FirstOrDefault(x => x.idEmployee == idEmp);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(EmployeeEntity empEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.employee.Add(empEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(EmployeeEntity empEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.employee.Update(empEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idEmployee}")]
        public IActionResult Delete(int idEmployee)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.employee.FirstOrDefault(x => x.idEmployee == idEmployee);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.employee.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
