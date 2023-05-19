using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeService.Models;
namespace EmployeeService.DTO
{
    public class EmployeeDTO
    {
        public int empid { get; set; }
        public string empnip { get; set; }
        public string empname { get; set; }
        public int deptid { get; set; }
    }
}
