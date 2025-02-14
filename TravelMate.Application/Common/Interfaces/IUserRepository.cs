using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.User;

namespace TravelMate.Application.Common.Interfaces;

public interface IUserRepository
{

    Task<List<User>> GetAllUsers();
    Task<User> GetById(int id);
    Task<User> AddUser(User user);
}
