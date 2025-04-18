using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangment.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }


    }
}
