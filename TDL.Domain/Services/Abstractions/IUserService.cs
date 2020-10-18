namespace TDL.Domain.Services.Abstractions
{
    using System.Collections.Generic;

    using TDL.Domain.Models;

    public interface IUserService
    {
        User Add(User user);

        User Edit(User user);

        User FindUserById(int id);

        IEnumerable<User> GetAllUsers();

        User Remove(int id);
        User Remove(User user);
    }
}
