using Volo.Abp.Modularity;

namespace Acme.EMS;

[DependsOn(
    typeof(EMSApplicationModule),
    typeof(EMSDomainTestModule)
    )]
public class EMSApplicationTestModule : AbpModule
{

}
