using System;
using Volo.Abp.Application.Dtos;

namespace Acme.EMS.Employees
{
    public class EmployeeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public DateTime DOB { get; set; }
    }
}
