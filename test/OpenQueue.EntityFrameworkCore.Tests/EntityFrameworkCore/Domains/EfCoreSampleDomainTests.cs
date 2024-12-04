using OpenQueue.Samples;
using Xunit;

namespace OpenQueue.EntityFrameworkCore.Domains;

[Collection(OpenQueueTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OpenQueueEntityFrameworkCoreTestModule>
{

}
