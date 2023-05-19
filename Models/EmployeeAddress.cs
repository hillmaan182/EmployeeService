using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeService.Models
{
    public class EmployeeAddress
    {

        [Key]
        public int empaddressid { get; set; }
        public string address { get; set; }
        public string city { get; set; }

        public int empid  { get; set; }
        [ForeignKey("empid")]
        public Employee Employee { get; set; }

    }
}
