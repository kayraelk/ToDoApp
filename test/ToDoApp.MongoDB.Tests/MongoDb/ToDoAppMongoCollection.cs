using Xunit;

namespace ToDoApp.MongoDB;

[CollectionDefinition(ToDoAppTestConsts.CollectionDefinitionName)]
public class ToDoAppMongoCollection : ToDoAppMongoDbCollectionFixtureBase
{

}
