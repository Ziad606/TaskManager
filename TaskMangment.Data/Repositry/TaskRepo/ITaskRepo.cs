using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public interface ITaskRepo
    {

        public void AddTask(Task task);
        public Task? GetTask(int taskId);
        public IEnumerable<Task> GetAllTasks();
        public void UpdateTask(Task task);

        public void DeleteTask(int taskId);
    }
}
