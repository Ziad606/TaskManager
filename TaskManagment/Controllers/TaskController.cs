using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskMangment.Domain;

namespace TaskManagment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
                _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadTaskDto>> GetAllTasks()
        {
            return Ok(_taskService.GetAllTasks());
        }

        [HttpGet("{Id}")]
        public ActionResult<ReadTaskDto> GetTask(int Id) 
        {
            var task = _taskService.GetTask(Id);
            if(task == null) return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] CreateTaskDto task)
        {
            _taskService.AddTask(task);
            return Ok("Task Added Successfullt");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] UpdateTaskDto task)
        {
            if (id != task.ID)
                return BadRequest("Task ID mismatch");

            _taskService.UpdateTask(task);
            return Ok("Task updated successfully");
        }


        [HttpDelete("{Id}")]
        public IActionResult DeleteTask(int Id)
        {
            _taskService.DeleteTask(Id);
            return Ok("Task Deleted Successfully");
        }

    }
}
