using ToDoApp.MongoDB;
using Volo.Abp.Modularity;

namespace ToDoApp;

[DependsOn(
    typeof(ToDoAppMongoDbTestModule)
    )]
public class ToDoAppDomainTestModule : AbpModule
{

}
