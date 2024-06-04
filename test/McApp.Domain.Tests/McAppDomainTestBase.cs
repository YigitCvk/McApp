using Volo.Abp.Modularity;

namespace McApp;

/* Inherit from this class for your domain layer tests. */
public abstract class McAppDomainTestBase<TStartupModule> : McAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
