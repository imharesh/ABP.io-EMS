using System;
using System.Threading.Tasks;
using Acme.EMS.Employees;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.EMS
{
    public class EMSDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Employee, Guid> _employeeRepository;

        public EMSDataSeederContributor(IRepository<Employee, Guid> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _employeeRepository.GetCountAsync() <= 0)
            {
                await _employeeRepository.InsertAsync(
                    new Employee
                    {
                        Name = "Haresh",
                        DOB = new DateTime(1995, 9, 27)

                    },
                    autoSave: true
                );

                await _employeeRepository.InsertAsync(
                    new Employee
                    {
                        Name = "Henil",
                        DOB = new DateTime(2000, 9, 27)
                    },
                    autoSave: true
                );
            }
        }
    }
}
