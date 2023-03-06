using ToDoApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ToDoApp.Blazor;

public abstract class ToDoAppComponentBase : AbpComponentBase
{
    protected ToDoAppComponentBase()
    {
        LocalizationResource = typeof(ToDoAppResource);
    }
}
