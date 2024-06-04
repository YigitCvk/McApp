using Volo.Abp.Modularity;

namespace McApp;

public abstract class McAppApplicationTestBase<TStartupModule> : McAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
