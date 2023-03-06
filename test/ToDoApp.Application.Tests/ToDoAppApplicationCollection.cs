using ToDoApp.MongoDB;
using Xunit;

namespace ToDoApp;

[CollectionDefinition(ToDoAppTestConsts.CollectionDefinitionName)]
public class ToDoAppApplicationCollection : ToDoAppMongoDbCollectionFixtureBase
{

}
