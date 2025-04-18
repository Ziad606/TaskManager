using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public interface ISubtaskRepo
    {
        public void AddSubtask(Subtask subtask);
        public Subtask? GetSubtask(int subtaskId);
        public IEnumerable<Subtask> GetAllSubtasks();
        public void UpdateSubtask(Subtask subtask);

        public void DeleteSubtask(int subtaskId);
    }
}
