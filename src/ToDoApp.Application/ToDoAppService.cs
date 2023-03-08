using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ToDoApp
{
    public class ToDoAppService : ToDoAppAppService, IToDoAppService
    {
        private readonly IRepository<ToDoItem, Guid> _toDoItemRepository;

        public ToDoAppService(IRepository<ToDoItem, Guid> toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
        }
        public async Task<List<ToDoItemDto>> GetListAsync()
        {
            var items = await _toDoItemRepository.GetListAsync();
            return ObjectMapper.Map<List<ToDoItem>, List<ToDoItemDto>>(items);  
        }
        public async Task<ToDoItemDto> CreateAsync(string text)
        {
            var toDoItem = await _toDoItemRepository.InsertAsync(
                new ToDoItem
                {
                    Text = text
                });
            return ObjectMapper.Map<ToDoItem,ToDoItemDto>(toDoItem);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _toDoItemRepository.DeleteAsync(id);
        }
    }
}
