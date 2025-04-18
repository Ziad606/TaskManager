using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskMangment.Domain;

namespace TaskManagment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtaskController : ControllerBase
    {
        private readonly ISubtaskService _subtaskService;

        public SubtaskController(ISubtaskService subtaskService)
        {
            _subtaskService = subtaskService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ReadSubtaskDto>> GetAllSubtasks()
        {
            return Ok(_subtaskService.GetAllSubtasks());
        }


        [HttpGet("{id}")]
        public ActionResult<ReadSubtaskDto> GetSubtask(int id)
        {
            var subtask = _subtaskService.GetSubtask(id);
            if (subtask == null) return NotFound();
            return Ok(subtask);
        }


        [HttpPost]
        public IActionResult AddSubtask([FromBody] CreateSubtaskDto subtask)
        {
            _subtaskService.AddSubtask(subtask);
            return Ok("Subtask added successfully");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateSubtask(int id, [FromBody] UpdateSubtaskDto subtask)
        {
            if (id != subtask.ID)
                return BadRequest("Subtask ID mismatch");

            _subtaskService.UpdateSubtask(subtask);
            return Ok("Subtask updated successfully");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteSubtask(int id)
        {
            _subtaskService.DeleteSubtask(id);
            return Ok("Subtask deleted successfully");
        }
    }
}
