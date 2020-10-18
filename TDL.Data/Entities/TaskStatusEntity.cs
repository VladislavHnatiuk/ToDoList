namespace TDL.Data.Entities
{
    public class TaskStatusEntity
    {
        public int Id { get; set; }

        public string TaskStatus { get; set; }

        public TaskEntity TaskEntity { get; set; }
    }
}
