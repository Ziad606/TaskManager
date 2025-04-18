using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public class Subtask
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
