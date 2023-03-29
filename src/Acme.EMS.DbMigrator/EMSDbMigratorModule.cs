using Acme.EMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.EMS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EMSEntityFrameworkCoreModule),
    typeof(EMSApplicationContractsModule)
    )]
public class EMSDbMigratorModule : AbpModule
{

}
