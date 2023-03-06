using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ToDoApp.Blazor;

[Dependency(ReplaceServices = true)]
public class ToDoAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToDoApp";
}
