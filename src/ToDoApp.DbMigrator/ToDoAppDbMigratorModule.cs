using ToDoApp.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ToDoApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToDoAppMongoDbModule),
    typeof(ToDoAppApplicationContractsModule)
)]
public class ToDoAppDbMigratorModule : AbpModule
{

}
