namespace TDL.Domain.Models
{
    using System;

    public class Task
    {
        public int TaskId { get; set; } = default;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Created { get; set; } = default;

        public TaskStatus TaskStatus { get; set; } = TaskStatus.Undefined;
    }
}
