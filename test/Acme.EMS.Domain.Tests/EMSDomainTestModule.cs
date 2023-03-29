using Acme.EMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.EMS;

[DependsOn(
    typeof(EMSEntityFrameworkCoreTestModule)
    )]
public class EMSDomainTestModule : AbpModule
{

}
