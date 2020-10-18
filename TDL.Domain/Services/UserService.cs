using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDL.Domain.Models;
using TDL.Domain.Clients.Mapping;
using TDL.Domain.Repositories.Abstraction;
using TDL.Domain.Services.Abstractions;
using TDL.Data.Entities;

namespace TDL.Domain.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repos;

        public UserService(IRepository<UserEntity> repository)
        {
            _repos = repository;
        }

        public User Add(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            //TODO: Validation before adding user.

            var userEntity = MapperClient.Map<User, UserEntity>(user);
            _repos.Add(userEntity);

            user = MapperClient.Map<UserEntity, User>(userEntity);
            return user;
        }

        public User Edit(User user)
        {
            throw new NotImplementedException();
        }

        public User FindUserById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User Remove(int id)
        {
            throw new NotImplementedException();
        }

        public User Remove(User user)
        {
            throw new NotImplementedException();
        }
    }
}
