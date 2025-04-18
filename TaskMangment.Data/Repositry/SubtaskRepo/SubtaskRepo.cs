using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public class SubtaskRepo : ISubtaskRepo
    {
        public ApplicationDbContext _context { get; set; }
        public SubtaskRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddSubtask(Subtask subtask)
        {
            _context.Subtasks.Add(subtask);
            _context.SaveChanges();
        }

        public Subtask? GetSubtask(int subtaskId)
        {
            return _context.Subtasks.FirstOrDefault(st => st.ID == subtaskId);
        }

        public IEnumerable<Subtask> GetAllSubtasks()
        {
            return _context.Subtasks.ToList();
        }

        public void UpdateSubtask(Subtask subtask)
        {
            _context.Subtasks.Update(subtask);
            _context.SaveChanges();
        }

        public void DeleteSubtask(int subtaskId)
        {
            var subtask = _context.Subtasks.FirstOrDefault(st => st.ID == subtaskId);
            if (subtask == null) return;

            _context.Subtasks.Remove(subtask);
            _context.SaveChanges();
        }

    }
}
