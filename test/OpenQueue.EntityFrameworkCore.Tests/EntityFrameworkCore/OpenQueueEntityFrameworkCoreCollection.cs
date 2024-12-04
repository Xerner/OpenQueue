using Xunit;

namespace OpenQueue.EntityFrameworkCore;

[CollectionDefinition(OpenQueueTestConsts.CollectionDefinitionName)]
public class OpenQueueEntityFrameworkCoreCollection : ICollectionFixture<OpenQueueEntityFrameworkCoreFixture>
{

}
