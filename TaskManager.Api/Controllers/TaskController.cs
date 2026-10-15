using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Models;
using TaskManager.Api.Services;

namespace TaskManager.Api.Controllers
{

    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService taskService;

        public TaskController(TaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet(Name = "GetTasks")]
        public IEnumerable<Models.Task> GetTasks()
        {
            return taskService.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var task = taskService.GetById(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost(Name = "CreateTask")]
        public Models.Task CreateTask(Models.Task task)
        {
            return taskService.Create(task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Models.Task task)
        {
            var updatedTask = taskService.Update(id, task);

            if (updatedTask == null)
            {
                return NotFound();
            }

            return Ok(updatedTask);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var deletedTask = taskService.Delete(id);

            if (!deletedTask)
            { 
                return NoContent();
            }
            return NoContent();
        }

    }
}