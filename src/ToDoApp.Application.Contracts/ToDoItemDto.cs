using System;
using Volo.Abp.Application.Dtos;

namespace ToDoApp
{
    public class ToDoItemDto : EntityDto<Guid>
    {
        public string Text { get; set; }
    }
}
