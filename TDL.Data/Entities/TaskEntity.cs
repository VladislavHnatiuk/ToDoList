namespace TDL.Data.Entities
{
    using System;

    public class TaskEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public TaskStatusEntity TaskStatusEntity { get; set; }
        public UserEntity UserEntity { get; set; }
    }
}
