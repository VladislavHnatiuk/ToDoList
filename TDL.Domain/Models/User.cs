namespace TDL.Domain.Models
{
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; } = default;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;

        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
