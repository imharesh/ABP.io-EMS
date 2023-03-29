using System.Threading.Tasks;

namespace Acme.EMS.Data;

public interface IEMSDbSchemaMigrator
{
    Task MigrateAsync();
}
