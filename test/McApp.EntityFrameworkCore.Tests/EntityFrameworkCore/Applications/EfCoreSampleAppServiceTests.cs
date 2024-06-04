using McApp.Samples;
using Xunit;

namespace McApp.EntityFrameworkCore.Applications;

[Collection(McAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<McAppEntityFrameworkCoreTestModule>
{

}
