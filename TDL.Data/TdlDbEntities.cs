namespace TDL.Data
{
    using System.Data.Entity;
    using TDL.Data.DatabaseInitializers;
    using TDL.Data.Entities;

    public class TdlDbEntities : DbContext
    {
        public TdlDbEntities() : base("TdlDbEntitiesConnectionString") 
        {
            // Initializing database by default task status values.
            Database.SetInitializer(new TaskStatusDbInitializer());
        }

        public virtual DbSet<TaskStatusEntity> TaskStatusEntities { get; set; }
        public virtual DbSet<TaskEntity> TaskEntities { get; set; }
        public virtual DbSet<UserEntity> UserEntities { get; set; }
    }
}
