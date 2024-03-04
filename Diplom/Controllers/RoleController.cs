using Diplom.Model;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class RoleController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.role.ToList();
            return Ok(list);
        }

        [HttpGet("{idRole}")]
        public IActionResult GetById(int idRole)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.role.FirstOrDefault(x => x.idRole == idRole);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(RoleEntity roleEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.role.Add(roleEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(RoleEntity roleEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.role.Update(roleEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idRole}")]
        public IActionResult Delete(int idRole)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.role.FirstOrDefault(x => x.idRole == idRole);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.role.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
