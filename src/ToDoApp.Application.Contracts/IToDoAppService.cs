using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ToDoApp
{
    public interface IToDoAppService : IApplicationService
    {
        Task<List<ToDoItemDto>> GetListAsync();
        Task<ToDoItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}
