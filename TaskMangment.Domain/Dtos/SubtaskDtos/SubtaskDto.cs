using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Domain
{
    public class SubtaskDto
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public int TaskId { get; set; }
    }
}
