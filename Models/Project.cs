using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmployeeService.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int projectid { get; set; }
        public string projectname { get; set; }

        public int empid { get; set; }
        [ForeignKey("empid")]
        public Employee Employee { get; set; }

        public int deptid { get; set; }
        [ForeignKey("deptid")]
        public Department Department { get; set; }

    }
}
