using OpenQueue.Samples;
using Xunit;

namespace OpenQueue.EntityFrameworkCore.Applications;

[Collection(OpenQueueTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OpenQueueEntityFrameworkCoreTestModule>
{

}
