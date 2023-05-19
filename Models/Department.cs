using System.ComponentModel.DataAnnotations;

namespace EmployeeService.Models
{
    public class Department
    {
        [Key]
        public int deptid { get; set; }
        public string deptcode { get; set; }
        public string deptname { get; set; }
    }
}
