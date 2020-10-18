using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using TDL.Data.Entities;

using TDL.Domain.Repositories.Abstraction;

namespace TDL.Domain.Repositories
{
    public class TaskRepository : BaseEFRepository<TaskEntity>
    {
        public override TaskEntity Add(TaskEntity item)
        {
            _dbEntities.TaskEntities.Add(item);
            _dbEntities.SaveChanges();

            return item;
        }

        public override TaskEntity Get(int id)
        {
            var taskEntity = _dbEntities.TaskEntities.Find(id);

            return taskEntity;
        }

        public override TaskEntity Get(Predicate<TaskEntity> predicate)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TaskEntity> GetItems()
        {
            var taskEntities = _dbEntities.TaskEntities.ToList();

            return taskEntities;
        }

        public override IEnumerable<TaskEntity> GetItems(Func<TaskEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var taskEntities = _dbEntities.TaskEntities.Where(predicate).ToList();

            return taskEntities;
        }

        public override TaskEntity Remove(int id)
        {
            var taskEntity = _dbEntities.TaskEntities.Find(id);

            if (taskEntity == null)
                return null;

            taskEntity = _dbEntities.TaskEntities.Remove(taskEntity);

            if (taskEntity == null)
                return null;
            else
            {
                _dbEntities.SaveChanges();
                return taskEntity;
            }
        }

        public override TaskEntity Remove(TaskEntity taskEntity)
        {
            taskEntity = _dbEntities.TaskEntities.Remove(taskEntity);

            if (taskEntity == null)
                return null;
            else
            {
                _dbEntities.SaveChanges();
                return taskEntity;
            }
        }

        public override TaskEntity Update(TaskEntity taskEntity)
        {
            _dbEntities.Entry<TaskEntity>(taskEntity).State = EntityState.Modified;
            _dbEntities.SaveChanges();

            return taskEntity;
        }
    }
}

//public class TaskRepository : BaseEFRepository<Task>
//{
//    public override Task Add(Task item)
//    {
//        if (item == null)
//            throw new ArgumentNullException(nameof(item));

//        var taskEntity = MapperClient.Map<Task, TaskEntity>(item);

//        _dbEntities.TaskEntities.Add(taskEntity);
//        _dbEntities.SaveChanges();

//        var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
//        return task;
//    }

//    public override Task Get(int id)
//    {
//        if (id <= 0)
//            throw new ArgumentOutOfRangeException(nameof(id));

//        var taskEntity = _dbEntities.TaskEntities.Find(id);

//        if (taskEntity == null)
//            return null;
//        else
//        {
//            var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
//            return task;
//        }
//    }

//    public override Task Get<TSearch>(Predicate<TaskEntity> predicate)
//    {
//        throw new NotImplementedException();
//    }

//    public override IEnumerable<Task> GetItems()
//    {
//        var taskEntities = _dbEntities.TaskEntities.ToList();

//        if (taskEntities == null || taskEntities.Count <= 0)
//            return null;
//        else
//        {
//            var tasks = MapperClient.Map<TaskEntity, Task>(taskEntities);
//            return tasks;
//        }
//    }

//    public override IEnumerable<Task> GetItems(Predicate<Task> predicate)
//    {
//        if (predicate == null)
//            throw new ArgumentNullException(nameof(predicate));

//        var
//        }

//    public override Task Remove(int id)
//    {
//        if (id <= 0)
//            throw new ArgumentOutOfRangeException(nameof(id));

//        var taskEntity = _dbEntities.TaskEntities.Find(id);

//        if (taskEntity == null)
//            return null;

//        taskEntity = _dbEntities.TaskEntities.Remove(taskEntity);
//        _dbEntities.SaveChanges();

//        var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
//        return task;
//    }

//    public override Task Remove(Task item)
//    {
//        if (item == null)
//            throw new ArgumentNullException(nameof(item));

//        var taskEntity = MapperClient.Map<Task, TaskEntity>(item);

//        taskEntity = _dbEntities.TaskEntities.Remove(taskEntity);

//        if (taskEntity == null)
//            return null;
//        else
//        {
//            _dbEntities.SaveChanges();
//            var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
//            return task;
//        }
//    }

//    public override Task Update(Task item)
//    {
//        if (item == null)
//            throw new ArgumentNullException(nameof(item));

//        var taskEntity = MapperClient.Map<Task, TaskEntity>(item);
//        _dbEntities.Entry<TaskEntity>(taskEntity).State = EntityState.Modified;
//        _dbEntities.SaveChanges();

//        var task = MapperClient.Map<TaskEntity, Task>(taskEntity);
//        return task;
//    }
//}

