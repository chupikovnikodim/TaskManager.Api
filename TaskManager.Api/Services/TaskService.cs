using Microsoft.AspNetCore.Http.HttpResults;
using TaskManager.Api.Models;

namespace TaskManager.Api.Services
{
    public class TaskService
    {
        private List<Models.Task> tasks = new()
        {
            new Models.Task{
                Id = 1,
                Title = "Task 1",
                Description = "Description for Task 1",
                Status = "Pending",
                Priority = "Medium",
                CreatedAt = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7)
            },
            new Models.Task{
                Id = 2,
                Title = "Task 2",
                Description = "Description for Task 2",
                Status = "Pending",
                Priority = "Medium",
                CreatedAt = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7)
            }
        };

        public IEnumerable<Models.Task> GetAll()
        {
            return tasks;
        }

        public Models.Task GetById(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);

        }

        public Models.Task Create(Models.Task task)
        {
            task.Id = tasks.Count == 0
                ? 1
                : tasks.Max(t => t.Id) + 1;

            task.CreatedAt = DateTime.Now;

            tasks.Add(task);
            return task;
        }

        public Models.Task? Update(int id, Models.Task updatedTask)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return null;
            }

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.Status = updatedTask.Status;
            task.Priority = updatedTask.Priority;
            task.DueDate = updatedTask.DueDate;
            return task;

        }

        public bool Delete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return false;
            }

            tasks.Remove(task);
            return true;
        }
    }
}