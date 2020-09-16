using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneLinkCompany.Models
{
    public class DepartmentAssignment
    {
        [Key]
        public int EmployeeID { get; set; }
        [StringLength(50)]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        public Employee Employee { get; set; }
    }
}