namespace TDL.Data.Entities
{
    using System.Collections.Generic;

    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<TaskEntity> TaskEntities { get; set; } = new List<TaskEntity>();
    }
}
