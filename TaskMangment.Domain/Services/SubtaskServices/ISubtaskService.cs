using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Domain
{
    public interface ISubtaskService
    {
        public void AddSubtask(CreateSubtaskDto subtaskDto);
        public IEnumerable<ReadSubtaskDto> GetAllSubtasks();
        public ReadSubtaskDto? GetSubtask(int subtaskId);
        public void UpdateSubtask(UpdateSubtaskDto subtask);
        public void DeleteSubtask(int subtaskId);
    }
}
