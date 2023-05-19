using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empid { get; set; }
        public string empnip { get; set; }
        public string empname { get; set; }
        public int deptid { get; set; }
        
    }
}
