using McApp.Samples;
using Xunit;

namespace McApp.EntityFrameworkCore.Domains;

[Collection(McAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<McAppEntityFrameworkCoreTestModule>
{

}
