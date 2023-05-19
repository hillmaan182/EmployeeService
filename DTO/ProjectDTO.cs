using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeService.DTO
{
    public class ProjectDTO
    {
        public string projectname { get; set; }
        public int empid { get; set; }
        public int deptid { get; set; }
    }
}
