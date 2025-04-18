using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public class Task
    {

        public Task()
        {
            Subtasks = new HashSet<Subtask>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<Subtask>? Subtasks { get; set; }

    }
}
