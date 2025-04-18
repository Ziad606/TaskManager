using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMangment.Domain;

namespace TaskMangment.Domain
{
    public interface ITaskService
    {
        public void AddTask(CreateTaskDto taskDto);
        public IEnumerable<ReadTaskDto> GetAllTasks();
        public ReadTaskDto? GetTask(int taskId);
        public void UpdateTask(UpdateTaskDto task);
        public void DeleteTask(int taskId);
    }
}
