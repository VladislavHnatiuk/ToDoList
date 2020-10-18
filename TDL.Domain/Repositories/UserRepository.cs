using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using TDL.Data.Entities;

using TDL.Domain.Models;
using TDL.Domain.Clients.Mapping;
using TDL.Domain.Repositories.Abstraction;

namespace TDL.Domain.Repositories
{
    public class UserRepository : BaseEFRepository<UserEntity>
    {
        public override UserEntity Add(UserEntity userEntity)
        {
            _dbEntities.UserEntities.Add(userEntity);
            _dbEntities.SaveChanges();

            return userEntity;
        }

        public override UserEntity Get(int id)
        {
            var userEntity = _dbEntities.UserEntities.Find(id);

            return userEntity;
        }

        public override UserEntity Get(Predicate<UserEntity> predicate)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<UserEntity> GetItems()
        {
            var userEntities = _dbEntities.UserEntities.ToList();

            return userEntities;
        }

        public override IEnumerable<UserEntity> GetItems(Func<UserEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var taskEntities = _dbEntities.UserEntities.Where(predicate).ToList();

            return taskEntities;
        }

        public override UserEntity Remove(int id)
        {
            var userEntity = _dbEntities.UserEntities.Find(id);

            userEntity = Remove(userEntity);

            return userEntity;
        }

        public override UserEntity Remove(UserEntity item)
        {
            item = _dbEntities.UserEntities.Remove(item);
            _dbEntities.SaveChanges();

            return item;
        }

        public override UserEntity Update(UserEntity item)
        {
            _dbEntities.Entry<UserEntity>(item).State = EntityState.Modified;
            _dbEntities.SaveChanges();

            return item;
        }
    }
}

//public class UserRepository : BaseEFRepository<User>
//{
//    public override User Add(User item)
//    {
//        if (item == null)
//            throw new ArgumentNullException(nameof(item));

//        var userEntity = MapperClient.Map<User, UserEntity>(item);

//        _dbEntities.UserEntities.Add(userEntity);
//        _dbEntities.SaveChanges();

//        var user = MapperClient.Map<UserEntity, User>(userEntity);

//        return user;
//    }

//    public override User Get(int id)
//    {
//        if (id <= 0)
//            throw new ArgumentOutOfRangeException(nameof(id));

//        var userEntity = _dbEntities.UserEntities.Find(id);

//        if (userEntity == null)
//            return null;
//        else
//        {
//            var user = MapperClient.Map<UserEntity, User>(userEntity);
//            return user;
//        }
//    }

//    public override User Get(Predicate<User> predicate)
//    {
//        throw new NotImplementedException();
//    }

//    public override IEnumerable<User> GetItems()
//    {
//        var userEntities = _dbEntities.UserEntities.ToList();

//        if (userEntities == null || userEntities.Count <= 0)
//            return null;
//        else
//        {
//            var users = MapperClient.Map<UserEntity, User>(userEntities);
//            return users;
//        }
//    }

//    public override User Remove(int id)
//    {
//        if (id <= 0)
//            throw new ArgumentOutOfRangeException(nameof(id));

//        var userEntity = _dbEntities.UserEntities.Find(id);

//        if (userEntity == null)
//            return null;
//        else
//        {
//            userEntity = _dbEntities.UserEntities.Remove(userEntity);
//            _dbEntities.SaveChanges();

//            var user = MapperClient.Map<UserEntity, User>(userEntity);
//            return user;
//        }
//    }

//    public override User Remove(User item)
//    {
//        if (item == null)
//            throw new ArgumentNullException(nameof(item));

//        var userEntity = MapperClient.Map<User, UserEntity>(item);

//        userEntity = _dbEntities.UserEntities.Remove(userEntity);
//        _dbEntities.SaveChanges();

//        if (userEntity == null)
//            return null;
//        else
//        {
//            var user = MapperClient.Map<UserEntity, User>(userEntity);
//            return user;
//        }
//    }

//    public override User Update(User item)
//    {
//        if (item == null)
//            throw new ArgumentNullException(nameof(item));

//        var userEntity = MapperClient.Map<User, UserEntity>(item);

//        _dbEntities.Entry<UserEntity>(userEntity).State = EntityState.Modified;
//        _dbEntities.SaveChanges();

//        var user = MapperClient.Map<UserEntity, User>(userEntity);
//        return user;
//    }
//}

