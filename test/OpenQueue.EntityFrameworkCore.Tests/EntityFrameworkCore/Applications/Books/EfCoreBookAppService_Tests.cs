using OpenQueue.Books;
using Xunit;

namespace OpenQueue.EntityFrameworkCore.Applications.Books;

[Collection(OpenQueueTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<OpenQueueEntityFrameworkCoreTestModule>
{

}