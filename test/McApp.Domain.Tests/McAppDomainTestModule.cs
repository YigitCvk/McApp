using Volo.Abp.Modularity;

namespace McApp;

[DependsOn(
    typeof(McAppDomainModule),
    typeof(McAppTestBaseModule)
)]
public class McAppDomainTestModule : AbpModule
{

}
