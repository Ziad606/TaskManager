using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Domain
{
    public class CreateTaskDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
