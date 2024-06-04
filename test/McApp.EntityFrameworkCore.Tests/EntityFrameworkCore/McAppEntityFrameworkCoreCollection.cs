using Xunit;

namespace McApp.EntityFrameworkCore;

[CollectionDefinition(McAppTestConsts.CollectionDefinitionName)]
public class McAppEntityFrameworkCoreCollection : ICollectionFixture<McAppEntityFrameworkCoreFixture>
{

}
