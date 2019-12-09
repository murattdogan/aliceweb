using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;

namespace Alice.Service.Service
{
    public class UserService
    {
        private readonly LuxuryContext _dbContext;

        public UserService()
        {
            _dbContext = new LuxuryContext();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            IRepository<User> userRepository = new Repository<User>(_dbContext);
            return userRepository.All().Select(x => new UserDTO() { Id = x.Id, Name = x.Name, Email = x.Email, UserType = x.UserType, LastLoginDate = x.LastLoginDate }).ToList();
        }

        public UserDTO isLoginControl(string username, string password)
        {
            IRepository<User> userRepository = new Repository<User>(_dbContext);
            return userRepository.Where(o => o.Email == username && o.Password == password)?.Select(x => new UserDTO() { Id = x.Id, Name = x.Name, Email = x.Email, UserType = x.UserType, LastLoginDate = x.LastLoginDate })?.First() ?? null;
        }

    }
}
