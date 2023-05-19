using AutoMapper;
using EmployeeService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeService.DTO;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;
        public EmployeeController(DataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {

            var query = await _db.Employee.ToListAsync();
            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeAddressDTO emp)
        {
            var newEmp = _mapper.Map<EmployeeAddress>(emp);
            _db.EmployeeAddress.Add(newEmp);
            await _db.SaveChangesAsync();
            return Created($"/{newEmp.empid}", newEmp);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeDTO emp)
        {
            var updateEmployee = _mapper.Map<Employee>(emp);
            _db.Employee.Update(updateEmployee);
            await _db.SaveChangesAsync();
            return Ok(updateEmployee);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var empToDel = await _db.Employee
            .Where(_ => _.empid == id).FirstOrDefaultAsync();
            if (empToDel == null)
            {
                return NotFound();
            }
            _db.Employee.Remove(empToDel);
            await _db.SaveChangesAsync();
            return NoContent();
        }

    }
}
