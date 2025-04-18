using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public class TaskRepo : ITaskRepo
    {
        private readonly ApplicationDbContext _context;
        public TaskRepo(ApplicationDbContext context)
        {
            _context = context;
        }


        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
        public Task? GetTask(int taskId)
        {
            return _context.Tasks.FirstOrDefault(task => task.ID == taskId);
        }
        public IEnumerable<Task> GetAllTasks()
        {
            return _context.Tasks.ToList();

        }
        public void UpdateTask(Task task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();

        }

        public void DeleteTask(int taskId)
        {
            Task task = _context.Tasks.FirstOrDefault(task => task.ID == taskId);
            if (task == null) return;
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

    }
}
