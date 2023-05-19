using AutoMapper;
using EmployeeService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeService.DTO;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        //Many to many

        private readonly DataContext _db;
        private readonly IMapper _mapper;
        public ProjectController(DataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var query = await _db.Project.Include(_ => _.Employee).Include(_ => _.Department).ToListAsync();
            return Ok(query);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var projectById = await _db.Project
            .Include(_ => _.Employee).Include(_ => _.Department).Where(_ => _.empid == id).FirstOrDefaultAsync();
            return Ok(projectById);
        }

        [HttpPost]
        public async Task<IActionResult> AddProject(ProjectDTO p)
        {
            var newEmp = _mapper.Map<Project>(p);
            _db.Project.Add(newEmp);
            await _db.SaveChangesAsync();
            return Created($"/{newEmp.empid}", newEmp);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(ProjectDTO proj)
        {
            var updateProj = _mapper.Map<Project>(proj);
            _db.Project.Update(updateProj);
            await _db.SaveChangesAsync();
            return Ok(updateProj);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var projToDel = await _db.Project
            .Include(_ => _.Employee).Where(_ => _.projectid == id).FirstOrDefaultAsync();
            if (projToDel == null)
            {
                return NotFound();
            }
            _db.Project.Remove(projToDel);
            await _db.SaveChangesAsync();
            return NoContent();
        }

    }
}
