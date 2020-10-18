using System;
using System.Collections.Generic;

using TDL.Data.Entities;

using TDL.Domain.Models;
using TDL.Domain.Clients.Mapping;
using TDL.Domain.Services.Abstractions;
using TDL.Domain.Repositories.Abstraction;

namespace TDL.Domain.Services
{
    public class TaskService : ITaskService
    {
        IRepository<TaskEntity> _repos;

        public TaskService(IRepository<TaskEntity> repository)
        {
            _repos = repository;
        }

        public Task AddTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            //TODO: Validation task before add.

            var taskEntity = MapperClient.Map<Task, TaskEntity>(task);
            _repos.Add(taskEntity);

            task = MapperClient.Map<TaskEntity, Task>(taskEntity);
            return task;
        }

        public Task CancelTask(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var task = FindTaskById(id);

            task.TaskStatus = TaskStatus.Canceled;
            EditTask(task);

            return task;
        }

        public Task CompletedTask(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var task = FindTaskById(id);

            task.TaskStatus = TaskStatus.Completed;
            EditTask(task);

            return task;
        }

        public Task FailureTask(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var task = FindTaskById(id);

            task.TaskStatus = TaskStatus.Failure;
            EditTask(task);

            return task;
        }

        public Task EditTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            // TODO: Validation task before eding.

            var taskEntity = MapperClient.Map<Task, TaskEntity>(task);
            _repos.Update(taskEntity);

            task = MapperClient.Map<TaskEntity, Task>(taskEntity);
            return task;
        }

        public Task FindTaskById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var taskEntity = _repos.Get(id);

            var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
            return task;
        }

        public IEnumerable<Task> GetTasks(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId));

            var taskEntities = _repos.GetItems(x => x.UserEntity.Id == userId);

            var tasks = MapperClient.Map<TaskEntity, Task>(taskEntities);
            return tasks;
        }

        public IEnumerable<Task> GetTasks(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var tasks = GetTasks(user.Id);
            return tasks;
        }

        public IEnumerable<Task> GetTasks()
        {
            var taskEntities = _repos.GetItems();

            var tasks = MapperClient.Map<TaskEntity, Task>(taskEntities);
            return tasks;
        }

        public Task RemoveTask(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var taskEntity = _repos.Remove(id);

            var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
            return task;
        }

        public Task RemoveTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            task = RemoveTask(task.TaskId);
            return task;
        }
    }
}
