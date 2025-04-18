using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMangment.Data;

namespace TaskMangment.Domain
{
    public class SubtaskService : ISubtaskService
    {
        private readonly ISubtaskRepo _subtaskRepo;
        public SubtaskService(ISubtaskRepo subtaskRepo)
        {
            _subtaskRepo = subtaskRepo;
        }

        public void AddSubtask(CreateSubtaskDto subtaskDto)
        {
            var subtask = new Subtask
            {
                Name = subtaskDto.Name,
                Description = subtaskDto.Description,
                Duration = subtaskDto.Duration,
                TaskId = subtaskDto.TaskId
            };

            _subtaskRepo.AddSubtask(subtask);
        }

        public IEnumerable<ReadSubtaskDto> GetAllSubtasks()
        {
            var subtasks = _subtaskRepo.GetAllSubtasks();
            return subtasks.Select(st => new ReadSubtaskDto
            {
                Name = st.Name,
                Description = st.Description,
                Duration = st.Duration,
                TaskId = st.TaskId
            });
        }

        public ReadSubtaskDto? GetSubtask(int subtaskId)
        {
            var st = _subtaskRepo.GetSubtask(subtaskId);
            if (st == null) return null;

            return new ReadSubtaskDto
            {
                Name = st.Name,
                Description = st.Description,
                Duration = st.Duration,
                TaskId = st.TaskId
            };
        }

        public void UpdateSubtask(UpdateSubtaskDto subtaskDto)
        {
            var subtask = new Subtask
            {
                ID = subtaskDto.ID,
                Name = subtaskDto.Name,
                Description = subtaskDto.Description,
                Duration = subtaskDto.Duration,
                TaskId = subtaskDto.TaskId
            };

            _subtaskRepo.UpdateSubtask(subtask);
        }

        public void DeleteSubtask(int subtaskId)
        {
            _subtaskRepo.DeleteSubtask(subtaskId);
        }
    }

}
