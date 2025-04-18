using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMangment.Data;
using Task = TaskMangment.Data.Task;


namespace TaskMangment.Domain
{
    public class TaskeService : ITaskService
    {
        private readonly ITaskRepo _taskRepo;
        public TaskeService(ITaskRepo taskRepo)
        {
            _taskRepo = taskRepo;
        }
        public void AddTask(CreateTaskDto taskDto)
        {
            Task taskDb = new Task();
            taskDb.Name = taskDto.Name;
            taskDb.Description = taskDto.Description;
            taskDb.Duration = taskDto.Duration;
            taskDb.StartDate = taskDb.StartDate;
            taskDb.EndDate = taskDb.EndDate;

            _taskRepo.AddTask(taskDb);
        }
        public IEnumerable<ReadTaskDto> GetAllTasks()
        {
            var tasks = _taskRepo.GetAllTasks();

            return tasks.Select(task => new ReadTaskDto
            {
                Name = task.Name,
                Description = task.Description,
                Duration = task.Duration,
                StartDate = task.StartDate,
                EndDate = task.EndDate
            });
        }
        public ReadTaskDto? GetTask(int taskId)
        {
            Task taskDb = _taskRepo.GetTask(taskId);
            if (taskDb == null) return null;
                return new ReadTaskDto
                {
                    Name = taskDb.Name,
                    Description = taskDb.Description,
                    Duration = taskDb.Duration,
                    StartDate = taskDb.StartDate,
                    EndDate = taskDb.EndDate
                };
        }
        public void UpdateTask(UpdateTaskDto taskDto)
        {
            Task taskDb = new Task()
            {
                ID = taskDto.ID,
                Name = taskDto.Name,
                Description = taskDto.Description,
                Duration = taskDto.Duration,
                StartDate = taskDto.StartDate,
                EndDate = taskDto.EndDate
            }; 

            _taskRepo.UpdateTask(taskDb);
        }
        public void DeleteTask(int taskId)
        {
            _taskRepo.DeleteTask(taskId);
        }
    }
}
