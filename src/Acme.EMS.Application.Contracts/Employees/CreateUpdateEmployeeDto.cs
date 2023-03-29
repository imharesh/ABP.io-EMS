using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.EMS.Employees
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; } = DateTime.Now;
    }
}
