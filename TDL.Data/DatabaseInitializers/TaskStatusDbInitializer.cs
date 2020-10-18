namespace TDL.Data.DatabaseInitializers
{
    using System.Data.Entity;

    using TDL.Data.Entities;

    /// <summary>
    /// Initialize database by default task status values.
    /// </summary>
    internal class TaskStatusDbInitializer : CreateDatabaseIfNotExists<TdlDbEntities>
    {
        protected override void Seed(TdlDbEntities context)
        {
            // Creating default task status values.
            TaskStatus ts1 = new TaskStatus() { Name = "Undefined" };
            TaskStatus ts2 = new TaskStatus() { Name = "Executing" };
            TaskStatus ts3 = new TaskStatus() { Name = "Completed" };
            TaskStatus ts4 = new TaskStatus() { Name = "Canceled" };
            TaskStatus ts5 = new TaskStatus() { Name = "Failure" };

            context.TaskStatuses.AddRange(new[]
            {
                ts1,
                ts2,
                ts3,
                ts4,
                ts5,
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
