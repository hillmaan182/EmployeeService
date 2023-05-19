using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeService.DTO
{
    public class EmployeeAddressDTO
    {
        public string address { get; set; }
        public string city { get; set; }

        //[ForeignKey("empid")]
        public int empid { get; set; }
        [ForeignKey("empid")]
        public EmployeeDTO Employee { get; set; }

    }
}
