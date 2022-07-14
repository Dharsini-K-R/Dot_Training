using System.ComponentModel.DataAnnotations;

namespace MVCDATABASE.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int EmpId { get; set; }
    }
}
