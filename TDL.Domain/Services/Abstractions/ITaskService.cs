namespace TDL.Domain.Services.Abstractions
{
    using System.Collections.Generic;

    using TDL.Domain.Models;

    public interface ITaskService
    {
        /// <summary>
        /// Adding the task.
        /// </summary>
        /// <param name="task">Task that should be adding.</param>
        /// <returns>Added task.</returns>
        Task AddTask(Task task);

        /// <summary>
        /// Editing task in storage.
        /// </summary>
        /// <param name="task">Editing task.</param>
        /// <returns>Edited task.</returns>
        Task EditTask(Task task);

        /// <summary>
        /// Completing the task.
        /// </summary>
        /// <param name="task">Task that should be completing.</param>
        /// <returns>Completed task.</returns>
        Task CompletedTask(int id);

        /// <summary>
        /// Canceling the task.
        /// </summary>
        /// <param name="task">Task that should be canceling.</param>
        /// <returns>Canceled task.</returns>
        Task CancelTask(int id);

        /// <summary>
        /// Failure of the task.
        /// </summary>
        /// <param name="task">Task that should be failure.</param>
        /// <returns>Failured task.</returns>
        Task FailureTask(int id);

        /// <summary>
        /// Getting task from storage by id.
        /// </summary>
        /// <param name="id">Key for search task in storage.</param>
        /// <returns>Found task.</returns>
        Task FindTaskById(int id);

        /// <summary>
        /// Getting all tasks for user.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>User tasks</returns>
        IEnumerable<Task> GetTasks(int userId);

        /// <summary>
        /// Getting all tasks for user.
        /// </summary>
        /// <param name="user">User.</param>
        /// <returns>User tasks</returns>
        IEnumerable<Task> GetTasks(User user);

        /// <summary>
        /// Getting all tasks.
        /// </summary>
        /// <returns>Tasks.</returns>
        IEnumerable<Task> GetTasks();

        /// <summary>
        /// Removing task from storage by id.
        /// </summary>
        /// <param name="id">Key for search task.</param>
        /// <returns>Deleted task.</returns>
        Task RemoveTask(int id);

        /// <summary>
        /// Removing task from storage by task properties.
        /// </summary>
        /// <param name="task">Task that has properties for deleting.</param>
        /// <returns>Deleted task.</returns>
        Task RemoveTask(Task task);
    }
}
